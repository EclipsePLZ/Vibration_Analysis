namespace Vibration_Analisys2 {
    partial class ExitForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExitForm));
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton2 = new System.Windows.Forms.Button();
            this.CancelExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(39, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вы уверены, что хотите выйти?";
            // 
            // ExitButton2
            // 
            this.ExitButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton2.Location = new System.Drawing.Point(75, 109);
            this.ExitButton2.Name = "ExitButton2";
            this.ExitButton2.Size = new System.Drawing.Size(124, 41);
            this.ExitButton2.TabIndex = 1;
            this.ExitButton2.Text = "Выйти";
            this.ExitButton2.UseVisualStyleBackColor = true;
            this.ExitButton2.Click += new System.EventHandler(this.ExitButton2_Click);
            // 
            // CancelExitButton
            // 
            this.CancelExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelExitButton.Location = new System.Drawing.Point(269, 109);
            this.CancelExitButton.Name = "CancelExitButton";
            this.CancelExitButton.Size = new System.Drawing.Size(124, 41);
            this.CancelExitButton.TabIndex = 2;
            this.CancelExitButton.Text = "Отмена";
            this.CancelExitButton.UseVisualStyleBackColor = true;
            this.CancelExitButton.Click += new System.EventHandler(this.CancelExitButton_Click);
            // 
            // ExitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 203);
            this.Controls.Add(this.CancelExitButton);
            this.Controls.Add(this.ExitButton2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(509, 250);
            this.MinimumSize = new System.Drawing.Size(509, 250);
            this.Name = "ExitForm";
            this.Text = "ExitForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton2;
        private System.Windows.Forms.Button CancelExitButton;
    }
}