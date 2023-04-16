using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vibration_Analisys2 {
    public partial class ExitForm : Form {
        public ExitForm() {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void ExitButton2_Click(object sender, EventArgs e) {
            System.Windows.Forms.Application.Exit();
        }

        private void CancelExitButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
