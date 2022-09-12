using System;
using System.Numerics;

namespace Wiener_Filtering
{
    class MainFunctions
    {
        /// <summary>
        /// Функция гармоники.
        /// </summary>
        /// <param name="A">Амплитуда</param>
        /// <param name="f">Частота</param>
        /// <param name="phi">Начальная фаза</param>
        /// <param name="t">Переменная</param>
        /// <returns></returns>
        public static double HarmonicFunction(double A, double f, double phi, double t)
        {
            return A * Math.Sin(2 * Math.PI * f * t + phi);
        }
        /// <summary>
        /// Гауссова функиция.
        /// </summary>
        /// <param name="a">Амплитуда</param>
        /// <param name="SKO">Среднеквдаратичное отклонение</param>
        /// <param name="E">Математическое ожидание</param>
        /// <param name="t">Переменная времени</param>
        private static double GaussFunction(double A, double f, double fd, double sigma)
        {
            return A * Math.Exp(-Math.Pow((f - fd) / sigma, 2));
        }
        /// <summary>
        /// Генерация дискретного сигнала.
        /// </summary>
        /// <param name="length"></param>
        /// <param name="A"></param>
        /// <param name="f"></param>
        /// <param name="dt"></param>
        /// <param name="phi"></param>
        /// <returns></returns>
        public static double[] GenerateDiscreteSignal(int length, double[] A, double[] f, double[] phi, double dt)
        {
            var signal = new double[length];
            for (int k = 0; k < A.Length; k++)
                for (int i = 0; i < length; i++)
                    signal[i] += HarmonicFunction(A[k], f[k], phi[k], i * dt);
            return signal;
        }
        /// <summary>
        /// Вставка сигнала в длинный сигнал шума.
        /// </summary>
        /// <param name="length">Длина сигнала шума</param>
        /// <param name="S1">Вставляемый сигнал</param>
        /// <param name="nPerFreq">Номер отсчёта, с которого вставляется сигнал</param>
        /// <param name="pw">Дисперсия шума</param>
        /// <returns></returns>
        public static double[] GenerateSignals(int length, double[] S1, int nPerFreq, double pw)
        {
            var S2 = new double[length];

            Array.Copy(S1, 0, S2, nPerFreq, S1.Length);
            Array.Copy(GaussianNoise(nPerFreq - 1, pw), 0, S2, 0, nPerFreq - 1);
            Array.Copy(GaussianNoise(S2.Length - S1.Length - nPerFreq, pw), 0, S2, nPerFreq + S1.Length, S2.Length - S1.Length - nPerFreq);

            return S2;
        }
        /// <summary>
        /// Вставка сигнала в длинный сигнал шума.
        /// </summary>
        /// <param name="length">Длина сигнала шума</param>
        /// <param name="S1">Вставляемый сигнал</param>
        /// <param name="nPerFreq">Номер отсчёта, с которого вставляется сигнал</param>
        /// <param name="pw">Дисперсия шума</param>
        /// <returns></returns>
        public static double[] GenerateSignals(int length, double[] S1, int nPerFreq, double dt, double pw)
        {
            var rnd = new Random(Guid.NewGuid().GetHashCode());
            var S2 = new double[length];

            for (int i = 0; i < nPerFreq; i++)
                S2[i] = HarmonicFunction(Max(S1), 0.05/*GetRandomNumber(rnd, 0.05, 0.2)*/, 0.0, dt * i);
            Array.Copy(S1, 0, S2, nPerFreq, S1.Length);
            for (int i = S2.Length - S1.Length - nPerFreq; i < S2.Length; i++)
                S2[i] = HarmonicFunction(Max(S1), 0.1/*GetRandomNumber(rnd, 0.05, 0.2)*/, 0.0, dt * i);


            return S2;
        }
        /// <summary>
        /// Генерация случайного числа с равномерным распределением.
        /// </summary>
        /// <param name="rnd">Экземпляр типа Random</param>
        /// <param name="min">Минимальное число (левая граница)</param>
        /// <param name="max">Максимальное число (правая граница)</param>
        /// <returns>Случайное равномерно распределённое число</returns>
        public static double GetRandomNumber(Random rnd, double min, double max)
        {
            return rnd.NextDouble() * (max - min) + min;
        }
        /// <summary>
        /// Генерация случайного числа с нормальным распределением.
        /// </summary>
        /// <param name="rnd">Экземпляр типа Random</param>
        /// <param name="min">Минимальное число (левая граница)</param>
        /// <param name="max">Максимальное число (правая граница)</param>
        /// <param name="n">Количество случайных чисел, которые необходимо суммировать для достижения нормального распределения</param>
        /// <returns>Случайное нормально распределённое число</returns>
        private static double GetNormalRandom(Random rnd, double min, double max, int n = 12)
        {
            var sum = 0.0;
            for (int i = 0; i < n; i++)
                sum += GetRandomNumber(rnd, min, max);
            return sum / n;
        }
        /// <summary>
        /// Возвращает сумму квадратов заданного массива значений.
        /// </summary>
        /// <param name="values"></param>
        /// <returns>Значения, которые будут использоваться для расчета</returns>
        private static double SumOfSquares(double[] values)
        {
            var sum = 0.0;
            foreach (double x in values)
                sum += x * x;
            return sum;
        }
        /// <summary>
        /// Создает сигнал с гауссовым белым шумом на основе заданного сигнала и процента энергии для шума.
        /// </summary>
        /// <param name="signal">Оригинальный сигнал</param>
        /// <param name="intensity">Интенсивность шума</param>
        /// <param name="n">Количество случайных чисел, которые необходимо суммировать для достижения нормального распределения</param>
        /// <returns>Новый сигнал с гауссовым белым шумом</returns>
        public static double[] GaussianNoiseSignal(double[] signal, double snr, out double pw, int n = 12)
        {
            var noisySignal = new double[signal.Length];
            var noise = new double[signal.Length];
            var rnd = new Random(Guid.NewGuid().GetHashCode());

            // Генерация белого шума.
            signal.CopyTo(noisySignal, 0);
            for (int i = 0; i < signal.Length; i++)
                noise[i] = GetNormalRandom(rnd, -1.0, 1.0, n);
            // Нормировка шума.
            for (int i = 0; i < noise.Length; i++)
                noise[i] *= Math.Sqrt(snr * SumOfSquares(signal) / SumOfSquares(noise));
            // Дисперсия шума.
            pw = SumOfSquares(noise) / noise.Length;
            // Наложение шума на сигнал.
            for (int i = 0; i < noisySignal.Length; i++)
                noisySignal[i] += noise[i];

            return noisySignal;
        }
        /// <summary>
        /// Генерация гауссова шума.
        /// </summary>
        /// <param name="length">Число отсчётов</param>
        /// <param name="pw">Дисперсия шума</param>
        /// <param name="n">Количество случайных чисел, которые необходимо суммировать для достижения нормального распределения</param>
        /// <returns></returns>
        public static double[] GaussianNoise(int length, double pw, int n = 12)
        {
            var noise = new double[length];
            var rnd = new Random(Guid.NewGuid().GetHashCode());

            // Генерация белого шума.
            for (int i = 0; i < noise.Length; i++)
                noise[i] = GetNormalRandom(rnd, -1, 1, n);
            // Нормировка шума.
            for (int i = 0; i < noise.Length; i++)
                noise[i] *= Math.Sqrt(pw / (SumOfSquares(noise) / noise.Length));

            return noise;
        }
        /// <summary>
        /// Вычисление взаимной корреляции двух сигналов.
        /// </summary>
        /// <param name="x">Сигнал х</param>
        /// <param name="y">Сигнад y</param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static double[] RunningCorrelation(double[] x, double[] y, int p)
        {
            var result = new double[y.Length];
            for (int m = 0; m < p; m++)
                for (int i = 0; i < x.Length; i++)
                    result[m] += x[i] * y[i + m];
            return result;
        }

