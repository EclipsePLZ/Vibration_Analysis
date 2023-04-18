using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Vibration_Analisys2 {
    public partial class MainForm : Form {

        /// <summary>
        /// List for reference Fault values
        /// </summary>
        List<double> referenceFault = new List<double> ();
        List<double> selectIntervalRefFault = new List<double>();

        (string, int) referenceFaultHeader;

        /// <summary>
        /// List for second Fault values
        /// </summary>
        List<double> secondFault = new List<double>();
        List<double> selectIntervalSecFault = new List<double>();

        List<int> percentOfSecondFault = new List<int>();

        (string, int) secondFaultHeader;

        string filenameExcel;

        // BackgroundWorkers for each step
        BackgroundWorker workerStep1 = new BackgroundWorker();
        BackgroundWorker workerStep2 = new BackgroundWorker();
        BackgroundWorker workerStep3 = new BackgroundWorker();
        BackgroundWorker workerStep4 = new BackgroundWorker();

        /// <summary>
        /// Max value of signal for normal work for second fault
        /// </summary>
        double maxNormalVibraitonSignalLevel;


        public MainForm() {
            InitializeComponent();

            // Centered Main From on the screen
            this.CenterToScreen();

            // Locks all tabs except the first one
            foreach (TabPage tab in allSteps.TabPages){
                tab.Enabled = false;
            }
            step1.Enabled = true;
        }

        /// <summary>
        /// Open Excel File with Vibration Data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openExcelFile_Click(object sender, EventArgs e) {
            ClearControlsStep1();
            allSteps.SelectTab(step1);

            // Open xlsx file dialog
            using (OpenFileDialog ofd = new OpenFileDialog()) {
                ofd.Filter = "Excel Files Only | *.xlsx; *.xls";
                ofd.Title = "Choose the file";
                if (ofd.ShowDialog() == DialogResult.OK) {
                    filenameExcel = ofd.FileName;

                    // Run background worker for load data from excel file
                    workerStep1.ProgressChanged += new ProgressChangedEventHandler(ProgressExcelLoadChanged);
                    workerStep1.DoWork += new DoWorkEventHandler(LoadData);
                    workerStep1.WorkerReportsProgress = true;
                    dataGV.Size = new Size(682, 370);
                    progressBarDataLoad.Value = 0;
                    progressBarDataLoad.Visible = true;
                    workerStep1.RunWorkerAsync();
                }
            }
        }

        /// <summary>
        /// Function for clear controls from step1
        /// </summary>
        private void ClearControlsStep1() {
            dataGV.Rows.Clear();
            dataGV.Refresh();
            referenceFaultBox.Items.Clear();
            secondFaultBox.Items.Clear();
            ClearControlsStep2();
        }

        /// <summary>
        /// Function for clear controls from step2
        /// </summary>
        private void ClearControlsStep2() {
            numberOfValuesForNormalWorkLevel.Value = 1;
            numberOfStdForMaxLevel.Value = 1;
            meanValueForNormalWork.Text = "";
            stdValueForNormalWork.Text = "";
            faultSignal.Text = "";
            maxVibrationSignal.Text = "";
            dataSignalReliability.Rows.Clear();
            dataSignalReliability.Refresh();
            ClearControlsStep3();
        }

        /// <summary>
        /// Function for clear controls from step3
        /// </summary>
        private void ClearControlsStep3() {
            numericPieceOfRefFault.Value = 1;
            bestCorrelCoefTextBox.Text = "";
            bestIndexSecFaultTextBox.Text = "";
            dataGVbestIntervalsOfFault.Rows.Clear();
            dataGVbestIntervalsOfFault.Refresh();
            ClearControlsStep4();
        }

        /// <summary>
        /// Function for clear controls from step4
        /// </summary>
        private void ClearControlsStep4() {
            numberOfValuesInSelectedInterval.Text = "";
            numberOfValuesForPolynomes.Value = 1;
            dataGVBestPoly.Rows.Clear();
            dataGVBestPoly.Refresh();
        }

        /// <summary>
        /// Function for load data from excel file to DataGridView
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
                workerStep1.ReportProgress(progress);

                for (int row = 1; row <= range.Rows.Count; row++) {
                    // Find progress
                    if (row % step == 0) {
                        progress += oneBarInProgress;
                        workerStep1.ReportProgress(progress);
                    }

                    // Add values from excel sheet to dataGridView
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

            // Create a header lists
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
            workerStep1.DoWork -= new DoWorkEventHandler(LoadData);
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
                // Create second and reference fault lists
                for (int rowNumber = 1; rowNumber < dataGV.Rows.Count; rowNumber++) {
                    referenceFault.Add(Convert.ToDouble(dataGV[referenceFaultHeader.Item2, rowNumber].Value));
                    secondFault.Add(Convert.ToDouble(dataGV[secondFaultHeader.Item2, rowNumber].Value));
                }
                step2.Enabled = true;

                // Set maximum values for numeric up down
                numberOfValuesForNormalWorkLevel.Maximum = secondFault.Count;
                numberOfStdForMaxLevel.Maximum = decimal.MaxValue;

                allSteps.SelectTab(step2);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Check reference fault box rules
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void referenceFaultBox_SelectedIndexChanged(object sender, EventArgs e) {
            CheckAcceptButtonRule();
        }

        /// <summary>
        /// Check second fault box rules
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            e.Handled = CheckNumericIntValue(e);
        }

        /// <summary>
        /// Check if pressed numeric or backspace
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        private bool CheckNumericIntValue(KeyPressEventArgs e) {
            return (e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8;
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
            faultSignal.Text = secondFault.Max().ToString();
            maxVibrationSignal.Text = maxNormalVibraitonSignalLevel.ToString();

            getReliabilityForSecondSignal();
            numericPieceOfRefFault.Maximum = referenceFault.Count();
            step3.Enabled = true;
        }

        /// <summary>
        /// Calculation reliability with backgroung workerStep1
        /// </summary>
        private void getReliabilityForSecondSignal() {
            dataSignalReliability.ColumnCount = 2;
            dataSignalReliability.Rows.Add(secondFaultHeader.Item1, "Надежность");

            // Run background worker for load values and reliability of choosen faults into dataGridView
            workerStep2.ProgressChanged += new ProgressChangedEventHandler(ProgressReliabilityChanged);
            workerStep2.DoWork += new DoWorkEventHandler(getReliability);
            workerStep2.WorkerReportsProgress = true;
            dataSignalReliability.Size = new Size(341, 329);
            progressBarReliability.Value = 0;
            progressBarReliability.Visible = true;
            workerStep2.RunWorkerAsync();
        }


        /// <summary>
        /// Background workerStep1 for adding rows to DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void getReliability(object sender, DoWorkEventArgs e) {
            double maxSignalLevel = secondFault.Max();

            int numberOfDivisions = 0;

            double oneDivision = (maxSignalLevel - maxNormalVibraitonSignalLevel) / 99;

            int progress = 0;
            int step = secondFault.Count / 100;
            int oneBarInProgress = 1;
            if (secondFault.Count < 100) {
                step = 1;
                oneBarInProgress = (100 / secondFault.Count) + 1;
            }
            workerStep2.ReportProgress(progress);

            double prevBiggestSignal = maxNormalVibraitonSignalLevel;

            for (int i = 0; i < secondFault.Count; i++) {
                // Find progress
                if (i % step == 0) {
                    progress += oneBarInProgress;
                    workerStep2.ReportProgress(progress);
                }

                if (secondFault[i] > prevBiggestSignal) {
                    prevBiggestSignal = secondFault[i];
                    numberOfDivisions = (int)((secondFault[i] - (maxNormalVibraitonSignalLevel)) / oneDivision) + 1;
                }

                dataSignalReliability.Invoke(new Action<(double, int)>((s) => AddValuePercent(s)), (secondFault[i], numberOfDivisions));
            }

            progressBarReliability.Invoke(new Action<bool>((b) => progressBarReliability.Visible = b), false);

            dataSignalReliability.Invoke(new Action<Size>((size) => dataSignalReliability.Size = size), new Size(341, 353));
            workerStep2.DoWork -= new DoWorkEventHandler(getReliability);
        }

        /// <summary>
        /// Add row to dataGridView with percent of reliability
        /// </summary>
        /// <param name="values">value and percent of reliability</param>
        private void AddValuePercent((double, int) values) {
            int reliability = 100 - values.Item2;
            percentOfSecondFault.Add(reliability);
            dataSignalReliability.Rows.Add(values.Item1, reliability.ToString() + "%");
        }

        /// <summary>
        /// Change progress bar value for reliability bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProgressReliabilityChanged(object sender, ProgressChangedEventArgs e) {
            if (e.ProgressPercentage > 100) {
                progressBarReliability.Value = 100;
            }
            else {
                progressBarReliability.Value = e.ProgressPercentage;
            }
        }

        /// <summary>
        /// Get standard deviation
        /// </summary>
        /// <param name="values">List of values</param>
        /// <returns>Value of standard deviation</returns>
        private double StandardDeviation(IEnumerable<double> values) {
            double avg = values.Average();
            return Math.Sqrt(values.Average(v => Math.Pow(v - avg, 2)));
        }

        /// <summary>
        /// Find the most correlated sections of accidents
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void maxPearsonCoefTwoFaultsButton_Click(object sender, EventArgs e) {
            int numberOfValuesInFault = (int)numericPieceOfRefFault.Value;

            selectIntervalRefFault = new List<double>(referenceFault.GetRange(0, numberOfValuesInFault));
            double bestCorrCoef = 0;
            int bestStartIndexSecFault = 0;

            var application = new Microsoft.Office.Interop.Excel.Application();

            for (int i = 0; i < (secondFault.Count - numberOfValuesInFault); i++) {
                double corrCoef = CorrelCoef(selectIntervalRefFault, secondFault.GetRange(i, numberOfValuesInFault), application);
                if (Math.Abs(corrCoef) > Math.Abs(bestCorrCoef)) {
                    bestCorrCoef = corrCoef;
                    bestStartIndexSecFault = i;
                }
            }
            application.Quit();

            bestCorrelCoefTextBox.Text = bestCorrCoef.ToString();
            bestIndexSecFaultTextBox.Text = bestStartIndexSecFault.ToString();

            selectIntervalRefFault = new List<double>(referenceFault.GetRange(0, secondFault.Count - bestStartIndexSecFault));
            selectIntervalSecFault = new List<double>(secondFault.GetRange(bestStartIndexSecFault, secondFault.Count - bestStartIndexSecFault));

            WriteBestIntervalsIntoDataGridView();
            step4.Enabled = true;

            numberOfValuesInSelectedInterval.Text = selectIntervalSecFault.Count.ToString();
            numberOfValuesForPolynomes.Maximum = selectIntervalSecFault.Count;
        }

        /// <summary>
        /// Get correlation coefficient (Pearson coefficient)
        /// </summary>
        /// <param name="list1">First list of values</param>
        /// <param name="list2">Second list of values</param>
        /// <param name="app">Excel application</param>
        /// <returns>Value of Correlation coefficient</returns>
        private double CorrelCoef(IEnumerable<double> list1, IEnumerable<double> list2, Microsoft.Office.Interop.Excel.Application app) {
            return app.WorksheetFunction.Correl(list1.ToArray(), list2.ToArray());
        }

        /// <summary>
        /// Function for writing best intervals into data grid view with background worker
        /// </summary>
        private void WriteBestIntervalsIntoDataGridView() {
            dataGVbestIntervalsOfFault.ColumnCount = 2;
            dataGVbestIntervalsOfFault.Rows.Add(referenceFaultHeader.Item1, secondFaultHeader.Item1);

            // Run background worker for load best intervals of reference and second fault
            workerStep3.ProgressChanged += new ProgressChangedEventHandler(ProgressSelectIntervalChanged);
            workerStep3.DoWork += new DoWorkEventHandler(WriteBestIntervalsToDataGridAsync);
            workerStep3.WorkerReportsProgress = true;
            dataGVbestIntervalsOfFault.Size = new Size(341, 329);
            progressBarSelectedInterval.Value = 0;
            progressBarSelectedInterval.Visible = true;
            workerStep3.RunWorkerAsync();
        }

        /// <summary>
        /// Change progress bar value for select interval bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProgressSelectIntervalChanged(object sender, ProgressChangedEventArgs e) {
            if (e.ProgressPercentage > 100) {
                progressBarSelectedInterval.Value = 100;
            }
            else {
                progressBarSelectedInterval.Value = e.ProgressPercentage;
            }
        }

        /// <summary>
        /// Write value of selected intervals to dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WriteBestIntervalsToDataGridAsync(object sender, DoWorkEventArgs e) {
            int progress = 0;
            int step = selectIntervalRefFault.Count / 100;
            int oneBarInProgress = 1;
            if (selectIntervalRefFault.Count < 100) {
                step = 1;
                oneBarInProgress = (100 / selectIntervalRefFault.Count) + 1;
            }
            workerStep3.ReportProgress(progress);

            for (int i = 0; i < selectIntervalRefFault.Count; i++) {
                // Find progress
                if (i % step == 0) {
                    progress += oneBarInProgress;
                    workerStep3.ReportProgress(progress);
                }

                (double, double) newRow = (selectIntervalRefFault[i], selectIntervalSecFault[i]);
                dataGVbestIntervalsOfFault.Invoke(new Action<(double, double)>((values) => WriteRowOfBestInterval(values)), newRow);
            }

            progressBarSelectedInterval.Invoke(new Action<bool>((b) => progressBarSelectedInterval.Visible = b), false);
            dataGVbestIntervalsOfFault.Invoke(new Action<Size>((size) => dataGVbestIntervalsOfFault.Size = size), new Size(341, 353));

            workerStep3.DoWork -= new DoWorkEventHandler(WriteBestIntervalsToDataGridAsync);
        }

        /// <summary>
        /// Write new row of best intervals to dataDV
        /// </summary>
        /// <param name="values">Tuple of two elements: reference fault and second fault</param>
        private void WriteRowOfBestInterval((double, double) values) {
            dataGVbestIntervalsOfFault.Rows.Add(values.Item1, values.Item2);
        }

        private void FindPolynomButton_Click(object sender, EventArgs e) {
            dataGVBestPoly.ColumnCount = 3;
            dataGVBestPoly.Rows.Add("Степень полинома", "Коэффициент детерминации", "Уравнение");

            // Run background worker for finding polynom coeffs
            workerStep4.ProgressChanged += ProgressFindBestPolyChanged;
            workerStep4.DoWork += FindBestPolynom;
            workerStep4.WorkerReportsProgress = true;
            dataGVBestPoly.Size = new Size(553, 405);
            progressBestPoly.Value = 0;
            progressBestPoly.Visible = true;
            workerStep4.RunWorkerAsync();
            // Доделать 4 шаг

            //int numberValuesForPolynom = (int)numberOfValuesForPolynomes.Value;
            //int polynomialDegree = 1;
            //selectIntervalRefFault = new List<double>(selectIntervalRefFault.GetRange(0, numberValuesForPolynom));
            //selectIntervalSecFault = new List<double>(selectIntervalSecFault.GetRange(0, numberValuesForPolynom));
            //List<double> Y = new List<double>(selectIntervalSecFault);
            //List<List<double>> Z = new List<List<double>>();

            //Z.Add(OnesList(numberValuesForPolynom));

            //for (int i = 1; i <= 15; i++) {
            //    Z.Add(PowList(selectIntervalRefFault, i));
            //}
        }

        private void FindBestPolynom(object sender, DoWorkEventArgs e) {
            //dataGVbestIntervalsOfFault.ColumnCount = 2;
            //dataGVbestIntervalsOfFault.Rows.Add(referenceFaultHeader.Item1, secondFaultHeader.Item1);

            //// Run background worker for load best intervals of reference and second fault
            //workerStep3.ProgressChanged += new ProgressChangedEventHandler(ProgressSelectIntervalChanged);
            //workerStep3.DoWork += new DoWorkEventHandler(WriteBestIntervalsToDataGridAsync);
            //workerStep3.WorkerReportsProgress = true;
            //dataGVbestIntervalsOfFault.Size = new Size(341, 329);
            //progressBarSelectedInterval.Value = 0;
            //progressBarSelectedInterval.Visible = true;
            //workerStep3.RunWorkerAsync();
        }

        /// <summary>
        /// Change progress bar value for select interval bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProgressFindBestPolyChanged(object sender, ProgressChangedEventArgs e) {
            if (e.ProgressPercentage > 100) {
                progressBestPoly.Value = 100;
            }
            else {
                progressBestPoly.Value = e.ProgressPercentage;
            }
        }

        /// <summary>
        /// Function that returns list of ones
        /// </summary>
        /// <param name="n">List size</param>
        /// <returns>List of ones</returns>
        private List<double> OnesList(int n) {
            List<double> ones = new List<double>();
            for (int i = 0; i < n; i++) {
                ones.Add(1.0);
            }
            return ones;
        }

        /// <summary>
        /// Function that pow list of numbers
        /// </summary>
        /// <param name="numList">List of numbers</param>
        /// <param name="m">Pow value</param>
        /// <returns>Pow list</returns>
        private List<double> PowList(List<double> numList, int m) {
            List<double> powList = new List<double>();
            foreach (double elem in numList) {
                powList.Add(Math.Pow(elem, m));
            }
            return powList;
        }
    }
}
