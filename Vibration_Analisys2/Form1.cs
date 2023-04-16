﻿using System;
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
        List<float> referenceFault = new List<float> ();

        /// <summary>
        /// List for second Fault values
        /// </summary>
        List<float> secondFault = new List<float>();

        string filenameExcel;
        BackgroundWorker worker = new BackgroundWorker();

        public MainForm() {
            InitializeComponent();
            // Centered Main From on the screen
            this.CenterToScreen();
            step2.Enabled = false;
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
                    worker.ProgressChanged += new ProgressChangedEventHandler(ProgressChanged);
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
        private void ProgressChanged(object sender, ProgressChangedEventArgs e) {
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
            (string, int) referenceFaultHeader = (referenceFaultBox.Text, referenceFaultBox.SelectedIndex + 1);
            (string, int) secondFaultHeader = (secondFaultBox.Text, secondFaultBox.SelectedIndex + 1);
            referenceFault.Clear();
            secondFault.Clear();

            try {
                for (int rowNumber = 1; rowNumber < dataGV.Rows.Count; rowNumber++) {
                    referenceFault.Add(Convert.ToSingle(dataGV[referenceFaultHeader.Item2, rowNumber].Value));
                    secondFault.Add(Convert.ToSingle(dataGV[secondFaultHeader.Item2, rowNumber].Value));
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
            if (e.KeyChar < 48 || e.KeyChar > 57) {
                e.Handled = true;
            }
        }
    }
}
