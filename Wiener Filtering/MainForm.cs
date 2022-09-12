using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Numerics;
using static Wiener_Filtering.MainFunctions;

namespace Wiener_Filtering
{
    public partial class MainForm : Form
    {
        private readonly double dt = 1f;
        private readonly int lengthS1 = 256, lengthS2 = 1024;
        public MainForm()
        {
            InitializeComponent();
        }
        private void OnLoadMainForm(object sender, EventArgs e)
        {
            OnClickButtonGenerated(null, null);
        }
        private void OnClickButtonGenerated(object sender, EventArgs e)
        {
            // Инициализация параметров.
            var A1 = (double)numericUpDown_A1.Value;                        // Амплитуда 1-ой гармоники
            var A2 = (double)numericUpDown_A2.Value;                        // Амплитуда 2-ой гармоники
            var f1 = (double)numericUpDown_f1.Value;                        // Частота 1-ой гармоники
            var f2 = (double)numericUpDown_f2.Value;                        // Частота 2-ой гармоники
            var nPerFreq = (int)numericUpDown_startInsertion.Value;         // Начальная вставка
            var variance = (double)numericUpDown_variance.Value;            // Дисперсия шума
            var SNR = (double)numericUpDown_SNR.Value / 100;                // ОСШ
            // Генерация сигнала S1.
            var S1 = GenerateDiscreteSignal(lengthS1, new double[2] { A1, A2 }, new double[2] { f1, f2 }, new double[2] { 0f, 0f }, dt);
            // Генерация сигнала S2.
            var S2 = GaussianNoiseSignal(GenerateSignals(lengthS2, S1, nPerFreq, variance), SNR, out double pw);
            // Подсчёт взаимной корреляции S1 и S2.
            var Rxy = ToAbs(RunningCorrelation(S1, S2, lengthS2 - lengthS1));
            // Вычисление выхода оптимального фильтра Винера.
            var S3 = new double[S2.Length]; // Удлинение S1 до длина S2.
            for (int i = 0; i < S3.Length; i++) {
                if (i < S1.Length) S3[i] = S1[i];
                else S3[i] = 0;
            }
            var filterResult = WienerFilter(S3, S2, pw, (f) => SDF(ToAbs(FFTClass.FFT(ToComplex(S3))), new double[2] { f1, f2 }, lengthS1, f), out double[] sdf, out Complex[] spectrumS1);
            // Отрисовка графиков S1 и S2.
            chart_graphSgnlS1.Series[0].Points.Clear();
            for (int i = 0; i < lengthS1; i++)
                chart_graphSgnlS1.Series[0].Points.AddXY(dt * i, S1[i]);
            chart_graphSgnlS2.Series[0].Points.Clear();
            for (int i = 0; i < lengthS2; i++)
                chart_graphSgnlS2.Series[0].Points.AddXY(dt * i, S2[i]);
            // Отрисовка графика взаимной корреляции и выхода оптимального фильтра Винера.
            chart_graphCrossCorrelation.Series[0].Points.Clear();
            chart_graphOutWiener.Series[0].Points.Clear();
            for (int i = 0; i < Rxy.Length; i++) {
                chart_graphCrossCorrelation.Series[0].Points.AddXY(dt * i, Rxy[i] / lengthS2);
                chart_graphOutWiener.Series[0].Points.AddXY(/*(double)i / lengthS2*/dt * i, filterResult[i]);
            }
            chart_graphCrossCorrelation.Series[0].Points[MaxIndex(Rxy)].Label = MaxIndex(Rxy).ToString();
            chart_graphOutWiener.Series[0].Points[MaxIndex(filterResult)].Label = MaxIndex(filterResult).ToString();
            // Отрисовка графика спектра S1 и его аппроксимации.
            chart_graphSpectrumS1.Series[0].Points.Clear();
            chart_graphSpectrumS1.Series[1].Points.Clear();
            for (int i = 0; i < filterResult.Length; i++) {
                chart_graphSpectrumS1.Series[0].Points.AddXY((double)i / lengthS2, spectrumS1[i].Magnitude);
                chart_graphSpectrumS1.Series[1].Points.AddXY((double)i / lengthS2, sdf[i]);
            }
        }
        private void OnClickButtonAnalysis(object sender, EventArgs e)
        {
            var meanOrder = (int)numericUpDown_meanOrder.Value;
            var maxSNR = (int)numericUpDown_maxSNR.Value;
            var analysisResults = new double[maxSNR + 1];
            var rnd = new Random(Guid.NewGuid().GetHashCode());
            if (MessageBox.Show(this, "Полный анализ может занимать несколько минут в зависимости от порядка анализа.\nВы уверены что хотите запустить полный анализ?",
                "Предупрежение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                progressBar_analysisProgress.Value = 0;
                progressBar_analysisProgress.Minimum = 0;
                progressBar_analysisProgress.Maximum = 1000;
                progressBar_analysisProgress.Step = 1000 / maxSNR;
                progressBar_analysisProgress.Visible = true;
                label_analysisProgress.Visible = true;

                // Запуск отдельного потока под анализ
                var analysisTask = Task.Factory.StartNew(() =>
                {
                    label_analysisProgress.Text = "Прогресс 0%";
                    for (int i = 0; i <= analysisResults.Length; i++) {
                        if (i == 0) {
                            label_analysisProgress.Text = string.Format("Прогресс {0}%: ОСШ - {1}%", Math.Round(100.0 / maxSNR * i, 2), i);
                            continue;
                        }

                        var count = 0.0;
                        //for (int k = 0; k < meanOrder; k++) {
                        Parallel.For(0, meanOrder, k => {
                            //label_analysisProgress.Text = string.Format("Прогресс {0}%: ОСШ - {1}% ({2} / {3})", 100.0 / maxSNR * i, i, k + 1, meanOrder);
                            // Инициадизация параметров.
                            var A1 = GetRandomNumber(rnd, 1.0, 5.0);
                            var A2 = GetRandomNumber(rnd, 1.0, 5.0);
                            var f1 = GetRandomNumber(rnd, 0.01, 0.2);
                            var f2 = GetRandomNumber(rnd, 0.01, 0.2);
                            var variance = GetRandomNumber(rnd, 0.5, 2.0);
                            var nPerFreq = rnd.Next(1, lengthS2 - lengthS1);
                            // Генерация сигнала S1.
                            var S1 = GenerateDiscreteSignal(lengthS1, new double[2] { A1, A2 }, new double[2] { f1, f2 }, new double[2] { 0.0, 0.0 }, dt);
                            // Генерация сигнала S2.
                            var S2 = GaussianNoiseSignal(GenerateSignals(lengthS2, S1, nPerFreq, variance), i, out double pw);
                            // Вычисление выхода фильтра Винера.
                            var S3 = new double[S2.Length];
                            for (int n = 0; n < S3.Length; n++) {
                                if (n < S1.Length) S3[n] = S1[n];
                                else S3[n] = 0;
                            }
                            var filterResult = WienerFilter(S3, S2, pw, (f) => SDF(ToAbs(FFTClass.FFT(ToComplex(S3))), new double[2] { f1, f2 }, lengthS1, f), out _, out _);
                            // Поиск максимума.
                            var estStart = MaxIndex(filterResult);
                            
                            if (estStart > nPerFreq + lengthS2 * 0.01 || estStart < nPerFreq - lengthS2 * 0.01) count++;
                            
                            // Подсчёт смещения.
                            //analysisResults[i] += Math.Abs(estStart - nPerFreq);
                        });
                        //analysisResults[i] /= meanOrder;
                        analysisResults[i] = count / meanOrder * 100.0;
                        progressBar_analysisProgress.PerformStep();
                        label_analysisProgress.Text = string.Format("Прогресс {0}%: ОСШ - {1}%", 100.0 / maxSNR * i, i);

                        Application.DoEvents();
                    }
                });

                while (!analysisTask.IsCompleted)
                    Application.DoEvents();

                var analysisForm = new AnalysisForm();

                // Отрисовка графика ОСШ.
                analysisForm.label_meanOrder.Text = string.Format("Количество усреднений: {0}", meanOrder);
                analysisForm.chart_graphSNR.Series[0].Points.Clear();
                for (int i = 0; i < analysisResults.Length; i++)
                    analysisForm.chart_graphSNR.Series[0].Points.AddXY(i, analysisResults[i]);

                analysisForm.TopMost = true;
                analysisForm.Show();
            }
        }
    }
}