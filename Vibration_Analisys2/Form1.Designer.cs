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
            this.stepControl = new System.Windows.Forms.TabControl();
            this.step1 = new System.Windows.Forms.TabPage();
            this.progressBarDataLoad = new System.Windows.Forms.ProgressBar();
            this.acceptFaultsButton = new System.Windows.Forms.Button();
            this.step2 = new System.Windows.Forms.TabPage();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.numberOfValuesForNormalWorkLevel = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numberOfStdForMaxLevel = new System.Windows.Forms.NumericUpDown();
            this.meanValueForNormalWork = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.stdValueForNormalWork = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.maxVibrationSignal = new System.Windows.Forms.TextBox();
            this.calcReliabilitySignal = new System.Windows.Forms.Button();
            this.dataSignalReliability = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.stepControl.SuspendLayout();
            this.step1.SuspendLayout();
            this.step2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfValuesForNormalWorkLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfStdForMaxLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSignalReliability)).BeginInit();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(898, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openExcelFile});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // openExcelFile
            // 
            this.openExcelFile.Name = "openExcelFile";
            this.openExcelFile.Size = new System.Drawing.Size(121, 22);
            this.openExcelFile.Text = "Открыть";
            this.openExcelFile.Click += new System.EventHandler(this.openExcelFile_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(54, 20);
            this.ExitButton.Text = "Выход";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // dataGV
            // 
            this.dataGV.AllowUserToAddRows = false;
            this.dataGV.AllowUserToDeleteRows = false;
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Location = new System.Drawing.Point(6, 5);
            this.dataGV.Name = "dataGV";
            this.dataGV.ReadOnly = true;
            this.dataGV.RowHeadersWidth = 51;
            this.dataGV.Size = new System.Drawing.Size(682, 395);
            this.dataGV.TabIndex = 1;
            // 
            // referenceFaultBox
            // 
            this.referenceFaultBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.referenceFaultBox.FormattingEnabled = true;
            this.referenceFaultBox.Location = new System.Drawing.Point(712, 35);
            this.referenceFaultBox.Name = "referenceFaultBox";
            this.referenceFaultBox.Size = new System.Drawing.Size(150, 21);
            this.referenceFaultBox.TabIndex = 2;
            this.referenceFaultBox.SelectedIndexChanged += new System.EventHandler(this.referenceFaultBox_SelectedIndexChanged);
            // 
            // secondFaultBox
            // 
            this.secondFaultBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.secondFaultBox.FormattingEnabled = true;
            this.secondFaultBox.Location = new System.Drawing.Point(712, 172);
            this.secondFaultBox.Name = "secondFaultBox";
            this.secondFaultBox.Size = new System.Drawing.Size(150, 21);
            this.secondFaultBox.TabIndex = 3;
            this.secondFaultBox.SelectedIndexChanged += new System.EventHandler(this.secondFaultBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(709, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Эталонная авария";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(709, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Вторая авария";
            // 
            // stepControl
            // 
            this.stepControl.Controls.Add(this.step1);
            this.stepControl.Controls.Add(this.step2);
            this.stepControl.Location = new System.Drawing.Point(12, 27);
            this.stepControl.Name = "stepControl";
            this.stepControl.SelectedIndex = 0;
            this.stepControl.Size = new System.Drawing.Size(887, 432);
            this.stepControl.TabIndex = 6;
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
            this.step1.Location = new System.Drawing.Point(4, 22);
            this.step1.Name = "step1";
            this.step1.Padding = new System.Windows.Forms.Padding(3);
            this.step1.Size = new System.Drawing.Size(879, 406);
            this.step1.TabIndex = 0;
            this.step1.Text = "Шаг 1";
            this.step1.UseVisualStyleBackColor = true;
            // 
            // progressBarDataLoad
            // 
            this.progressBarDataLoad.Location = new System.Drawing.Point(6, 380);
            this.progressBarDataLoad.Margin = new System.Windows.Forms.Padding(2);
            this.progressBarDataLoad.Name = "progressBarDataLoad";
            this.progressBarDataLoad.Size = new System.Drawing.Size(682, 19);
            this.progressBarDataLoad.TabIndex = 7;
            this.progressBarDataLoad.Visible = false;
            // 
            // acceptFaultsButton
            // 
            this.acceptFaultsButton.Enabled = false;
            this.acceptFaultsButton.Location = new System.Drawing.Point(739, 290);
            this.acceptFaultsButton.Name = "acceptFaultsButton";
            this.acceptFaultsButton.Size = new System.Drawing.Size(102, 40);
            this.acceptFaultsButton.TabIndex = 6;
            this.acceptFaultsButton.Text = "Подтвердить";
            this.acceptFaultsButton.UseVisualStyleBackColor = true;
            this.acceptFaultsButton.Click += new System.EventHandler(this.acceptFaultsButton_Click);
            // 
            // step2
            // 
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
            this.step2.Location = new System.Drawing.Point(4, 22);
            this.step2.Name = "step2";
            this.step2.Padding = new System.Windows.Forms.Padding(3);
            this.step2.Size = new System.Drawing.Size(879, 406);
            this.step2.TabIndex = 1;
            this.step2.Text = "Шаг 2";
            this.step2.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество наблюдений для\r\nподсчета уровня нормальной работы:";
            // 
            // numberOfValuesForNormalWorkLevel
            // 
            this.numberOfValuesForNormalWorkLevel.Location = new System.Drawing.Point(286, 34);
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
            this.numberOfValuesForNormalWorkLevel.Size = new System.Drawing.Size(120, 20);
            this.numberOfValuesForNormalWorkLevel.TabIndex = 3;
            this.numberOfValuesForNormalWorkLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfValuesForNormalWorkLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOfValuesForNormalWorkLevel_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Количество стандартных отклонения для\r\nподсчета максимального допустимого уровня:" +
    "";
            // 
            // numberOfStdForMaxLevel
            // 
            this.numberOfStdForMaxLevel.DecimalPlaces = 1;
            this.numberOfStdForMaxLevel.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numberOfStdForMaxLevel.Location = new System.Drawing.Point(286, 100);
            this.numberOfStdForMaxLevel.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfStdForMaxLevel.Name = "numberOfStdForMaxLevel";
            this.numberOfStdForMaxLevel.Size = new System.Drawing.Size(120, 20);
            this.numberOfStdForMaxLevel.TabIndex = 5;
            this.numberOfStdForMaxLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // meanValueForNormalWork
            // 
            this.meanValueForNormalWork.Location = new System.Drawing.Point(171, 182);
            this.meanValueForNormalWork.Name = "meanValueForNormalWork";
            this.meanValueForNormalWork.ReadOnly = true;
            this.meanValueForNormalWork.Size = new System.Drawing.Size(100, 20);
            this.meanValueForNormalWork.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Среднее значение:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Стандартное отклонение:";
            // 
            // stdValueForNormalWork
            // 
            this.stdValueForNormalWork.Location = new System.Drawing.Point(171, 218);
            this.stdValueForNormalWork.Name = "stdValueForNormalWork";
            this.stdValueForNormalWork.ReadOnly = true;
            this.stdValueForNormalWork.Size = new System.Drawing.Size(100, 20);
            this.stdValueForNormalWork.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 26);
            this.label7.TabIndex = 10;
            this.label7.Text = "Максимальный возможный\r\nвибросигнал нормальной работы:";
            // 
            // maxVibrationSignal
            // 
            this.maxVibrationSignal.Location = new System.Drawing.Point(214, 280);
            this.maxVibrationSignal.Name = "maxVibrationSignal";
            this.maxVibrationSignal.ReadOnly = true;
            this.maxVibrationSignal.Size = new System.Drawing.Size(100, 20);
            this.maxVibrationSignal.TabIndex = 11;
            // 
            // calcReliabilitySignal
            // 
            this.calcReliabilitySignal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calcReliabilitySignal.Location = new System.Drawing.Point(116, 337);
            this.calcReliabilitySignal.Name = "calcReliabilitySignal";
            this.calcReliabilitySignal.Size = new System.Drawing.Size(111, 44);
            this.calcReliabilitySignal.TabIndex = 12;
            this.calcReliabilitySignal.Text = "Рассчитать";
            this.calcReliabilitySignal.UseVisualStyleBackColor = true;
            // 
            // dataSignalReliability
            // 
            this.dataSignalReliability.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSignalReliability.Location = new System.Drawing.Point(493, 28);
            this.dataSignalReliability.Name = "dataSignalReliability";
            this.dataSignalReliability.Size = new System.Drawing.Size(341, 353);
            this.dataSignalReliability.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 457);
            this.Controls.Add(this.stepControl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(914, 496);
            this.MinimumSize = new System.Drawing.Size(914, 496);
            this.Name = "MainForm";
            this.Text = "Анализ Вибросигнала";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.stepControl.ResumeLayout(false);
            this.step1.ResumeLayout(false);
            this.step1.PerformLayout();
            this.step2.ResumeLayout(false);
            this.step2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfValuesForNormalWorkLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfStdForMaxLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSignalReliability)).EndInit();
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
        private System.Windows.Forms.TabControl stepControl;
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
    }
}

