using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        List<WorkDay> workDays = new List<WorkDay>();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            var settingsWindow = new Form2();
            settingsWindow.Closed += settingsWindow_Closed; //delegate 
            settingsWindow.ShowDialog();
        }

        void settingsWindow_Closed(object sender, EventArgs e)
        {
            txtCurrentWage.Text = Wage.BasicWage.ToString();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            try
            {

                if (double.Parse(txtHoursInput.Text) < 0 || txtHoursInput.Text.GetType() is String)
                {
                    throw new ArgumentException("Illegal value. Hours must be a positive number.");
                }

                if (txtCurrentWage.Text == String.Empty)
                {
                    MessageBox.Show(@"Enter your wage via the setting window.");
                    return;
                }
                

                var workday = new WorkDay
                {
                    DateAndTime = dtpWork.Value,
                    Hours = double.Parse(txtHoursInput.Text)
                };

                foreach (var day in workDays)
                {
                    if (day.DateAndTime.Date == workday.DateAndTime.Date)
                    {
                        MessageBox.Show(@"Error: Cannot add the same day twice.");
                        return;
                    }
                }

                lsbData.Items.Add(workday);
                workDays.Add(workday);
                

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            if (workDays.Capacity == 0)
            {
                MessageBox.Show("No days to delete.");
                return;
            }
            foreach (var day in workDays)
            {
                if (day.DateAndTime == dtpWork.Value)
                {
                    lsbData.Items.Remove(day);
                    workDays.Remove(day);
                    txtDailyW.Text = WorkActions.CalculateDay(workDays, rdbPartTime, dtpWork.Value).ToString();
                    txtMonthW.Text = WorkActions.CalculateMonth(workDays, rdbPartTime, dtpWork.Value.Month,dtpWork.Value.Year).ToString();
                    MessageBox.Show(@"Success!");
                    return;
                }
            }

            MessageBox.Show(@"Failure. Day doesn't exist on the list.");
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (rdbPartTime.Checked is false && rdbFulltime.Checked is false)
            {
                MessageBox.Show("You must choose the job's frequency.");
                return;
            }

            txtDailyW.Text = WorkActions.CalculateDay(workDays, rdbPartTime, dtpWork.Value).ToString();
            txtMonthW.Text =  WorkActions.CalculateMonth(workDays, rdbPartTime,dtpWork.Value.Month,dtpWork.Value.Year).ToString();
            txtYearW.Text = WorkActions.CalculateYear(workDays, rdbPartTime, dtpWork.Value.Year).ToString();
        }

        private void btnADD_MouseHover(object sender, EventArgs e)
        {
            tlpAdd.Show("If you wish to edit a day, remove it first using the delete button.", btnADD );
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (lsbData.Items.Count == 0)
            {
                MessageBox.Show("No data to sort.");
                return;
            }
            object[] sortingArray = lsbData.Items.OfType<WorkDay>().ToArray();
            Array.Sort(sortingArray);
            lsbData.Items.Clear();
            lsbData.Items.AddRange(sortingArray);
        }

        private void dtpWork_Leave(object sender, EventArgs e)
        {
            try
            {
                if (lsbData.Items.Count == 0)
                {
                    throw new Exception("No data.");
                }
                
                txtDailyW.Text = WorkActions.CalculateDay(workDays, rdbPartTime, dtpWork.Value).ToString();
                txtMonthW.Text = WorkActions.CalculateMonth(workDays, rdbPartTime, dtpWork.Value.Month,dtpWork.Value.Year).ToString();
                txtYearW.Text = WorkActions.CalculateYear(workDays, rdbPartTime, dtpWork.Value.Year).ToString();
            }
            catch (Exception)
            {
                txtDailyW.Text = string.Empty;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (lsbData.Items.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }
            btnSort.PerformClick();
            if (rdbPartTime.Checked is false && rdbFulltime.Checked is false)
            {
                MessageBox.Show("Please choose your job's frequency.");
                return;
            }
            var form3sendList = lsbData.Items.Cast<Object>();
            Export exportWindow = new Export(form3sendList,rdbPartTime); 
            exportWindow.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
