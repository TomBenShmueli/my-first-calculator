using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp5
{
    public partial class Export : Form 
    {
        //variables

        private readonly List<object> lsbfromsource = new List<object>();

        private readonly RadioButton rdbIsPart = new RadioButton();

        private List<RadioButton> rdblist = new List<RadioButton>();
       
        //functions
        public Export(IEnumerable<object> lsbsource,RadioButton formRdbPart)
        {
            InitializeComponent();
            lsbfromsource.AddRange(lsbsource);
            if (formRdbPart.Checked)
                rdbIsPart.Checked = true;
            rdblist.Add(rdbDay); rdblist.Add(rdbMonth); rdblist.Add(rdbYear);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExText_Click(object sender, EventArgs e)
        {
            ExportInfo(btnExText, rdbDay, rdbMonth, 0);
        }

        private void btnExExcel_Click(object sender, EventArgs e)
        {
            ExportInfo(btnExExcel,rdbDay,rdbMonth,dsgExport.RowCount);
        }

        //Exports the info to sender object in the form of a table. 
        public void ExportInfo(object sender, RadioButton rdbDay, RadioButton rdbMonth,int rowcount)
        {
            if (MarkedStatus(rdblist) is false)
            {
                MessageBox.Show("Select export scope in order to continue.");
                return;
            }

            if (sender == btnExText) // txt file export.
              {
                    if (rdbDay.Checked) // Export for daily wage.
                    {
                        try
                        {
                            var toworkdays = lsbfromsource.Cast<WorkDay>();
                            var filterDay = toworkdays.First(d => d.DateAndTime.Date == dtpExportInfo.Value.Date); //get fitting days
                            using (var savefd = new SaveFileDialog())
                            {
                                savefd.Filter = @"Text files (*.txt)|*.txt";
                                savefd.DefaultExt = "txt";
                                savefd.AddExtension = true;
                                savefd.ShowDialog();

                                var path = savefd.FileName;
                                var lsbDataStreamWriter = new StreamWriter(path, false);
                                    lsbDataStreamWriter.WriteLine(filterDay + $" Wage earned: {WorkActions.LocalCalculate(filterDay, rdbIsPart)}");
                                        MessageBox.Show("File saved successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                lsbDataStreamWriter.Close();
                                return;
                            }

                        }
                        catch (ArgumentException)
                        {

                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                    }
                    else if (rdbMonth.Checked) // Export for monthly wage.
                    {
                        try
                        {
                            var toworkdays = lsbfromsource.Cast<WorkDay>();
                            var filteredList = toworkdays.Where(d => d.DateAndTime.Month == dtpExportInfo.Value.Month && d.DateAndTime.Year == dtpExportInfo.Value.Year);  //get fitting days
                            using (var savefd = new SaveFileDialog())
                            {
                                savefd.Filter = @"Text files (*.txt)|*.txt";
                                savefd.DefaultExt = "txt";
                                savefd.AddExtension = true;
                                savefd.ShowDialog();

                                var path = savefd.FileName;
                                var lsbDataStreamWriter = new StreamWriter(path, false);
                                foreach (var item in filteredList)
                                {
                                    lsbDataStreamWriter.WriteLine((WorkDay)item + $" Wage earned: {WorkActions.LocalCalculate(item as WorkDay, rdbIsPart)}");
                                    MessageBox.Show("File saved successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                lsbDataStreamWriter.Close();
                                return;
                            }

                        }
                        catch (ArgumentException)
                        {

                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                    }
                    else // Export for yearly wage.
                    {
                        try
                        {
                            var toworkdays = lsbfromsource.Cast<WorkDay>();
                            var filteredList = toworkdays.Where(d => d.DateAndTime.Year == dtpExportInfo.Value.Year);  //get fitting days
                            using (var savefd = new SaveFileDialog())  
                            {
                                savefd.Filter = @"Text files (*.txt)|*.txt"; 
                                savefd.DefaultExt = "txt";
                                savefd.AddExtension = true;
                                savefd.ShowDialog();

                                var path = savefd.FileName;
                                var lsbDataStreamWriter = new StreamWriter(path, false);
                                foreach (var item in filteredList)
                                {
                                    lsbDataStreamWriter.WriteLine((WorkDay)item + $" Wage earned: {WorkActions.LocalCalculate(item as WorkDay, rdbIsPart)}");
                                    MessageBox.Show("File saved successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                lsbDataStreamWriter.Close();
                                return;
                            }
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                    }
              }

            #region excelExport
            try 
            {
                if (rdbDay.Checked)
                {
                    var toworkdaysD = lsbfromsource.Cast<WorkDay>();
                    List<WorkDay> filterDay = new List<WorkDay>();
                    filterDay.Add(toworkdaysD.First(d => d.DateAndTime.Date == dtpExportInfo.Value.Date));
                    ExcelExport(filterDay,rowcount);
                    return;
                }
                if (rdbMonth.Checked)
                {
                    var toworkdaysM = lsbfromsource.Cast<WorkDay>();
                    var filteredListM = toworkdaysM.Where(d =>
                        d.DateAndTime.Month == dtpExportInfo.Value.Month &&
                        d.DateAndTime.Year == dtpExportInfo.Value.Year).ToList();
                    ExcelExport(filteredListM,rowcount);
                    return;

                }
                var toworkdaysY = lsbfromsource.Cast<WorkDay>();
                var filteredListY = toworkdaysY.Where(d =>  d.DateAndTime.Year == dtpExportInfo.Value.Year).ToList();
                ExcelExport(filteredListY,rowcount);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            #endregion


        }

        public bool MarkedStatus(List<RadioButton> rdblist)
        {
            foreach (var radioButton in rdblist)
            {
                if (radioButton.Checked)
                    return true;
            }
            return false;
        }

        private void Export_Load(object sender, EventArgs e) // Previews the wage data in a table.
        {
            dsgExport.ColumnCount = 4;
            dsgExport.ColumnHeadersVisible = true;
            dsgExport.Columns[0].HeaderText = "Entry number";
            dsgExport.Columns[1].HeaderText = "Date";
            dsgExport.Columns[2].HeaderText = "Hours";
            dsgExport.Columns[3].HeaderText = "Money earned";

            for (int i = 0; i < lsbfromsource.Count; i++)
            {
                dsgExport.Rows.Add();
                dsgExport.Rows[i].Cells[0].Value = i+1;
                dsgExport.Rows[i].Cells[1].Value = lsbfromsource.OfType<WorkDay>().ToArray()[i].DateAndTime.ToShortDateString();
                dsgExport.Rows[i].Cells[2].Value = lsbfromsource.OfType<WorkDay>().ToArray()[i].Hours;
                dsgExport.Rows[i].Cells[3].Value = WorkActions.LocalCalculate(lsbfromsource.OfType<WorkDay>().ToArray()[i], rdbIsPart);
            }

            dsgExport.ReadOnly = true;
        }

        private void ExcelExport(List<WorkDay> workDaysList, int rowcount) // Exports the data table to excel.
        {
            var xlfile = new Microsoft.Office.Interop.Excel.Application { Visible = false };

            //Get a new workbook.
            var oWb = (Microsoft.Office.Interop.Excel._Workbook)(xlfile.Workbooks.Add(Missing.Value));
            var oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWb.ActiveSheet;

            //Add table headers going cell by cell.

            oSheet.Cells[1, 1] = "EntryNumber";
            oSheet.Cells[1, 2] = "Date";
            oSheet.Cells[1, 3] = "Hours";
            oSheet.Cells[1, 4] = "Earned";

            for (int i = 0; i < rowcount - 1; i++) //Data from list to excel
            {

                oSheet.Cells[i + 2, 1] = i + 1;
                oSheet.Cells[i + 2, 2] = workDaysList[i].DateAndTime.ToShortDateString();
                oSheet.Cells[i + 2, 3] = workDaysList[i].Hours;
                oSheet.Cells[i + 2, 4] = WorkActions.LocalCalculate(workDaysList[i], rdbIsPart);
            }

            using (var savefd = new SaveFileDialog()) // for custom saving
            {
                savefd.Filter = @"Microsoft Excel(*.xlsx)|*xlsx|Microsoft Excel 97-2003 Worksheet(*.xls)|*.xls|Excel macro-enabled workbook(*.xlsm)|*xlsm;";
                savefd.DefaultExt = "xlsx";
                savefd.AddExtension = true;
                savefd.ShowDialog();
                var path = savefd.FileName;
                oWb.SaveAs(path);
                if (path == String.Empty)
                {
                    return;
                }
            }
            oWb.Close();
            Marshal.ReleaseComObject(oWb);
            Marshal.ReleaseComObject(oSheet);
            Marshal.ReleaseComObject(xlfile);
            MessageBox.Show("Success!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
