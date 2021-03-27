namespace Optimization
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.formula = new System.Windows.Forms.Label();
            this.alphaLabel = new System.Windows.Forms.Label();
            this.alpha1Label = new System.Windows.Forms.Label();
            this.bettaLabel = new System.Windows.Forms.Label();
            this.betta1Label = new System.Windows.Forms.Label();
            this.muLabel = new System.Windows.Forms.Label();
            this.mu1Label = new System.Windows.Forms.Label();
            this.NLabel = new System.Windows.Forms.Label();
            this.V2Label = new System.Windows.Forms.Label();
            this.V1Label = new System.Windows.Forms.Label();
            this.LeftBorderA1Label = new System.Windows.Forms.Label();
            this.RightBorderA1Label = new System.Windows.Forms.Label();
            this.LeftBorderA2Label = new System.Windows.Forms.Label();
            this.RightBorderA2Label = new System.Windows.Forms.Label();
            this.StepLabel = new System.Windows.Forms.Label();
            this.WorkShift = new System.Windows.Forms.Label();
            this.CostPrice = new System.Windows.Forms.Label();
            this.Accuracy = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.V2Num = new System.Windows.Forms.NumericUpDown();
            this.V1Num = new System.Windows.Forms.NumericUpDown();
            this.NNum = new System.Windows.Forms.NumericUpDown();
            this.mu1Num = new System.Windows.Forms.NumericUpDown();
            this.muNum = new System.Windows.Forms.NumericUpDown();
            this.betta1Num = new System.Windows.Forms.NumericUpDown();
            this.bettaNum = new System.Windows.Forms.NumericUpDown();
            this.alpha1Num = new System.Windows.Forms.NumericUpDown();
            this.alphaNum = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.StepNum = new System.Windows.Forms.NumericUpDown();
            this.RightBorderA2Num = new System.Windows.Forms.NumericUpDown();
            this.LeftBorderA2Num = new System.Windows.Forms.NumericUpDown();
            this.RightBorderA1Num = new System.Windows.Forms.NumericUpDown();
            this.LeftBorderA1Num = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.AccuracyNum = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CostPriceNum = new System.Windows.Forms.NumericUpDown();
            this.WorkShiftNum = new System.Windows.Forms.NumericUpDown();
            this.CalculationButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageResult = new System.Windows.Forms.TabPage();
            this.labelDrawing = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.tabPage2d = new System.Windows.Forms.TabPage();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.userControl2D1 = new _2dWPF.UserControl2D();
            this.tabPage3d = new System.Windows.Forms.TabPage();
            this.elementHost2 = new System.Windows.Forms.Integration.ElementHost();
            this.userControl3D1 = new _2dWPF.UserControl3D();
            this.label12 = new System.Windows.Forms.Label();
            this.radioBox = new System.Windows.Forms.RadioButton();
            this.radioHalfDiv = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.V2Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.V1Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mu1Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betta1Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bettaNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alpha1Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaNum)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StepNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBorderA2Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBorderA2Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBorderA1Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBorderA1Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccuracyNum)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CostPriceNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkShiftNum)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageResult.SuspendLayout();
            this.tabPage2d.SuspendLayout();
            this.tabPage3d.SuspendLayout();
            this.SuspendLayout();
            // 
            // formula
            // 
            this.formula.AutoSize = true;
            this.formula.Location = new System.Drawing.Point(13, 24);
            this.formula.Name = "formula";
            this.formula.Size = new System.Drawing.Size(392, 13);
            this.formula.TabIndex = 0;
            this.formula.Text = "C = alpha*(A1^2 + betta*A2 - mu*V1)^N + alpha1*(A1 + betta1*A2^2 - mu1*V2)^N";
            // 
            // alphaLabel
            // 
            this.alphaLabel.AutoSize = true;
            this.alphaLabel.Location = new System.Drawing.Point(7, 28);
            this.alphaLabel.Name = "alphaLabel";
            this.alphaLabel.Size = new System.Drawing.Size(33, 13);
            this.alphaLabel.TabIndex = 2;
            this.alphaLabel.Text = "alpha";
            // 
            // alpha1Label
            // 
            this.alpha1Label.AutoSize = true;
            this.alpha1Label.Location = new System.Drawing.Point(6, 54);
            this.alpha1Label.Name = "alpha1Label";
            this.alpha1Label.Size = new System.Drawing.Size(39, 13);
            this.alpha1Label.TabIndex = 3;
            this.alpha1Label.Text = "alpha1";
            // 
            // bettaLabel
            // 
            this.bettaLabel.AutoSize = true;
            this.bettaLabel.Location = new System.Drawing.Point(6, 80);
            this.bettaLabel.Name = "bettaLabel";
            this.bettaLabel.Size = new System.Drawing.Size(31, 13);
            this.bettaLabel.TabIndex = 4;
            this.bettaLabel.Text = "betta";
            // 
            // betta1Label
            // 
            this.betta1Label.AutoSize = true;
            this.betta1Label.Location = new System.Drawing.Point(6, 106);
            this.betta1Label.Name = "betta1Label";
            this.betta1Label.Size = new System.Drawing.Size(37, 13);
            this.betta1Label.TabIndex = 5;
            this.betta1Label.Text = "betta1";
            // 
            // muLabel
            // 
            this.muLabel.AutoSize = true;
            this.muLabel.Location = new System.Drawing.Point(6, 132);
            this.muLabel.Name = "muLabel";
            this.muLabel.Size = new System.Drawing.Size(21, 13);
            this.muLabel.TabIndex = 6;
            this.muLabel.Text = "mu";
            // 
            // mu1Label
            // 
            this.mu1Label.AutoSize = true;
            this.mu1Label.Location = new System.Drawing.Point(7, 158);
            this.mu1Label.Name = "mu1Label";
            this.mu1Label.Size = new System.Drawing.Size(27, 13);
            this.mu1Label.TabIndex = 7;
            this.mu1Label.Text = "mu1";
            // 
            // NLabel
            // 
            this.NLabel.AutoSize = true;
            this.NLabel.Location = new System.Drawing.Point(7, 184);
            this.NLabel.Name = "NLabel";
            this.NLabel.Size = new System.Drawing.Size(15, 13);
            this.NLabel.TabIndex = 8;
            this.NLabel.Text = "N";
            // 
            // V2Label
            // 
            this.V2Label.AutoSize = true;
            this.V2Label.Location = new System.Drawing.Point(7, 236);
            this.V2Label.Name = "V2Label";
            this.V2Label.Size = new System.Drawing.Size(20, 13);
            this.V2Label.TabIndex = 9;
            this.V2Label.Text = "V2";
            // 
            // V1Label
            // 
            this.V1Label.AutoSize = true;
            this.V1Label.Location = new System.Drawing.Point(6, 210);
            this.V1Label.Name = "V1Label";
            this.V1Label.Size = new System.Drawing.Size(20, 13);
            this.V1Label.TabIndex = 10;
            this.V1Label.Text = "V1";
            // 
            // LeftBorderA1Label
            // 
            this.LeftBorderA1Label.AutoSize = true;
            this.LeftBorderA1Label.Location = new System.Drawing.Point(5, 24);
            this.LeftBorderA1Label.Name = "LeftBorderA1Label";
            this.LeftBorderA1Label.Size = new System.Drawing.Size(99, 13);
            this.LeftBorderA1Label.TabIndex = 21;
            this.LeftBorderA1Label.Text = "Левая граница А1";
            // 
            // RightBorderA1Label
            // 
            this.RightBorderA1Label.AutoSize = true;
            this.RightBorderA1Label.Location = new System.Drawing.Point(5, 50);
            this.RightBorderA1Label.Name = "RightBorderA1Label";
            this.RightBorderA1Label.Size = new System.Drawing.Size(105, 13);
            this.RightBorderA1Label.TabIndex = 22;
            this.RightBorderA1Label.Text = "Правая граница А1";
            // 
            // LeftBorderA2Label
            // 
            this.LeftBorderA2Label.AutoSize = true;
            this.LeftBorderA2Label.Location = new System.Drawing.Point(5, 76);
            this.LeftBorderA2Label.Name = "LeftBorderA2Label";
            this.LeftBorderA2Label.Size = new System.Drawing.Size(99, 13);
            this.LeftBorderA2Label.TabIndex = 23;
            this.LeftBorderA2Label.Text = "Левая граница А2";
            // 
            // RightBorderA2Label
            // 
            this.RightBorderA2Label.AutoSize = true;
            this.RightBorderA2Label.Location = new System.Drawing.Point(5, 102);
            this.RightBorderA2Label.Name = "RightBorderA2Label";
            this.RightBorderA2Label.Size = new System.Drawing.Size(105, 13);
            this.RightBorderA2Label.TabIndex = 24;
            this.RightBorderA2Label.Text = "Правая граница А2";
            // 
            // StepLabel
            // 
            this.StepLabel.AutoSize = true;
            this.StepLabel.Location = new System.Drawing.Point(5, 128);
            this.StepLabel.Name = "StepLabel";
            this.StepLabel.Size = new System.Drawing.Size(87, 13);
            this.StepLabel.TabIndex = 25;
            this.StepLabel.Text = "Начальный Шаг";
            // 
            // WorkShift
            // 
            this.WorkShift.AutoSize = true;
            this.WorkShift.Location = new System.Drawing.Point(6, 21);
            this.WorkShift.Name = "WorkShift";
            this.WorkShift.Size = new System.Drawing.Size(84, 13);
            this.WorkShift.TabIndex = 27;
            this.WorkShift.Text = "Рабочая смена";
            // 
            // CostPrice
            // 
            this.CostPrice.AutoSize = true;
            this.CostPrice.Location = new System.Drawing.Point(6, 47);
            this.CostPrice.Name = "CostPrice";
            this.CostPrice.Size = new System.Drawing.Size(86, 13);
            this.CostPrice.TabIndex = 28;
            this.CostPrice.Text = "Себестоимость";
            // 
            // Accuracy
            // 
            this.Accuracy.AutoSize = true;
            this.Accuracy.Location = new System.Drawing.Point(6, 72);
            this.Accuracy.Name = "Accuracy";
            this.Accuracy.Size = new System.Drawing.Size(75, 13);
            this.Accuracy.TabIndex = 29;
            this.Accuracy.Text = "Погрешность";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "часов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "у.е.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "м^3/ч";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "м^3/ч";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "м^3/ч";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(214, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "м^3/ч";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(140, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "шт.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(140, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "м^3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(140, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "м^3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.V2Num);
            this.groupBox1.Controls.Add(this.V1Num);
            this.groupBox1.Controls.Add(this.NNum);
            this.groupBox1.Controls.Add(this.mu1Num);
            this.groupBox1.Controls.Add(this.muNum);
            this.groupBox1.Controls.Add(this.betta1Num);
            this.groupBox1.Controls.Add(this.bettaNum);
            this.groupBox1.Controls.Add(this.alpha1Num);
            this.groupBox1.Controls.Add(this.alphaNum);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.V1Label);
            this.groupBox1.Controls.Add(this.V2Label);
            this.groupBox1.Controls.Add(this.NLabel);
            this.groupBox1.Controls.Add(this.mu1Label);
            this.groupBox1.Controls.Add(this.muLabel);
            this.groupBox1.Controls.Add(this.betta1Label);
            this.groupBox1.Controls.Add(this.bettaLabel);
            this.groupBox1.Controls.Add(this.alpha1Label);
            this.groupBox1.Controls.Add(this.alphaLabel);
            this.groupBox1.Location = new System.Drawing.Point(6, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 268);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Входные параметры";
            // 
            // V2Num
            // 
            this.V2Num.Location = new System.Drawing.Point(46, 234);
            this.V2Num.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.V2Num.Name = "V2Num";
            this.V2Num.Size = new System.Drawing.Size(88, 20);
            this.V2Num.TabIndex = 60;
            this.V2Num.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // V1Num
            // 
            this.V1Num.Location = new System.Drawing.Point(46, 208);
            this.V1Num.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.V1Num.Name = "V1Num";
            this.V1Num.Size = new System.Drawing.Size(88, 20);
            this.V1Num.TabIndex = 59;
            this.V1Num.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // NNum
            // 
            this.NNum.Location = new System.Drawing.Point(46, 182);
            this.NNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NNum.Name = "NNum";
            this.NNum.Size = new System.Drawing.Size(88, 20);
            this.NNum.TabIndex = 58;
            this.NNum.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // mu1Num
            // 
            this.mu1Num.Location = new System.Drawing.Point(46, 156);
            this.mu1Num.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.mu1Num.Name = "mu1Num";
            this.mu1Num.Size = new System.Drawing.Size(88, 20);
            this.mu1Num.TabIndex = 57;
            this.mu1Num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // muNum
            // 
            this.muNum.Location = new System.Drawing.Point(46, 130);
            this.muNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.muNum.Name = "muNum";
            this.muNum.Size = new System.Drawing.Size(88, 20);
            this.muNum.TabIndex = 56;
            this.muNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // betta1Num
            // 
            this.betta1Num.Location = new System.Drawing.Point(46, 104);
            this.betta1Num.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.betta1Num.Name = "betta1Num";
            this.betta1Num.Size = new System.Drawing.Size(88, 20);
            this.betta1Num.TabIndex = 55;
            this.betta1Num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bettaNum
            // 
            this.bettaNum.Location = new System.Drawing.Point(46, 78);
            this.bettaNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.bettaNum.Name = "bettaNum";
            this.bettaNum.Size = new System.Drawing.Size(88, 20);
            this.bettaNum.TabIndex = 54;
            this.bettaNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // alpha1Num
            // 
            this.alpha1Num.Location = new System.Drawing.Point(46, 52);
            this.alpha1Num.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.alpha1Num.Name = "alpha1Num";
            this.alpha1Num.Size = new System.Drawing.Size(88, 20);
            this.alpha1Num.TabIndex = 53;
            this.alpha1Num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // alphaNum
            // 
            this.alphaNum.Location = new System.Drawing.Point(46, 26);
            this.alphaNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.alphaNum.Name = "alphaNum";
            this.alphaNum.Size = new System.Drawing.Size(88, 20);
            this.alphaNum.TabIndex = 52;
            this.alphaNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.StepNum);
            this.groupBox2.Controls.Add(this.RightBorderA2Num);
            this.groupBox2.Controls.Add(this.LeftBorderA2Num);
            this.groupBox2.Controls.Add(this.RightBorderA1Num);
            this.groupBox2.Controls.Add(this.LeftBorderA1Num);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.LeftBorderA1Label);
            this.groupBox2.Controls.Add(this.RightBorderA1Label);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.LeftBorderA2Label);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.RightBorderA2Label);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.StepLabel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(183, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 158);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Варьируемые Параметры";
            // 
            // StepNum
            // 
            this.StepNum.Location = new System.Drawing.Point(116, 125);
            this.StepNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.StepNum.Name = "StepNum";
            this.StepNum.Size = new System.Drawing.Size(88, 20);
            this.StepNum.TabIndex = 57;
            this.StepNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // RightBorderA2Num
            // 
            this.RightBorderA2Num.Location = new System.Drawing.Point(116, 99);
            this.RightBorderA2Num.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.RightBorderA2Num.Name = "RightBorderA2Num";
            this.RightBorderA2Num.Size = new System.Drawing.Size(88, 20);
            this.RightBorderA2Num.TabIndex = 56;
            this.RightBorderA2Num.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // LeftBorderA2Num
            // 
            this.LeftBorderA2Num.Location = new System.Drawing.Point(116, 73);
            this.LeftBorderA2Num.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.LeftBorderA2Num.Name = "LeftBorderA2Num";
            this.LeftBorderA2Num.Size = new System.Drawing.Size(88, 20);
            this.LeftBorderA2Num.TabIndex = 55;
            this.LeftBorderA2Num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // RightBorderA1Num
            // 
            this.RightBorderA1Num.Location = new System.Drawing.Point(116, 47);
            this.RightBorderA1Num.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.RightBorderA1Num.Name = "RightBorderA1Num";
            this.RightBorderA1Num.Size = new System.Drawing.Size(88, 20);
            this.RightBorderA1Num.TabIndex = 54;
            this.RightBorderA1Num.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // LeftBorderA1Num
            // 
            this.LeftBorderA1Num.Location = new System.Drawing.Point(116, 22);
            this.LeftBorderA1Num.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.LeftBorderA1Num.Name = "LeftBorderA1Num";
            this.LeftBorderA1Num.Size = new System.Drawing.Size(88, 20);
            this.LeftBorderA1Num.TabIndex = 53;
            this.LeftBorderA1Num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(214, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "м^3/ч";
            // 
            // AccuracyNum
            // 
            this.AccuracyNum.DecimalPlaces = 4;
            this.AccuracyNum.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.AccuracyNum.Location = new System.Drawing.Point(116, 71);
            this.AccuracyNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.AccuracyNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.AccuracyNum.Name = "AccuracyNum";
            this.AccuracyNum.Size = new System.Drawing.Size(88, 20);
            this.AccuracyNum.TabIndex = 56;
            this.AccuracyNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.CostPriceNum);
            this.groupBox3.Controls.Add(this.WorkShiftNum);
            this.groupBox3.Controls.Add(this.AccuracyNum);
            this.groupBox3.Controls.Add(this.WorkShift);
            this.groupBox3.Controls.Add(this.CostPrice);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.Accuracy);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(183, 221);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 104);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Константы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "м^3/ч";
            // 
            // CostPriceNum
            // 
            this.CostPriceNum.Location = new System.Drawing.Point(116, 45);
            this.CostPriceNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.CostPriceNum.Name = "CostPriceNum";
            this.CostPriceNum.Size = new System.Drawing.Size(88, 20);
            this.CostPriceNum.TabIndex = 55;
            this.CostPriceNum.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // WorkShiftNum
            // 
            this.WorkShiftNum.Location = new System.Drawing.Point(116, 19);
            this.WorkShiftNum.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.WorkShiftNum.Name = "WorkShiftNum";
            this.WorkShiftNum.Size = new System.Drawing.Size(88, 20);
            this.WorkShiftNum.TabIndex = 54;
            this.WorkShiftNum.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // CalculationButton
            // 
            this.CalculationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculationButton.Location = new System.Drawing.Point(235, 339);
            this.CalculationButton.Name = "CalculationButton";
            this.CalculationButton.Size = new System.Drawing.Size(122, 37);
            this.CalculationButton.TabIndex = 51;
            this.CalculationButton.Text = "Расчёт";
            this.CalculationButton.UseVisualStyleBackColor = true;
            this.CalculationButton.Click += new System.EventHandler(this.CalculationButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageResult);
            this.tabControl1.Controls.Add(this.tabPage2d);
            this.tabControl1.Controls.Add(this.tabPage3d);
            this.tabControl1.Location = new System.Drawing.Point(454, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(506, 364);
            this.tabControl1.TabIndex = 52;
            // 
            // tabPageResult
            // 
            this.tabPageResult.Controls.Add(this.labelDrawing);
            this.tabPageResult.Controls.Add(this.labelResult);
            this.tabPageResult.Location = new System.Drawing.Point(4, 22);
            this.tabPageResult.Name = "tabPageResult";
            this.tabPageResult.Size = new System.Drawing.Size(498, 338);
            this.tabPageResult.TabIndex = 2;
            this.tabPageResult.Text = "Результат";
            this.tabPageResult.UseVisualStyleBackColor = true;
            // 
            // labelDrawing
            // 
            this.labelDrawing.AutoSize = true;
            this.labelDrawing.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDrawing.Location = new System.Drawing.Point(18, 167);
            this.labelDrawing.Name = "labelDrawing";
            this.labelDrawing.Size = new System.Drawing.Size(0, 18);
            this.labelDrawing.TabIndex = 1;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(15, 23);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(304, 108);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "Минимальное значение целевой функции:\r\nОптимальное значение А1:\r\nОптимальное знач" +
    "ение А2:\r\n\r\nМинимальная себестоимость целевого\r\nпродукта за рабочую смену:";
            // 
            // tabPage2d
            // 
            this.tabPage2d.Controls.Add(this.elementHost1);
            this.tabPage2d.Location = new System.Drawing.Point(4, 22);
            this.tabPage2d.Name = "tabPage2d";
            this.tabPage2d.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2d.Size = new System.Drawing.Size(498, 338);
            this.tabPage2d.TabIndex = 0;
            this.tabPage2d.Text = "2D график";
            this.tabPage2d.UseVisualStyleBackColor = true;
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(0, 0);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(495, 338);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.userControl2D1;
            // 
            // tabPage3d
            // 
            this.tabPage3d.Controls.Add(this.elementHost2);
            this.tabPage3d.Location = new System.Drawing.Point(4, 22);
            this.tabPage3d.Name = "tabPage3d";
            this.tabPage3d.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3d.Size = new System.Drawing.Size(498, 338);
            this.tabPage3d.TabIndex = 1;
            this.tabPage3d.Text = "3D график";
            this.tabPage3d.UseVisualStyleBackColor = true;
            // 
            // elementHost2
            // 
            this.elementHost2.Location = new System.Drawing.Point(0, 0);
            this.elementHost2.Name = "elementHost2";
            this.elementHost2.Size = new System.Drawing.Size(498, 338);
            this.elementHost2.TabIndex = 0;
            this.elementHost2.Text = "elementHost2";
            this.elementHost2.Child = this.userControl3D1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "Целевая функция:";
            // 
            // radioBox
            // 
            this.radioBox.AutoSize = true;
            this.radioBox.Checked = true;
            this.radioBox.Location = new System.Drawing.Point(16, 335);
            this.radioBox.Name = "radioBox";
            this.radioBox.Size = new System.Drawing.Size(91, 17);
            this.radioBox.TabIndex = 54;
            this.radioBox.TabStop = true;
            this.radioBox.Text = "Метод Бокса";
            this.radioBox.UseVisualStyleBackColor = true;
            // 
            // radioHalfDiv
            // 
            this.radioHalfDiv.AutoSize = true;
            this.radioHalfDiv.Location = new System.Drawing.Point(16, 359);
            this.radioHalfDiv.Name = "radioHalfDiv";
            this.radioHalfDiv.Size = new System.Drawing.Size(170, 17);
            this.radioHalfDiv.TabIndex = 55;
            this.radioHalfDiv.Text = "Метод половинного деления";
            this.radioHalfDiv.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 388);
            this.Controls.Add(this.radioHalfDiv);
            this.Controls.Add(this.radioBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.CalculationButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.formula);
            this.Name = "UserForm";
            this.Text = "Пользовательский интерфейс";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.V2Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.V1Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mu1Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betta1Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bettaNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alpha1Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaNum)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StepNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBorderA2Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBorderA2Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBorderA1Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBorderA1Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccuracyNum)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CostPriceNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkShiftNum)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageResult.ResumeLayout(false);
            this.tabPageResult.PerformLayout();
            this.tabPage2d.ResumeLayout(false);
            this.tabPage3d.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label formula;
        private System.Windows.Forms.Label alphaLabel;
        private System.Windows.Forms.Label alpha1Label;
        private System.Windows.Forms.Label bettaLabel;
        private System.Windows.Forms.Label betta1Label;
        private System.Windows.Forms.Label muLabel;
        private System.Windows.Forms.Label mu1Label;
        private System.Windows.Forms.Label NLabel;
        private System.Windows.Forms.Label V2Label;
        private System.Windows.Forms.Label V1Label;
        private System.Windows.Forms.Label LeftBorderA1Label;
        private System.Windows.Forms.Label RightBorderA1Label;
        private System.Windows.Forms.Label LeftBorderA2Label;
        private System.Windows.Forms.Label RightBorderA2Label;
        private System.Windows.Forms.Label StepLabel;
        private System.Windows.Forms.Label WorkShift;
        private System.Windows.Forms.Label CostPrice;
        private System.Windows.Forms.Label Accuracy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button CalculationButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown alphaNum;
        private System.Windows.Forms.NumericUpDown V2Num;
        private System.Windows.Forms.NumericUpDown V1Num;
        private System.Windows.Forms.NumericUpDown NNum;
        private System.Windows.Forms.NumericUpDown mu1Num;
        private System.Windows.Forms.NumericUpDown muNum;
        private System.Windows.Forms.NumericUpDown betta1Num;
        private System.Windows.Forms.NumericUpDown bettaNum;
        private System.Windows.Forms.NumericUpDown alpha1Num;
        private System.Windows.Forms.NumericUpDown StepNum;
        private System.Windows.Forms.NumericUpDown RightBorderA2Num;
        private System.Windows.Forms.NumericUpDown LeftBorderA2Num;
        private System.Windows.Forms.NumericUpDown RightBorderA1Num;
        private System.Windows.Forms.NumericUpDown LeftBorderA1Num;
        private System.Windows.Forms.NumericUpDown AccuracyNum;
        private System.Windows.Forms.NumericUpDown CostPriceNum;
        private System.Windows.Forms.NumericUpDown WorkShiftNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2d;
        private System.Windows.Forms.TabPage tabPage3d;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private _2dWPF.UserControl2D userControl2D1;
        private System.Windows.Forms.Integration.ElementHost elementHost2;
        private _2dWPF.UserControl3D userControl3D1;
        private System.Windows.Forms.TabPage tabPageResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelDrawing;
        private System.Windows.Forms.RadioButton radioBox;
        private System.Windows.Forms.RadioButton radioHalfDiv;
    }
}