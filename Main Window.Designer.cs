namespace WindowsFormsApp5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblHourlyWage = new System.Windows.Forms.Label();
            this.txtCurrentWage = new System.Windows.Forms.TextBox();
            this.dtpWork = new System.Windows.Forms.DateTimePicker();
            this.lblMonthW = new System.Windows.Forms.Label();
            this.txtMonthW = new System.Windows.Forms.TextBox();
            this.lblDailyW = new System.Windows.Forms.Label();
            this.txtDailyW = new System.Windows.Forms.TextBox();
            this.lblHoursInput = new System.Windows.Forms.Label();
            this.txtHoursInput = new System.Windows.Forms.TextBox();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnDEL = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.rdbPartTime = new System.Windows.Forms.RadioButton();
            this.rdbFulltime = new System.Windows.Forms.RadioButton();
            this.lsbData = new System.Windows.Forms.ListBox();
            this.tlpAdd = new System.Windows.Forms.ToolTip(this.components);
            this.btnSort = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblYearW = new System.Windows.Forms.Label();
            this.txtYearW = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(11, 356);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(87, 57);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(104, 356);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(87, 57);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblHourlyWage
            // 
            this.lblHourlyWage.AutoSize = true;
            this.lblHourlyWage.Location = new System.Drawing.Point(13, 15);
            this.lblHourlyWage.Name = "lblHourlyWage";
            this.lblHourlyWage.Size = new System.Drawing.Size(90, 17);
            this.lblHourlyWage.TabIndex = 8;
            this.lblHourlyWage.Text = "Hourly Wage";
            // 
            // txtCurrentWage
            // 
            this.txtCurrentWage.Enabled = false;
            this.txtCurrentWage.Location = new System.Drawing.Point(118, 12);
            this.txtCurrentWage.Name = "txtCurrentWage";
            this.txtCurrentWage.Size = new System.Drawing.Size(100, 22);
            this.txtCurrentWage.TabIndex = 7;
            // 
            // dtpWork
            // 
            this.dtpWork.Location = new System.Drawing.Point(16, 40);
            this.dtpWork.Name = "dtpWork";
            this.dtpWork.Size = new System.Drawing.Size(200, 22);
            this.dtpWork.TabIndex = 11;
            this.dtpWork.Leave += new System.EventHandler(this.dtpWork_Leave);
            // 
            // lblMonthW
            // 
            this.lblMonthW.AutoSize = true;
            this.lblMonthW.Location = new System.Drawing.Point(13, 238);
            this.lblMonthW.Name = "lblMonthW";
            this.lblMonthW.Size = new System.Drawing.Size(98, 17);
            this.lblMonthW.TabIndex = 15;
            this.lblMonthW.Text = "Monthly Wage";
            // 
            // txtMonthW
            // 
            this.txtMonthW.Enabled = false;
            this.txtMonthW.Location = new System.Drawing.Point(118, 235);
            this.txtMonthW.Name = "txtMonthW";
            this.txtMonthW.Size = new System.Drawing.Size(100, 22);
            this.txtMonthW.TabIndex = 14;
            // 
            // lblDailyW
            // 
            this.lblDailyW.AutoSize = true;
            this.lblDailyW.Location = new System.Drawing.Point(13, 210);
            this.lblDailyW.Name = "lblDailyW";
            this.lblDailyW.Size = new System.Drawing.Size(80, 17);
            this.lblDailyW.TabIndex = 13;
            this.lblDailyW.Text = "Daily Wage";
            // 
            // txtDailyW
            // 
            this.txtDailyW.Enabled = false;
            this.txtDailyW.Location = new System.Drawing.Point(118, 207);
            this.txtDailyW.Name = "txtDailyW";
            this.txtDailyW.Size = new System.Drawing.Size(100, 22);
            this.txtDailyW.TabIndex = 12;
            // 
            // lblHoursInput
            // 
            this.lblHoursInput.AutoSize = true;
            this.lblHoursInput.Location = new System.Drawing.Point(13, 71);
            this.lblHoursInput.Name = "lblHoursInput";
            this.lblHoursInput.Size = new System.Drawing.Size(54, 17);
            this.lblHoursInput.TabIndex = 17;
            this.lblHoursInput.Text = "Hours?";
            // 
            // txtHoursInput
            // 
            this.txtHoursInput.Location = new System.Drawing.Point(75, 68);
            this.txtHoursInput.Name = "txtHoursInput";
            this.txtHoursInput.Size = new System.Drawing.Size(100, 22);
            this.txtHoursInput.TabIndex = 16;
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(12, 97);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(71, 23);
            this.btnADD.TabIndex = 18;
            this.btnADD.Text = "Add!";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            this.btnADD.MouseHover += new System.EventHandler(this.btnADD_MouseHover);
            // 
            // btnDEL
            // 
            this.btnDEL.Location = new System.Drawing.Point(104, 97);
            this.btnDEL.Name = "btnDEL";
            this.btnDEL.Size = new System.Drawing.Size(71, 23);
            this.btnDEL.TabIndex = 19;
            this.btnDEL.Text = "Delete!";
            this.btnDEL.UseVisualStyleBackColor = true;
            this.btnDEL.Click += new System.EventHandler(this.btnDEL_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(75, 293);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 20;
            this.btnCalc.Text = "Calc!";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // rdbPartTime
            // 
            this.rdbPartTime.AutoSize = true;
            this.rdbPartTime.Location = new System.Drawing.Point(12, 138);
            this.rdbPartTime.Name = "rdbPartTime";
            this.rdbPartTime.Size = new System.Drawing.Size(117, 21);
            this.rdbPartTime.TabIndex = 21;
            this.rdbPartTime.TabStop = true;
            this.rdbPartTime.Text = "Part Time Job";
            this.rdbPartTime.UseVisualStyleBackColor = true;
            // 
            // rdbFulltime
            // 
            this.rdbFulltime.AutoSize = true;
            this.rdbFulltime.Location = new System.Drawing.Point(12, 165);
            this.rdbFulltime.Name = "rdbFulltime";
            this.rdbFulltime.Size = new System.Drawing.Size(215, 21);
            this.rdbFulltime.TabIndex = 22;
            this.rdbFulltime.TabStop = true;
            this.rdbFulltime.Text = "Full Time Job (42 hrs a week)";
            this.rdbFulltime.UseVisualStyleBackColor = true;
            // 
            // lsbData
            // 
            this.lsbData.FormattingEnabled = true;
            this.lsbData.ItemHeight = 16;
            this.lsbData.Location = new System.Drawing.Point(249, 23);
            this.lsbData.Name = "lsbData";
            this.lsbData.Size = new System.Drawing.Size(531, 404);
            this.lsbData.TabIndex = 23;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(104, 419);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(87, 57);
            this.btnSort.TabIndex = 24;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(11, 419);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 57);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblYearW
            // 
            this.lblYearW.AutoSize = true;
            this.lblYearW.Location = new System.Drawing.Point(13, 266);
            this.lblYearW.Name = "lblYearW";
            this.lblYearW.Size = new System.Drawing.Size(89, 17);
            this.lblYearW.TabIndex = 27;
            this.lblYearW.Text = "Yearly Wage";
            // 
            // txtYearW
            // 
            this.txtYearW.Enabled = false;
            this.txtYearW.Location = new System.Drawing.Point(118, 263);
            this.txtYearW.Name = "txtYearW";
            this.txtYearW.Size = new System.Drawing.Size(100, 22);
            this.txtYearW.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 486);
            this.Controls.Add(this.lblYearW);
            this.Controls.Add(this.txtYearW);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lsbData);
            this.Controls.Add(this.rdbFulltime);
            this.Controls.Add(this.rdbPartTime);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnDEL);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.lblHoursInput);
            this.Controls.Add(this.txtHoursInput);
            this.Controls.Add(this.lblMonthW);
            this.Controls.Add(this.txtMonthW);
            this.Controls.Add(this.lblDailyW);
            this.Controls.Add(this.txtDailyW);
            this.Controls.Add(this.dtpWork);
            this.Controls.Add(this.lblHourlyWage);
            this.Controls.Add(this.txtCurrentWage);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnSettings);
            this.Name = "Form1";
            this.Text = "Wage Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblHourlyWage;
        private System.Windows.Forms.TextBox txtCurrentWage;
        private System.Windows.Forms.DateTimePicker dtpWork;
        private System.Windows.Forms.Label lblMonthW;
        private System.Windows.Forms.TextBox txtMonthW;
        private System.Windows.Forms.Label lblDailyW;
        private System.Windows.Forms.TextBox txtDailyW;
        private System.Windows.Forms.Label lblHoursInput;
        private System.Windows.Forms.TextBox txtHoursInput;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnDEL;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.RadioButton rdbPartTime;
        private System.Windows.Forms.RadioButton rdbFulltime;
        private System.Windows.Forms.ListBox lsbData;
        private System.Windows.Forms.ToolTip tlpAdd;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblYearW;
        private System.Windows.Forms.TextBox txtYearW;
    }
}

