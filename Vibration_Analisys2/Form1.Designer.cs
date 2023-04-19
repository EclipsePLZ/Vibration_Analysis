namespace Vibration_Analisys2 {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openExcelFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.referenceFaultBox = new System.Windows.Forms.ComboBox();
            this.secondFaultBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.allSteps = new System.Windows.Forms.TabControl();
            this.step1 = new System.Windows.Forms.TabPage();
            this.progressBarDataLoad = new System.Windows.Forms.ProgressBar();
            this.acceptFaultsButton = new System.Windows.Forms.Button();
            this.step2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.faultSignal = new System.Windows.Forms.TextBox();
            this.progressBarReliability = new System.Windows.Forms.ProgressBar();
            this.dataSignalReliability = new System.Windows.Forms.DataGridView();
            this.calcReliabilitySignal = new System.Windows.Forms.Button();
            this.maxVibrationSignal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.stdValueForNormalWork = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.meanValueForNormalWork = new System.Windows.Forms.TextBox();
            this.numberOfStdForMaxLevel = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numberOfValuesForNormalWorkLevel = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.step3 = new System.Windows.Forms.TabPage();
            this.progressBarSelectedInterval = new System.Windows.Forms.ProgressBar();
            this.dataGVbestIntervalsOfFault = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.bestIndexSecFaultTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bestCorrelCoefTextBox = new System.Windows.Forms.TextBox();
            this.numericPieceOfRefFault = new System.Windows.Forms.NumericUpDown();
            this.maxPearsonCoefTwoFaultsButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.step4 = new System.Windows.Forms.TabPage();
            this.FindPolynomButton = new System.Windows.Forms.Button();
            this.numberOfValuesForPolynomes = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numberOfValuesInSelectedInterval = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.progressBestPoly = new System.Windows.Forms.ProgressBar();
            this.dataGVBestPoly = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.allSteps.SuspendLayout();
            this.step1.SuspendLayout();
            this.step2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSignalReliability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfStdForMaxLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfValuesForNormalWorkLevel)).BeginInit();
            this.step3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVbestIntervalsOfFault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPieceOfRefFault)).BeginInit();
            this.step4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfValuesForPolynomes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVBestPoly)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.ExitButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1195, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openExcelFile});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // openExcelFile
            // 
            this.openExcelFile.Name = "openExcelFile";
            this.openExcelFile.Size = new System.Drawing.Size(150, 26);
            this.openExcelFile.Text = "Открыть";
            this.openExcelFile.Click += new System.EventHandler(this.openExcelFile_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(67, 24);
            this.ExitButton.Text = "Выход";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // dataGV
            // 
            this.dataGV.AllowUserToAddRows = false;
            this.dataGV.AllowUserToDeleteRows = false;
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Location = new System.Drawing.Point(8, 6);
            this.dataGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGV.Name = "dataGV";
            this.dataGV.ReadOnly = true;
            this.dataGV.RowHeadersWidth = 51;
            this.dataGV.Size = new System.Drawing.Size(909, 486);
            this.dataGV.TabIndex = 1;
            // 
            // referenceFaultBox
            // 
            this.referenceFaultBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.referenceFaultBox.FormattingEnabled = true;
            this.referenceFaultBox.Location = new System.Drawing.Point(949, 43);
            this.referenceFaultBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.referenceFaultBox.Name = "referenceFaultBox";
            this.referenceFaultBox.Size = new System.Drawing.Size(199, 24);
            this.referenceFaultBox.TabIndex = 2;
            this.referenceFaultBox.SelectedIndexChanged += new System.EventHandler(this.referenceFaultBox_SelectedIndexChanged);
            // 
            // secondFaultBox
            // 
            this.secondFaultBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.secondFaultBox.FormattingEnabled = true;
            this.secondFaultBox.Location = new System.Drawing.Point(949, 212);
            this.secondFaultBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.secondFaultBox.Name = "secondFaultBox";
            this.secondFaultBox.Size = new System.Drawing.Size(199, 24);
            this.secondFaultBox.TabIndex = 3;
            this.secondFaultBox.SelectedIndexChanged += new System.EventHandler(this.secondFaultBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(945, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Эталонная авария";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(945, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Вторая авария";
            // 
            // allSteps
            // 
            this.allSteps.Controls.Add(this.step1);
            this.allSteps.Controls.Add(this.step2);
            this.allSteps.Controls.Add(this.step3);
            this.allSteps.Controls.Add(this.step4);
            this.allSteps.Location = new System.Drawing.Point(16, 33);
            this.allSteps.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.allSteps.Name = "allSteps";
            this.allSteps.SelectedIndex = 0;
            this.allSteps.Size = new System.Drawing.Size(1183, 532);
            this.allSteps.TabIndex = 6;
            // 
            // step1
            // 
            this.step1.Controls.Add(this.progressBarDataLoad);
            this.step1.Controls.Add(this.acceptFaultsButton);
            this.step1.Controls.Add(this.secondFaultBox);
            this.step1.Controls.Add(this.dataGV);
            this.step1.Controls.Add(this.label1);
            this.step1.Controls.Add(this.label2);
            this.step1.Controls.Add(this.referenceFaultBox);
            this.step1.Location = new System.Drawing.Point(4, 25);
            this.step1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.step1.Name = "step1";
            this.step1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.step1.Size = new System.Drawing.Size(1175, 503);
            this.step1.TabIndex = 0;
            this.step1.Text = "Шаг 1";
            this.step1.UseVisualStyleBackColor = true;
            // 
            // progressBarDataLoad
            // 
            this.progressBarDataLoad.Location = new System.Drawing.Point(8, 468);
            this.progressBarDataLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarDataLoad.Name = "progressBarDataLoad";
            this.progressBarDataLoad.Size = new System.Drawing.Size(909, 23);
            this.progressBarDataLoad.TabIndex = 7;
            this.progressBarDataLoad.Visible = false;
            // 
            // acceptFaultsButton
            // 
            this.acceptFaultsButton.Enabled = false;
            this.acceptFaultsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acceptFaultsButton.Location = new System.Drawing.Point(975, 357);
            this.acceptFaultsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.acceptFaultsButton.Name = "acceptFaultsButton";
            this.acceptFaultsButton.Size = new System.Drawing.Size(147, 59);
            this.acceptFaultsButton.TabIndex = 6;
            this.acceptFaultsButton.Text = "Подтвердить";
            this.acceptFaultsButton.UseVisualStyleBackColor = true;
            this.acceptFaultsButton.Click += new System.EventHandler(this.acceptFaultsButton_Click);
            // 
            // step2
            // 
            this.step2.Controls.Add(this.label8);
            this.step2.Controls.Add(this.faultSignal);
            this.step2.Controls.Add(this.progressBarReliability);
            this.step2.Controls.Add(this.dataSignalReliability);
            this.step2.Controls.Add(this.calcReliabilitySignal);
            this.step2.Controls.Add(this.maxVibrationSignal);
            this.step2.Controls.Add(this.label7);
            this.step2.Controls.Add(this.label6);
            this.step2.Controls.Add(this.stdValueForNormalWork);
            this.step2.Controls.Add(this.label5);
            this.step2.Controls.Add(this.meanValueForNormalWork);
            this.step2.Controls.Add(this.numberOfStdForMaxLevel);
            this.step2.Controls.Add(this.label4);
            this.step2.Controls.Add(this.numberOfValuesForNormalWorkLevel);
            this.step2.Controls.Add(this.label3);
            this.step2.Location = new System.Drawing.Point(4, 25);
            this.step2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.step2.Name = "step2";
            this.step2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.step2.Size = new System.Drawing.Size(1175, 503);
            this.step2.TabIndex = 1;
            this.step2.Text = "Шаг 2";
            this.step2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 278);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 32);
            this.label8.TabIndex = 16;
            this.label8.Text = "Максимальное значение\r\nсигнала:";
            // 
            // faultSignal
            // 
            this.faultSignal.Location = new System.Drawing.Point(232, 286);
            this.faultSignal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.faultSignal.Name = "faultSignal";
            this.faultSignal.ReadOnly = true;
            this.faultSignal.Size = new System.Drawing.Size(132, 22);
            this.faultSignal.TabIndex = 15;
            // 
            // progressBarReliability
            // 
            this.progressBarReliability.Location = new System.Drawing.Point(657, 446);
            this.progressBarReliability.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarReliability.Name = "progressBarReliability";
            this.progressBarReliability.Size = new System.Drawing.Size(455, 23);
            this.progressBarReliability.TabIndex = 14;
            this.progressBarReliability.Visible = false;
            // 
            // dataSignalReliability
            // 
            this.dataSignalReliability.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSignalReliability.Location = new System.Drawing.Point(657, 34);
            this.dataSignalReliability.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataSignalReliability.Name = "dataSignalReliability";
            this.dataSignalReliability.ReadOnly = true;
            this.dataSignalReliability.RowHeadersWidth = 51;
            this.dataSignalReliability.Size = new System.Drawing.Size(455, 434);
            this.dataSignalReliability.TabIndex = 13;
            // 
            // calcReliabilitySignal
            // 
            this.calcReliabilitySignal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calcReliabilitySignal.Location = new System.Drawing.Point(155, 415);
            this.calcReliabilitySignal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calcReliabilitySignal.Name = "calcReliabilitySignal";
            this.calcReliabilitySignal.Size = new System.Drawing.Size(148, 54);
            this.calcReliabilitySignal.TabIndex = 12;
            this.calcReliabilitySignal.Text = "Рассчитать";
            this.calcReliabilitySignal.UseVisualStyleBackColor = true;
            this.calcReliabilitySignal.Click += new System.EventHandler(this.calcReliabilitySignal_Click);
            // 
            // maxVibrationSignal
            // 
            this.maxVibrationSignal.Location = new System.Drawing.Point(285, 358);
            this.maxVibrationSignal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maxVibrationSignal.Name = "maxVibrationSignal";
            this.maxVibrationSignal.ReadOnly = true;
            this.maxVibrationSignal.Size = new System.Drawing.Size(132, 22);
            this.maxVibrationSignal.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 351);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 32);
            this.label7.TabIndex = 10;
            this.label7.Text = "Максимальный возможный\r\nвибросигнал нормальной работы:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 238);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Стандартное отклонение:";
            // 
            // stdValueForNormalWork
            // 
            this.stdValueForNormalWork.Location = new System.Drawing.Point(232, 234);
            this.stdValueForNormalWork.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stdValueForNormalWork.Name = "stdValueForNormalWork";
            this.stdValueForNormalWork.ReadOnly = true;
            this.stdValueForNormalWork.Size = new System.Drawing.Size(132, 22);
            this.stdValueForNormalWork.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 193);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Среднее значение:";
            // 
            // meanValueForNormalWork
            // 
            this.meanValueForNormalWork.Location = new System.Drawing.Point(232, 190);
            this.meanValueForNormalWork.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.meanValueForNormalWork.Name = "meanValueForNormalWork";
            this.meanValueForNormalWork.ReadOnly = true;
            this.meanValueForNormalWork.Size = new System.Drawing.Size(132, 22);
            this.meanValueForNormalWork.TabIndex = 6;
            // 
            // numberOfStdForMaxLevel
            // 
            this.numberOfStdForMaxLevel.DecimalPlaces = 1;
            this.numberOfStdForMaxLevel.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numberOfStdForMaxLevel.Location = new System.Drawing.Point(381, 123);
            this.numberOfStdForMaxLevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numberOfStdForMaxLevel.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfStdForMaxLevel.Name = "numberOfStdForMaxLevel";
            this.numberOfStdForMaxLevel.Size = new System.Drawing.Size(160, 22);
            this.numberOfStdForMaxLevel.TabIndex = 5;
            this.numberOfStdForMaxLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(314, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Количество стандартных отклонения для\r\nподсчета максимального допустимого уровня:" +
    "";
            // 
            // numberOfValuesForNormalWorkLevel
            // 
            this.numberOfValuesForNormalWorkLevel.Location = new System.Drawing.Point(381, 42);
            this.numberOfValuesForNormalWorkLevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numberOfValuesForNormalWorkLevel.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfValuesForNormalWorkLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfValuesForNormalWorkLevel.Name = "numberOfValuesForNormalWorkLevel";
            this.numberOfValuesForNormalWorkLevel.Size = new System.Drawing.Size(160, 22);
            this.numberOfValuesForNormalWorkLevel.TabIndex = 3;
            this.numberOfValuesForNormalWorkLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfValuesForNormalWorkLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOfValuesForNormalWorkLevel_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество наблюдений для\r\nподсчета уровня нормальной работы:";
            // 
            // step3
            // 
            this.step3.Controls.Add(this.progressBarSelectedInterval);
            this.step3.Controls.Add(this.dataGVbestIntervalsOfFault);
            this.step3.Controls.Add(this.label11);
            this.step3.Controls.Add(this.bestIndexSecFaultTextBox);
            this.step3.Controls.Add(this.label10);
            this.step3.Controls.Add(this.bestCorrelCoefTextBox);
            this.step3.Controls.Add(this.numericPieceOfRefFault);
            this.step3.Controls.Add(this.maxPearsonCoefTwoFaultsButton);
            this.step3.Controls.Add(this.label9);
            this.step3.Location = new System.Drawing.Point(4, 25);
            this.step3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.step3.Name = "step3";
            this.step3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.step3.Size = new System.Drawing.Size(1175, 503);
            this.step3.TabIndex = 2;
            this.step3.Text = "Шаг 3";
            this.step3.UseVisualStyleBackColor = true;
            // 
            // progressBarSelectedInterval
            // 
            this.progressBarSelectedInterval.Location = new System.Drawing.Point(648, 434);
            this.progressBarSelectedInterval.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarSelectedInterval.Name = "progressBarSelectedInterval";
            this.progressBarSelectedInterval.Size = new System.Drawing.Size(455, 23);
            this.progressBarSelectedInterval.TabIndex = 16;
            this.progressBarSelectedInterval.Visible = false;
            // 
            // dataGVbestIntervalsOfFault
            // 
            this.dataGVbestIntervalsOfFault.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVbestIntervalsOfFault.Location = new System.Drawing.Point(648, 23);
            this.dataGVbestIntervalsOfFault.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGVbestIntervalsOfFault.Name = "dataGVbestIntervalsOfFault";
            this.dataGVbestIntervalsOfFault.ReadOnly = true;
            this.dataGVbestIntervalsOfFault.RowHeadersWidth = 51;
            this.dataGVbestIntervalsOfFault.Size = new System.Drawing.Size(455, 434);
            this.dataGVbestIntervalsOfFault.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(73, 239);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(259, 32);
            this.label11.TabIndex = 11;
            this.label11.Text = "Значение индекса, с которого \r\nбудем рассматривать вторую аварию:";
            // 
            // bestIndexSecFaultTextBox
            // 
            this.bestIndexSecFaultTextBox.Location = new System.Drawing.Point(363, 246);
            this.bestIndexSecFaultTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bestIndexSecFaultTextBox.Name = "bestIndexSecFaultTextBox";
            this.bestIndexSecFaultTextBox.ReadOnly = true;
            this.bestIndexSecFaultTextBox.Size = new System.Drawing.Size(132, 22);
            this.bestIndexSecFaultTextBox.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(73, 162);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(272, 32);
            this.label10.TabIndex = 9;
            this.label10.Text = "Максимальное значение \r\nкоэффициента корреляции (по модулю):";
            // 
            // bestCorrelCoefTextBox
            // 
            this.bestCorrelCoefTextBox.Location = new System.Drawing.Point(363, 170);
            this.bestCorrelCoefTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bestCorrelCoefTextBox.Name = "bestCorrelCoefTextBox";
            this.bestCorrelCoefTextBox.ReadOnly = true;
            this.bestCorrelCoefTextBox.Size = new System.Drawing.Size(132, 22);
            this.bestCorrelCoefTextBox.TabIndex = 8;
            // 
            // numericPieceOfRefFault
            // 
            this.numericPieceOfRefFault.Location = new System.Drawing.Point(336, 54);
            this.numericPieceOfRefFault.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericPieceOfRefFault.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericPieceOfRefFault.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericPieceOfRefFault.Name = "numericPieceOfRefFault";
            this.numericPieceOfRefFault.Size = new System.Drawing.Size(160, 22);
            this.numericPieceOfRefFault.TabIndex = 4;
            this.numericPieceOfRefFault.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericPieceOfRefFault.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOfValuesForNormalWorkLevel_KeyPress);
            // 
            // maxPearsonCoefTwoFaultsButton
            // 
            this.maxPearsonCoefTwoFaultsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxPearsonCoefTwoFaultsButton.Location = new System.Drawing.Point(217, 362);
            this.maxPearsonCoefTwoFaultsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maxPearsonCoefTwoFaultsButton.Name = "maxPearsonCoefTwoFaultsButton";
            this.maxPearsonCoefTwoFaultsButton.Size = new System.Drawing.Size(209, 73);
            this.maxPearsonCoefTwoFaultsButton.TabIndex = 2;
            this.maxPearsonCoefTwoFaultsButton.Text = "Вычислить корреляцию между авариями";
            this.maxPearsonCoefTwoFaultsButton.UseVisualStyleBackColor = true;
            this.maxPearsonCoefTwoFaultsButton.Click += new System.EventHandler(this.maxPearsonCoefTwoFaultsButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(73, 57);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(244, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Размер куска из эталонной аварии:";
            // 
            // step4
            // 
            this.step4.Controls.Add(this.progressBestPoly);
            this.step4.Controls.Add(this.dataGVBestPoly);
            this.step4.Controls.Add(this.FindPolynomButton);
            this.step4.Controls.Add(this.numberOfValuesForPolynomes);
            this.step4.Controls.Add(this.label13);
            this.step4.Controls.Add(this.label12);
            this.step4.Controls.Add(this.numberOfValuesInSelectedInterval);
            this.step4.Location = new System.Drawing.Point(4, 25);
            this.step4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.step4.Name = "step4";
            this.step4.Size = new System.Drawing.Size(1175, 503);
            this.step4.TabIndex = 3;
            this.step4.Text = "Шаг 4";
            this.step4.UseVisualStyleBackColor = true;
            // 
            // FindPolynomButton
            // 
            this.FindPolynomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindPolynomButton.Location = new System.Drawing.Point(127, 333);
            this.FindPolynomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FindPolynomButton.Name = "FindPolynomButton";
            this.FindPolynomButton.Size = new System.Drawing.Size(205, 73);
            this.FindPolynomButton.TabIndex = 14;
            this.FindPolynomButton.Text = "Найти коэффициенты полинома";
            this.FindPolynomButton.UseVisualStyleBackColor = true;
            this.FindPolynomButton.Click += new System.EventHandler(this.FindPolynomButton_Click);
            // 
            // numberOfValuesForPolynomes
            // 
            this.numberOfValuesForPolynomes.Location = new System.Drawing.Point(275, 135);
            this.numberOfValuesForPolynomes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numberOfValuesForPolynomes.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfValuesForPolynomes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfValuesForPolynomes.Name = "numberOfValuesForPolynomes";
            this.numberOfValuesForPolynomes.Size = new System.Drawing.Size(160, 22);
            this.numberOfValuesForPolynomes.TabIndex = 13;
            this.numberOfValuesForPolynomes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfValuesForPolynomes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOfValuesForNormalWorkLevel_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(69, 127);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(189, 32);
            this.label13.TabIndex = 12;
            this.label13.Text = "Количество наблюдений\r\nдля постраения полиномов:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(69, 55);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 32);
            this.label12.TabIndex = 11;
            this.label12.Text = "Количество значений в\r\nвыбранных авариях:";
            // 
            // numberOfValuesInSelectedInterval
            // 
            this.numberOfValuesInSelectedInterval.Location = new System.Drawing.Point(275, 62);
            this.numberOfValuesInSelectedInterval.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numberOfValuesInSelectedInterval.Name = "numberOfValuesInSelectedInterval";
            this.numberOfValuesInSelectedInterval.ReadOnly = true;
            this.numberOfValuesInSelectedInterval.Size = new System.Drawing.Size(132, 22);
            this.numberOfValuesInSelectedInterval.TabIndex = 10;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // progressBestPoly
            // 
            this.progressBestPoly.Location = new System.Drawing.Point(582, 441);
            this.progressBestPoly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBestPoly.Name = "progressBestPoly";
            this.progressBestPoly.Size = new System.Drawing.Size(553, 25);
            this.progressBestPoly.TabIndex = 18;
            this.progressBestPoly.Visible = false;
            // 
            // dataGVBestPoly
            // 
            this.dataGVBestPoly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVBestPoly.Location = new System.Drawing.Point(582, 30);
            this.dataGVBestPoly.Margin = new System.Windows.Forms.Padding(4);
            this.dataGVBestPoly.Name = "dataGVBestPoly";
            this.dataGVBestPoly.ReadOnly = true;
            this.dataGVBestPoly.RowHeadersWidth = 51;
            this.dataGVBestPoly.Size = new System.Drawing.Size(553, 436);
            this.dataGVBestPoly.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 553);
            this.Controls.Add(this.allSteps);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1213, 600);
            this.MinimumSize = new System.Drawing.Size(1213, 600);
            this.Name = "MainForm";
            this.Text = "Анализ Вибросигнала";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.allSteps.ResumeLayout(false);
            this.step1.ResumeLayout(false);
            this.step1.PerformLayout();
            this.step2.ResumeLayout(false);
            this.step2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSignalReliability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfStdForMaxLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfValuesForNormalWorkLevel)).EndInit();
            this.step3.ResumeLayout(false);
            this.step3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVbestIntervalsOfFault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPieceOfRefFault)).EndInit();
            this.step4.ResumeLayout(false);
            this.step4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfValuesForPolynomes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVBestPoly)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openExcelFile;
        private System.Windows.Forms.ToolStripMenuItem ExitButton;
        private System.Windows.Forms.DataGridView dataGV;
        private System.Windows.Forms.ComboBox referenceFaultBox;
        private System.Windows.Forms.ComboBox secondFaultBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl allSteps;
        private System.Windows.Forms.TabPage step1;
        private System.Windows.Forms.Button acceptFaultsButton;
        private System.Windows.Forms.TabPage step2;
        private System.Windows.Forms.ProgressBar progressBarDataLoad;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numberOfValuesForNormalWorkLevel;
        private System.Windows.Forms.TextBox maxVibrationSignal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox stdValueForNormalWork;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox meanValueForNormalWork;
        private System.Windows.Forms.NumericUpDown numberOfStdForMaxLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calcReliabilitySignal;
        private System.Windows.Forms.DataGridView dataSignalReliability;
        private System.Windows.Forms.ProgressBar progressBarReliability;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox faultSignal;
        private System.Windows.Forms.TabPage step3;
        private System.Windows.Forms.Button maxPearsonCoefTwoFaultsButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericPieceOfRefFault;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox bestCorrelCoefTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox bestIndexSecFaultTextBox;
        private System.Windows.Forms.ProgressBar progressBarSelectedInterval;
        private System.Windows.Forms.DataGridView dataGVbestIntervalsOfFault;
        private System.Windows.Forms.TabPage step4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox numberOfValuesInSelectedInterval;
        private System.Windows.Forms.NumericUpDown numberOfValuesForPolynomes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button FindPolynomButton;
        private System.Windows.Forms.ProgressBar progressBestPoly;
        private System.Windows.Forms.DataGridView dataGVBestPoly;
    }
}

