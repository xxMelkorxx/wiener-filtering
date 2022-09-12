
namespace Wiener_Filtering
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label_f1;
            System.Windows.Forms.Label label_A1;
            System.Windows.Forms.Label label_startInsertion;
            System.Windows.Forms.Label label_A2;
            System.Windows.Forms.Label label_f2;
            System.Windows.Forms.Label label_SNR;
            System.Windows.Forms.GroupBox groupBox_paramsS2;
            System.Windows.Forms.Label label_variance;
            System.Windows.Forms.GroupBox groupBox_graphSgnlS2;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.GroupBox groupBox_graphSgnlS1;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.GroupBox groupBox_paramsS1;
            System.Windows.Forms.GroupBox groupBox_graphCrossCorrelation;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.GroupBox groupBox_graphSpectrumS1;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.GroupBox groupBox_graphOutWiener;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.numericUpDown_variance = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_SNR = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_startInsertion = new System.Windows.Forms.NumericUpDown();
            this.chart_graphSgnlS2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_graphSgnlS1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.numericUpDown_f2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_A2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_A1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_f1 = new System.Windows.Forms.NumericUpDown();
            this.chart_graphCrossCorrelation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_graphSpectrumS1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_graphOutWiener = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_generated = new System.Windows.Forms.Button();
            this.buttonAnalysis = new System.Windows.Forms.Button();
            this.groupBox_analysis = new System.Windows.Forms.GroupBox();
            this.numericUpDown_maxSNR = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_meanOrder = new System.Windows.Forms.NumericUpDown();
            this.progressBar_analysisProgress = new System.Windows.Forms.ProgressBar();
            this.label_analysisProgress = new System.Windows.Forms.Label();
            label_f1 = new System.Windows.Forms.Label();
            label_A1 = new System.Windows.Forms.Label();
            label_startInsertion = new System.Windows.Forms.Label();
            label_A2 = new System.Windows.Forms.Label();
            label_f2 = new System.Windows.Forms.Label();
            label_SNR = new System.Windows.Forms.Label();
            groupBox_paramsS2 = new System.Windows.Forms.GroupBox();
            label_variance = new System.Windows.Forms.Label();
            groupBox_graphSgnlS2 = new System.Windows.Forms.GroupBox();
            groupBox_graphSgnlS1 = new System.Windows.Forms.GroupBox();
            groupBox_paramsS1 = new System.Windows.Forms.GroupBox();
            groupBox_graphCrossCorrelation = new System.Windows.Forms.GroupBox();
            groupBox_graphSpectrumS1 = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            groupBox_graphOutWiener = new System.Windows.Forms.GroupBox();
            groupBox_paramsS2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_variance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SNR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_startInsertion)).BeginInit();
            groupBox_graphSgnlS2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_graphSgnlS2)).BeginInit();
            groupBox_graphSgnlS1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_graphSgnlS1)).BeginInit();
            groupBox_paramsS1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_f2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_A2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_A1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_f1)).BeginInit();
            groupBox_graphCrossCorrelation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_graphCrossCorrelation)).BeginInit();
            groupBox_graphSpectrumS1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_graphSpectrumS1)).BeginInit();
            groupBox_graphOutWiener.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_graphOutWiener)).BeginInit();
            this.groupBox_analysis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_maxSNR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_meanOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // label_f1
            // 
            label_f1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label_f1.AutoSize = true;
            label_f1.Location = new System.Drawing.Point(6, 46);
            label_f1.Name = "label_f1";
            label_f1.Size = new System.Drawing.Size(61, 13);
            label_f1.TabIndex = 5;
            label_f1.Text = "Частота 1:";
            // 
            // label_A1
            // 
            label_A1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label_A1.AutoSize = true;
            label_A1.Location = new System.Drawing.Point(6, 20);
            label_A1.Name = "label_A1";
            label_A1.Size = new System.Drawing.Size(74, 13);
            label_A1.TabIndex = 7;
            label_A1.Text = "Aмплитуда 1:";
            // 
            // label_startInsertion
            // 
            label_startInsertion.AutoSize = true;
            label_startInsertion.Location = new System.Drawing.Point(6, 21);
            label_startInsertion.Name = "label_startInsertion";
            label_startInsertion.Size = new System.Drawing.Size(107, 13);
            label_startInsertion.TabIndex = 7;
            label_startInsertion.Text = "Начало вставки S1:";
            // 
            // label_A2
            // 
            label_A2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label_A2.AutoSize = true;
            label_A2.Location = new System.Drawing.Point(6, 72);
            label_A2.Name = "label_A2";
            label_A2.Size = new System.Drawing.Size(74, 13);
            label_A2.TabIndex = 9;
            label_A2.Text = "Aмплитуда 2:";
            // 
            // label_f2
            // 
            label_f2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label_f2.AutoSize = true;
            label_f2.Location = new System.Drawing.Point(6, 98);
            label_f2.Name = "label_f2";
            label_f2.Size = new System.Drawing.Size(61, 13);
            label_f2.TabIndex = 11;
            label_f2.Text = "Частота 2:";
            // 
            // label_SNR
            // 
            label_SNR.AutoSize = true;
            label_SNR.Location = new System.Drawing.Point(6, 74);
            label_SNR.Name = "label_SNR";
            label_SNR.Size = new System.Drawing.Size(51, 13);
            label_SNR.TabIndex = 10;
            label_SNR.Text = "ОСШ (%):";
            // 
            // groupBox_paramsS2
            // 
            groupBox_paramsS2.Controls.Add(label_variance);
            groupBox_paramsS2.Controls.Add(label_SNR);
            groupBox_paramsS2.Controls.Add(this.numericUpDown_variance);
            groupBox_paramsS2.Controls.Add(this.numericUpDown_SNR);
            groupBox_paramsS2.Controls.Add(label_startInsertion);
            groupBox_paramsS2.Controls.Add(this.numericUpDown_startInsertion);
            groupBox_paramsS2.Location = new System.Drawing.Point(12, 310);
            groupBox_paramsS2.Name = "groupBox_paramsS2";
            groupBox_paramsS2.Size = new System.Drawing.Size(271, 98);
            groupBox_paramsS2.TabIndex = 5;
            groupBox_paramsS2.TabStop = false;
            groupBox_paramsS2.Text = "Параметры сигнала S2:";
            // 
            // label_variance
            // 
            label_variance.AutoSize = true;
            label_variance.Location = new System.Drawing.Point(6, 47);
            label_variance.Name = "label_variance";
            label_variance.Size = new System.Drawing.Size(97, 13);
            label_variance.TabIndex = 13;
            label_variance.Text = "Дисперсия шума:";
            // 
            // numericUpDown_variance
            // 
            this.numericUpDown_variance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_variance.DecimalPlaces = 2;
            this.numericUpDown_variance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_variance.Location = new System.Drawing.Point(165, 45);
            this.numericUpDown_variance.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_variance.Name = "numericUpDown_variance";
            this.numericUpDown_variance.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown_variance.TabIndex = 12;
            this.numericUpDown_variance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_variance.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // numericUpDown_SNR
            // 
            this.numericUpDown_SNR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_SNR.Location = new System.Drawing.Point(165, 72);
            this.numericUpDown_SNR.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown_SNR.Name = "numericUpDown_SNR";
            this.numericUpDown_SNR.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown_SNR.TabIndex = 8;
            this.numericUpDown_SNR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_SNR.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numericUpDown_startInsertion
            // 
            this.numericUpDown_startInsertion.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_startInsertion.Location = new System.Drawing.Point(165, 19);
            this.numericUpDown_startInsertion.Maximum = new decimal(new int[] {
            768,
            0,
            0,
            0});
            this.numericUpDown_startInsertion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_startInsertion.Name = "numericUpDown_startInsertion";
            this.numericUpDown_startInsertion.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown_startInsertion.TabIndex = 6;
            this.numericUpDown_startInsertion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_startInsertion.Value = new decimal(new int[] {
            450,
            0,
            0,
            0});
            // 
            // groupBox_graphSgnlS2
            // 
            groupBox_graphSgnlS2.Controls.Add(this.chart_graphSgnlS2);
            groupBox_graphSgnlS2.Location = new System.Drawing.Point(289, 12);
            groupBox_graphSgnlS2.Name = "groupBox_graphSgnlS2";
            groupBox_graphSgnlS2.Size = new System.Drawing.Size(600, 292);
            groupBox_graphSgnlS2.TabIndex = 7;
            groupBox_graphSgnlS2.TabStop = false;
            groupBox_graphSgnlS2.Text = "График исходного сигнала S2";
            // 
            // chart_graphSgnlS2
            // 
            this.chart_graphSgnlS2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea1.AxisX.Interval = 100D;
            chartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea1.Name = "ChartArea1";
            this.chart_graphSgnlS2.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleBackColor = System.Drawing.Color.White;
            this.chart_graphSgnlS2.Legends.Add(legend1);
            this.chart_graphSgnlS2.Location = new System.Drawing.Point(6, 19);
            this.chart_graphSgnlS2.Name = "chart_graphSgnlS2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.Name = "Cигнал S2";
            this.chart_graphSgnlS2.Series.Add(series1);
            this.chart_graphSgnlS2.Size = new System.Drawing.Size(588, 267);
            this.chart_graphSgnlS2.TabIndex = 1;
            this.chart_graphSgnlS2.Text = "chart_initSgnl";
            // 
            // groupBox_graphSgnlS1
            // 
            groupBox_graphSgnlS1.Controls.Add(this.chart_graphSgnlS1);
            groupBox_graphSgnlS1.Location = new System.Drawing.Point(12, 146);
            groupBox_graphSgnlS1.Name = "groupBox_graphSgnlS1";
            groupBox_graphSgnlS1.Size = new System.Drawing.Size(271, 158);
            groupBox_graphSgnlS1.TabIndex = 13;
            groupBox_graphSgnlS1.TabStop = false;
            groupBox_graphSgnlS1.Text = "График искомого сигнала S1";
            // 
            // chart_graphSgnlS1
            // 
            this.chart_graphSgnlS1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea2.AxisX.Interval = 50D;
            chartArea2.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisX.MajorTickMark.Enabled = false;
            chartArea2.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisY.MajorTickMark.Enabled = false;
            chartArea2.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea2.Name = "ChartArea1";
            this.chart_graphSgnlS1.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            legend2.DockedToChartArea = "ChartArea1";
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            legend2.TitleBackColor = System.Drawing.Color.White;
            this.chart_graphSgnlS1.Legends.Add(legend2);
            this.chart_graphSgnlS1.Location = new System.Drawing.Point(6, 19);
            this.chart_graphSgnlS1.Name = "chart_graphSgnlS1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Blue;
            series2.Legend = "Legend1";
            series2.Name = "Cигнал S1";
            this.chart_graphSgnlS1.Series.Add(series2);
            this.chart_graphSgnlS1.Size = new System.Drawing.Size(259, 133);
            this.chart_graphSgnlS1.TabIndex = 1;
            this.chart_graphSgnlS1.Text = "chart1";
            // 
            // groupBox_paramsS1
            // 
            groupBox_paramsS1.Controls.Add(label_f2);
            groupBox_paramsS1.Controls.Add(this.numericUpDown_f2);
            groupBox_paramsS1.Controls.Add(label_A2);
            groupBox_paramsS1.Controls.Add(this.numericUpDown_A2);
            groupBox_paramsS1.Controls.Add(label_A1);
            groupBox_paramsS1.Controls.Add(this.numericUpDown_A1);
            groupBox_paramsS1.Controls.Add(label_f1);
            groupBox_paramsS1.Controls.Add(this.numericUpDown_f1);
            groupBox_paramsS1.Location = new System.Drawing.Point(12, 12);
            groupBox_paramsS1.Name = "groupBox_paramsS1";
            groupBox_paramsS1.Size = new System.Drawing.Size(271, 128);
            groupBox_paramsS1.TabIndex = 14;
            groupBox_paramsS1.TabStop = false;
            groupBox_paramsS1.Text = "Параметры сигнала S1:";
            // 
            // numericUpDown_f2
            // 
            this.numericUpDown_f2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_f2.DecimalPlaces = 3;
            this.numericUpDown_f2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_f2.Location = new System.Drawing.Point(165, 91);
            this.numericUpDown_f2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_f2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown_f2.Name = "numericUpDown_f2";
            this.numericUpDown_f2.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown_f2.TabIndex = 10;
            this.numericUpDown_f2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_f2.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // numericUpDown_A2
            // 
            this.numericUpDown_A2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_A2.DecimalPlaces = 1;
            this.numericUpDown_A2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_A2.Location = new System.Drawing.Point(165, 65);
            this.numericUpDown_A2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_A2.Name = "numericUpDown_A2";
            this.numericUpDown_A2.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown_A2.TabIndex = 8;
            this.numericUpDown_A2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_A2.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // numericUpDown_A1
            // 
            this.numericUpDown_A1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_A1.DecimalPlaces = 1;
            this.numericUpDown_A1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_A1.Location = new System.Drawing.Point(165, 13);
            this.numericUpDown_A1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_A1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_A1.Name = "numericUpDown_A1";
            this.numericUpDown_A1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown_A1.TabIndex = 6;
            this.numericUpDown_A1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_A1.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // numericUpDown_f1
            // 
            this.numericUpDown_f1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_f1.DecimalPlaces = 3;
            this.numericUpDown_f1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_f1.Location = new System.Drawing.Point(165, 39);
            this.numericUpDown_f1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_f1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown_f1.Name = "numericUpDown_f1";
            this.numericUpDown_f1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown_f1.TabIndex = 4;
            this.numericUpDown_f1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_f1.Value = new decimal(new int[] {
            50,
            0,
            0,
            196608});
            // 
            // groupBox_graphCrossCorrelation
            // 
            groupBox_graphCrossCorrelation.Controls.Add(this.chart_graphCrossCorrelation);
            groupBox_graphCrossCorrelation.Location = new System.Drawing.Point(289, 310);
            groupBox_graphCrossCorrelation.Name = "groupBox_graphCrossCorrelation";
            groupBox_graphCrossCorrelation.Size = new System.Drawing.Size(600, 281);
            groupBox_graphCrossCorrelation.TabIndex = 8;
            groupBox_graphCrossCorrelation.TabStop = false;
            groupBox_graphCrossCorrelation.Text = "График взаимной корреляции сигналов S1 и S2";
            // 
            // chart_graphCrossCorrelation
            // 
            this.chart_graphCrossCorrelation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea3.AxisX.Interval = 100D;
            chartArea3.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.AxisX.MajorTickMark.Enabled = false;
            chartArea3.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.AxisY.MajorTickMark.Enabled = false;
            chartArea3.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea3.Name = "ChartArea1";
            this.chart_graphCrossCorrelation.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.Transparent;
            legend3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            legend3.DockedToChartArea = "ChartArea1";
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            legend3.TitleBackColor = System.Drawing.Color.White;
            this.chart_graphCrossCorrelation.Legends.Add(legend3);
            this.chart_graphCrossCorrelation.Location = new System.Drawing.Point(6, 19);
            this.chart_graphCrossCorrelation.Name = "chart_graphCrossCorrelation";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.Name = "Взаимная корреляция сигналов S1 и S2";
            this.chart_graphCrossCorrelation.Series.Add(series3);
            this.chart_graphCrossCorrelation.Size = new System.Drawing.Size(588, 256);
            this.chart_graphCrossCorrelation.TabIndex = 2;
            this.chart_graphCrossCorrelation.Text = "chart_graphCrossCorrelation";
            // 
            // groupBox_graphSpectrumS1
            // 
            groupBox_graphSpectrumS1.Controls.Add(this.chart_graphSpectrumS1);
            groupBox_graphSpectrumS1.Location = new System.Drawing.Point(895, 12);
            groupBox_graphSpectrumS1.Name = "groupBox_graphSpectrumS1";
            groupBox_graphSpectrumS1.Size = new System.Drawing.Size(600, 292);
            groupBox_graphSpectrumS1.TabIndex = 9;
            groupBox_graphSpectrumS1.TabStop = false;
            groupBox_graphSpectrumS1.Text = "График спектра и его аппроксимация гауссовыми куполами";
            // 
            // chart_graphSpectrumS1
            // 
            this.chart_graphSpectrumS1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea4.AxisX.Interval = 0.1D;
            chartArea4.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea4.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea4.AxisX.MajorTickMark.Enabled = false;
            chartArea4.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea4.AxisX.Minimum = 0D;
            chartArea4.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea4.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea4.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea4.AxisY.MajorTickMark.Enabled = false;
            chartArea4.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea4.AxisY.Minimum = 0D;
            chartArea4.Name = "ChartArea1";
            this.chart_graphSpectrumS1.ChartAreas.Add(chartArea4);
            legend4.BackColor = System.Drawing.Color.Transparent;
            legend4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            legend4.DockedToChartArea = "ChartArea1";
            legend4.IsTextAutoFit = false;
            legend4.Name = "Legend1";
            legend4.TitleBackColor = System.Drawing.Color.White;
            this.chart_graphSpectrumS1.Legends.Add(legend4);
            this.chart_graphSpectrumS1.Location = new System.Drawing.Point(6, 19);
            this.chart_graphSpectrumS1.Name = "chart_graphSpectrumS1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.DarkMagenta;
            series4.Legend = "Legend1";
            series4.Name = "Спектр S1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series5.Legend = "Legend1";
            series5.Name = "Аппроксимация спектра S1";
            this.chart_graphSpectrumS1.Series.Add(series4);
            this.chart_graphSpectrumS1.Series.Add(series5);
            this.chart_graphSpectrumS1.Size = new System.Drawing.Size(588, 267);
            this.chart_graphSpectrumS1.TabIndex = 2;
            this.chart_graphSpectrumS1.Text = "chart_initSgnl";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(131, 13);
            label1.TabIndex = 12;
            label1.Text = "Количество усреднений:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 47);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(131, 13);
            label2.TabIndex = 14;
            label2.Text = "Максимальное ОСШ (%):";
            // 
            // groupBox_graphOutWiener
            // 
            groupBox_graphOutWiener.Controls.Add(this.chart_graphOutWiener);
            groupBox_graphOutWiener.Location = new System.Drawing.Point(895, 310);
            groupBox_graphOutWiener.Name = "groupBox_graphOutWiener";
            groupBox_graphOutWiener.Size = new System.Drawing.Size(600, 281);
            groupBox_graphOutWiener.TabIndex = 24;
            groupBox_graphOutWiener.TabStop = false;
            groupBox_graphOutWiener.Text = "График выхода оптимального фильтра Винера";
            // 
            // chart_graphOutWiener
            // 
            this.chart_graphOutWiener.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea5.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea5.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea5.AxisX.MajorTickMark.Enabled = false;
            chartArea5.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea5.AxisX.Minimum = 0D;
            chartArea5.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea5.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea5.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea5.AxisY.MajorTickMark.Enabled = false;
            chartArea5.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea5.Name = "ChartArea1";
            this.chart_graphOutWiener.ChartAreas.Add(chartArea5);
            legend5.BackColor = System.Drawing.Color.Transparent;
            legend5.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            legend5.DockedToChartArea = "ChartArea1";
            legend5.IsTextAutoFit = false;
            legend5.Name = "Legend1";
            legend5.TitleBackColor = System.Drawing.Color.White;
            this.chart_graphOutWiener.Legends.Add(legend5);
            this.chart_graphOutWiener.Location = new System.Drawing.Point(6, 19);
            this.chart_graphOutWiener.Name = "chart_graphOutWiener";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series6.Legend = "Legend1";
            series6.Name = "Выход оптимального фильтра Винера";
            this.chart_graphOutWiener.Series.Add(series6);
            this.chart_graphOutWiener.Size = new System.Drawing.Size(588, 256);
            this.chart_graphOutWiener.TabIndex = 2;
            this.chart_graphOutWiener.Text = "chart1";
            // 
            // button_generated
            // 
            this.button_generated.Location = new System.Drawing.Point(12, 414);
            this.button_generated.Name = "button_generated";
            this.button_generated.Size = new System.Drawing.Size(271, 25);
            this.button_generated.TabIndex = 10;
            this.button_generated.Text = "Сгенерировать";
            this.button_generated.UseVisualStyleBackColor = true;
            this.button_generated.Click += new System.EventHandler(this.OnClickButtonGenerated);
            // 
            // buttonAnalysis
            // 
            this.buttonAnalysis.Location = new System.Drawing.Point(12, 566);
            this.buttonAnalysis.Name = "buttonAnalysis";
            this.buttonAnalysis.Size = new System.Drawing.Size(271, 25);
            this.buttonAnalysis.TabIndex = 17;
            this.buttonAnalysis.Text = "Анализировать";
            this.buttonAnalysis.UseVisualStyleBackColor = true;
            this.buttonAnalysis.Click += new System.EventHandler(this.OnClickButtonAnalysis);
            // 
            // groupBox_analysis
            // 
            this.groupBox_analysis.Controls.Add(label2);
            this.groupBox_analysis.Controls.Add(this.numericUpDown_maxSNR);
            this.groupBox_analysis.Controls.Add(label1);
            this.groupBox_analysis.Controls.Add(this.numericUpDown_meanOrder);
            this.groupBox_analysis.Location = new System.Drawing.Point(12, 445);
            this.groupBox_analysis.Name = "groupBox_analysis";
            this.groupBox_analysis.Size = new System.Drawing.Size(271, 71);
            this.groupBox_analysis.TabIndex = 18;
            this.groupBox_analysis.TabStop = false;
            this.groupBox_analysis.Text = "Параметры анализа";
            // 
            // numericUpDown_maxSNR
            // 
            this.numericUpDown_maxSNR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_maxSNR.Location = new System.Drawing.Point(165, 45);
            this.numericUpDown_maxSNR.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_maxSNR.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_maxSNR.Name = "numericUpDown_maxSNR";
            this.numericUpDown_maxSNR.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown_maxSNR.TabIndex = 13;
            this.numericUpDown_maxSNR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_maxSNR.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDown_meanOrder
            // 
            this.numericUpDown_meanOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_meanOrder.Location = new System.Drawing.Point(165, 19);
            this.numericUpDown_meanOrder.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_meanOrder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_meanOrder.Name = "numericUpDown_meanOrder";
            this.numericUpDown_meanOrder.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown_meanOrder.TabIndex = 11;
            this.numericUpDown_meanOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_meanOrder.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // progressBar_analysisProgress
            // 
            this.progressBar_analysisProgress.Location = new System.Drawing.Point(12, 535);
            this.progressBar_analysisProgress.Name = "progressBar_analysisProgress";
            this.progressBar_analysisProgress.Size = new System.Drawing.Size(271, 25);
            this.progressBar_analysisProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_analysisProgress.TabIndex = 19;
            this.progressBar_analysisProgress.Visible = false;
            // 
            // label_analysisProgress
            // 
            this.label_analysisProgress.AutoSize = true;
            this.label_analysisProgress.Location = new System.Drawing.Point(10, 519);
            this.label_analysisProgress.Name = "label_analysisProgress";
            this.label_analysisProgress.Size = new System.Drawing.Size(59, 13);
            this.label_analysisProgress.TabIndex = 20;
            this.label_analysisProgress.Text = "Прогресс:";
            this.label_analysisProgress.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1507, 605);
            this.Controls.Add(groupBox_graphOutWiener);
            this.Controls.Add(this.label_analysisProgress);
            this.Controls.Add(this.progressBar_analysisProgress);
            this.Controls.Add(this.groupBox_analysis);
            this.Controls.Add(this.buttonAnalysis);
            this.Controls.Add(groupBox_paramsS1);
            this.Controls.Add(groupBox_graphSgnlS1);
            this.Controls.Add(this.button_generated);
            this.Controls.Add(groupBox_graphSpectrumS1);
            this.Controls.Add(groupBox_graphCrossCorrelation);
            this.Controls.Add(groupBox_graphSgnlS2);
            this.Controls.Add(groupBox_paramsS2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "ННГУ ИТФИ | Обнаружение сигнала методом оптимальной Винеровской фильтрации";
            this.Load += new System.EventHandler(this.OnLoadMainForm);
            groupBox_paramsS2.ResumeLayout(false);
            groupBox_paramsS2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_variance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SNR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_startInsertion)).EndInit();
            groupBox_graphSgnlS2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_graphSgnlS2)).EndInit();
            groupBox_graphSgnlS1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_graphSgnlS1)).EndInit();
            groupBox_paramsS1.ResumeLayout(false);
            groupBox_paramsS1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_f2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_A2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_A1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_f1)).EndInit();
            groupBox_graphCrossCorrelation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_graphCrossCorrelation)).EndInit();
            groupBox_graphSpectrumS1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_graphSpectrumS1)).EndInit();
            groupBox_graphOutWiener.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_graphOutWiener)).EndInit();
            this.groupBox_analysis.ResumeLayout(false);
            this.groupBox_analysis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_maxSNR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_meanOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_generated;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_graphSgnlS2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_graphCrossCorrelation;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_graphSpectrumS1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_graphSgnlS1;
        private System.Windows.Forms.NumericUpDown numericUpDown_SNR;
        private System.Windows.Forms.NumericUpDown numericUpDown_startInsertion;
        private System.Windows.Forms.NumericUpDown numericUpDown_f2;
        private System.Windows.Forms.NumericUpDown numericUpDown_A2;
        private System.Windows.Forms.NumericUpDown numericUpDown_A1;
        private System.Windows.Forms.NumericUpDown numericUpDown_f1;
        private System.Windows.Forms.NumericUpDown numericUpDown_variance;
        private System.Windows.Forms.Button buttonAnalysis;
        private System.Windows.Forms.GroupBox groupBox_analysis;
        private System.Windows.Forms.NumericUpDown numericUpDown_maxSNR;
        private System.Windows.Forms.NumericUpDown numericUpDown_meanOrder;
        private System.Windows.Forms.ProgressBar progressBar_analysisProgress;
        private System.Windows.Forms.Label label_analysisProgress;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_graphOutWiener;
    }
}