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
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.stepControl.SuspendLayout();
            this.step1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.step1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.step1.Size = new System.Drawing.Size(879, 406);
            this.step1.TabIndex = 0;
            this.step1.Text = "Шаг 1";
            this.step1.UseVisualStyleBackColor = true;
            // 
            // progressBarDataLoad
            // 
            this.progressBarDataLoad.Location = new System.Drawing.Point(6, 380);
            this.progressBarDataLoad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.step2.Location = new System.Drawing.Point(4, 22);
            this.step2.Name = "step2";
            this.step2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.step2.Size = new System.Drawing.Size(879, 406);
            this.step2.TabIndex = 1;
            this.step2.Text = "Шаг 2";
            this.step2.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
    }
}

