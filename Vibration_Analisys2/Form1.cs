using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Vibration_Analisys2 {
    public partial class MainForm : Form {

        /// <summary>
        /// List for reference Fault values
        /// </summary>
        List<double> referenceFault = new List<double> ();

        (string, int) referenceFaultHeader;

        /// <summary>
        /// List for second Fault values
        /// </summary>
        List<double> secondFault = new List<double>();

        (string, int) secondFaultHeader;

        string filenameExcel;
        BackgroundWorker worker = new BackgroundWorker();

        /// <summary>
        /// Max value of signal for normal work for second fault
        /// </summary>
        double maxNormalVibraitonSignalLevel;


        public MainForm() {
            InitializeComponent();
            // Centered Main From on the screen
            this.CenterToScreen();
            step2.Enabled = false;
            numberOfStdForMaxLevel.Maximum = decimal.MaxValue;
        }

        /// <summary>
        /// Open Excel File with Vibration Data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openExcelFile_Click(object sender, EventArgs e) {
           
            using (OpenFileDialog ofd = new OpenFileDialog()) {
                ofd.Filter = "Excel Files Only | *.xlsx; *.xls";
                ofd.Title = "Choose the file";
                if (ofd.ShowDialog() == DialogResult.OK) {
                    filenameExcel = ofd.FileName;
                    worker.ProgressChanged += new ProgressChangedEventHandler(ProgressExcelLoadChanged);
                    worker.DoWork += new DoWorkEventHandler(LoadData);
                    worker.WorkerReportsProgress = true;
                    dataGV.Size = new Size(682, 370);
                    progressBarDataLoad.Visible = true;
                    worker.RunWorkerAsync();
                }
            }
        }

        /// <summary>
        /// Load data from excel file to DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadData(object sender, DoWorkEventArgs e) {
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = xlapp.Workbooks.Open(filenameExcel);
            Microsoft.Office.Interop.Excel.Worksheet sheet;
            Microsoft.Office.Interop.Excel.Range range;
            try {
                sheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.ActiveSheet;
                range = sheet.UsedRange;

                dataGV.Invoke(new Action<int>((n) => dataGV.ColumnCount = n), range.Columns.Count);
                int progress = 0;
                int step = range.Rows.Count / 100;
                int oneBarInProgress = 1;
                if (range.Rows.Count < 100) {
                    step = 1;
                    oneBarInProgress = (100 / range.Rows.Count) + 1;
                }
                worker.ReportProgress(progress);

                for (int row = 1; row <= range.Rows.Count; row++) {
                    if (row % step == 0) {
                        progress += oneBarInProgress;
                        worker.ReportProgress(progress);
                    }
                    List<string> rowValues = new List<string>();
                    for (int col = 1; col <= range.Columns.Count; col++) {
                        rowValues.Add(range.Cells[row, col].Text);
                    }
                    dataGV.Invoke(new Action<List<string>>((s) => AddRowFunc(s)), rowValues);
                }
                workbook.Close();
                xlapp.Quit();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                workbook.Close();
                xlapp.Quit();
                return;
            }
            List<string> headerList = new List<string>();
            for (int i = 1; i < dataGV.ColumnCount; i++) {
                headerList.Add(dataGV.Rows[0].Cells[i].Value.ToString());
            }
            referenceFaultBox.Invoke(new Action<List<string>>((s) => AddHeadersInReferenceFaultBox(s)), headerList);
            secondFaultBox.Invoke(new Action<List<string>>((s) => AddHeadersInSecondFaultBox(s)), headerList);
            referenceFaultBox.Invoke(new Action<int>((n) => referenceFaultBox.SelectedIndex = n), 0);
            secondFaultBox.Invoke(new Action<int>((n) => secondFaultBox.SelectedIndex = n), 1);

            progressBarDataLoad.Invoke(new Action<bool>((b) => progressBarDataLoad.Visible = b), false);

            dataGV.Invoke(new Action<Size>((size) => dataGV.Size = size), new Size(682, 395));
        }

        /// <summary>
        /// Change progress bar value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProgressExcelLoadChanged(object sender, ProgressChangedEventArgs e) {
            if (e.ProgressPercentage > 100) {
                progressBarDataLoad.Value = 100;
            }
            else {
                progressBarDataLoad.Value = e.ProgressPercentage;
            }
        }

        /// <summary>
        /// Add values to reference fault comboBox
        /// </summary>
        /// <param name="headers">List of headers</param>
        private void AddHeadersInReferenceFaultBox(List<string> headers) {
            referenceFaultBox.Items.AddRange(headers.ToArray());
        }

        /// <summary>
        /// Add values to second fault comboBox
        /// </summary>
        /// <param name="headers">List of headers</param>
        private void AddHeadersInSecondFaultBox(List<string> headers) {
            secondFaultBox.Items.AddRange(headers.ToArray());
        }

        /// <summary>
        /// Add row to dataGridView
        /// </summary>
        /// <param name="nums">List of values</param>
        private void AddRowFunc(List<string> nums) {
            dataGV.Rows.Add(nums.ToArray());
        }

        /// <summary>
        /// Select reference fault and second fault
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void acceptFaultsButton_Click(object sender, EventArgs e) {
            referenceFaultHeader = (referenceFaultBox.Text, referenceFaultBox.SelectedIndex + 1);
            secondFaultHeader = (secondFaultBox.Text, secondFaultBox.SelectedIndex + 1);
            referenceFault.Clear();
            secondFault.Clear();

            try {
                for (int rowNumber = 1; rowNumber < dataGV.Rows.Count; rowNumber++) {
                    referenceFault.Add((double)dataGV[referenceFaultHeader.Item2, rowNumber].Value);
                    secondFault.Add((double)dataGV[secondFaultHeader.Item2, rowNumber].Value);
                }
                step2.Enabled = true;

                numberOfValuesForNormalWorkLevel.Maximum = secondFault.Count;
                stepControl.SelectTab(step2);
                
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void referenceFaultBox_SelectedIndexChanged(object sender, EventArgs e) {
            CheckAcceptButtonRule();
        }

        private void secondFaultBox_SelectedIndexChanged(object sender, EventArgs e) {
            CheckAcceptButtonRule();
        }

        /// <summary>
        /// Check rules for accepting fault button
        /// </summary>
        private void CheckAcceptButtonRule() {
            if (IsFaultBoxesAcceptable()) {
                acceptFaultsButton.Enabled = true;
            }
            else {
                acceptFaultsButton.Enabled = false;
            }
        }

        /// <summary>
        /// Rule for fault box acceptable
        /// </summary>
        /// <returns></returns>
        private bool IsFaultBoxesAcceptable() {
            return (referenceFaultBox.Text != secondFaultBox.Text) && 
                (referenceFaultBox.Text != "") && (secondFaultBox.Text != "");
        }

        /// <summary>
        /// Exit application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e) {
            var exitForm = new ExitForm();
            exitForm.Show();
        }

        /// <summary>
        /// For validate value in Text box (only int numbers)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numberOfValuesForNormalWorkLevel_KeyPress(object sender, KeyPressEventArgs e) {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8) {
                e.Handled = true;
            }
        }


        /// <summary>
        /// Calculation reliability for second fault signal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calcReliabilitySignal_Click(object sender, EventArgs e) {
            int intervalSize = ((int)numberOfValuesForNormalWorkLevel.Value);
            double stdCount = ((double)numberOfStdForMaxLevel.Value);
            double meanValueForInterval = secondFault.GetRange(0, intervalSize).Average();
            double stdValueForInterval = StandardDeviation(secondFault.GetRange(0, intervalSize));
            maxNormalVibraitonSignalLevel = meanValueForInterval + (double)stdCount * stdValueForInterval;

            meanValueForNormalWork.Text = meanValueForInterval.ToString();
            stdValueForNormalWork.Text = stdValueForInterval.ToString();

            getReliabilityForSecondSignal();
        }

        private void getReliabilityForSecondSignal() {
            dataSignalReliability.ColumnCount = 2;
            dataSignalReliability[0, 0].Value = secondFaultHeader.Item1;
            dataSignalReliability[1, 0].Value = "Надежность";

            worker.ProgressChanged += new ProgressChangedEventHandler(ProgressReliabilityChanged);
            worker.DoWork += new DoWorkEventHandler(getReliability);
            worker.WorkerReportsProgress = true;
            dataSignalReliability.Size = new Size(341, 329);
            progressBarReliability.Visible = true;
            worker.RunWorkerAsync();
        }

        private void getReliability(object sender, DoWorkEventArgs e) {
            double maxSignalLevel = secondFault.Max();
            int numberOfDivisions = 0;

            double oneDivision = (maxSignalLevel - maxNormalVibraitonSignalLevel) / 99;

            for (int i = 0; i < secondFault.Count; i++) {
                if (secondFault[i] > maxNormalVibraitonSignalLevel + (numberOfDivisions * oneDivision)) {
                    numberOfDivisions++;
                }
                // Установка значения в DataGridView (вибрация, процент)
            }
        }

        private void ProgressReliabilityChanged(object sender, ProgressChangedEventArgs e) {
            if (e.ProgressPercentage > 100) {
                progressBarReliability.Value = 100;
            }
            else {
                progressBarReliability.Value = e.ProgressPercentage;
            }
        }

        /// <summary>
        /// Standard deviation
        /// </summary>
        /// <param name="values">List of values</param>
        /// <returns>Value of standard deviation</returns>
        private double StandardDeviation(IEnumerable<double> values) {
            double avg = values.Average();
            return Math.Sqrt(values.Average(v => Math.Pow(v - avg, 2)));
        }
    }
}