        /// <summary>
        /// Оптимальная характеристика фильтра Винера.
        /// </summary>
        /// <param name="S1">Искомый сигнал S1</param>
        /// <param name="pw">Дисперсия шума</param>
        /// <param name="SDF">Функция спектральной плотности чистого сигнала</param>
        /// <param name="SNR">Функция ОСШ</param>
        /// <returns></returns>
        public static Complex[] WienerFilterCharacteristics(Complex[] H, double pw, Func<double, double> SDF, out double[] sdf)
        {
            // Аппроксимации спектра исходного сигнала.
            sdf = new double[H.Length];
            for (int i = 0; i < sdf.Length / 2; i++) {
                sdf[i] = SDF((double)i / H.Length);
                sdf[sdf.Length - 1 - i] = sdf[i];
            }
            // Вычисление фильтра Винера.
            var result = new Complex[H.Length];
            for (int i = 0; i < result.Length; i++)
                result[i] = Complex.Conjugate(H[i]) / (Complex.Pow(Complex.Abs(H[i]), 2) + pw / sdf[i]);

            return result;
        }
        /// <summary>
        /// Аппроксимация спектра исходного сигнала.
        /// </summary>
        /// <param name="spectrum">Спектр искомого сигнала.</param>
        /// <param name="fd">Массив часто исходного сигнала</param>
        /// <param name="lengthS1">Длина искомого сигнала</param>
        /// <param name="f">Переменная частоты f</param>
        /// <returns></returns>
        public static double SDF(double[] spectrum, double[] fd, int lengthS1, double f)
        {
            double max1 = 0.0, max2 = 0.0;
            for (int i = 0; i < spectrum.Length / 2; i++) {
                if (spectrum[i] > max1) {
                    max1 = spectrum[i];
                    continue;
                }
                if (spectrum[i] > max2)
                    max2 = spectrum[i];
            }
            return GaussFunction(max1, f, fd[0], 3.0 / 4.0 / lengthS1) /*+ GaussFunction(max2, f, fd[1], 3.0 / 4.0 / lengthS1)*/;
        }
        /// <summary>
        /// Выход фильтра Винера.
        /// </summary>
        /// <param name="S1">Искомый сигнал</param>
        /// <param name="S2">Исходный сигнал</param>
        /// <param name="pw">Дисперсия шума</param>
        /// <param name="SDF">Функция СПМ искомого сигнала</param>
        /// <param name="SNR">Отношение сигнал/шум</param>
        /// <returns></returns>
        public static double[] WienerFilter(double[] S1, double[] S2, double pw, Func<double, double> SDF, out double[] sdf, out Complex[] spectrumS3)
        {
            // Вычисление оптимальной характеристики фильтра Винера.
            spectrumS3 = FFTClass.FFT(ToComplex(S1));
            var filter = WienerFilterCharacteristics(FFTClass.FFT(ToComplex(S1)), pw, SDF, out sdf);     // Вычисление оптимальной характеристики фильтра Винера.
            // Вычисление выхода Винера.
            var spectrum = FFTClass.FFT(ToComplex(S2));
            var filterOutput = new Complex[S2.Length];
            for (int i = 0; i < filterOutput.Length; i++)
                filterOutput[i] = spectrum[i] * filter[i];

            //return ToAbs(filter);
            //return ToAbs(spectrum);
            //return ToAbs(filterOutput);
            return ToAbs(FFTClass.FFT(filterOutput, false));
        }
        public static double[] ToAbs(double[] array)
        {
            var abs = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
                abs[i] = Math.Abs(array[i]);
            return abs;
        }
        public static double[] ToAbs(Complex[] arrayComplex)
        {
            var abs = new double[arrayComplex.Length];
            for (int i = 0; i < arrayComplex.Length; i++)
                abs[i] = Complex.Abs(arrayComplex[i]);
            return abs;
        }
        public static Complex[] ToComplex(double[] array)
        {
            var comp = new Complex[array.Length];
            for (int i = 0; i < array.Length; i++)
                comp[i] = new Complex(array[i], 0);
            return comp;
        }
        public static double Max(double[] array)
        {
            var max = array[0];
            for (int i = 0; i < array.Length; i++)
                if (array[i] > max)
                    max = array[i];
            return max;
        }
        public static int MaxIndex(double[] array)
        {
            var maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
                if (array[i] > array[maxIndex])
                    maxIndex = i;
            return maxIndex;
        }
    }
}