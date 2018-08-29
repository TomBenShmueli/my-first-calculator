namespace WindowsFormsApp5
{
    partial class Export
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
            this.btnExText = new System.Windows.Forms.Button();
            this.btnExExcel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rdbDay = new System.Windows.Forms.RadioButton();
            this.rdbMonth = new System.Windows.Forms.RadioButton();
            this.rdbYear = new System.Windows.Forms.RadioButton();
            this.dtpExportInfo = new System.Windows.Forms.DateTimePicker();
            this.dsgExport = new System.Windows.Forms.DataGridView();
            this.exportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workDayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsgExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workDayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExText
            // 
            this.btnExText.Location = new System.Drawing.Point(366, 218);
            this.btnExText.Name = "btnExText";
            this.btnExText.Size = new System.Drawing.Size(126, 58);
            this.btnExText.TabIndex = 0;
            this.btnExText.Text = "Export to text file";
            this.btnExText.UseVisualStyleBackColor = true;
            this.btnExText.Click += new System.EventHandler(this.btnExText_Click);
            // 
            // btnExExcel
            // 
            this.btnExExcel.Location = new System.Drawing.Point(366, 282);
            this.btnExExcel.Name = "btnExExcel";
            this.btnExExcel.Size = new System.Drawing.Size(126, 58);
            this.btnExExcel.TabIndex = 1;
            this.btnExExcel.Text = "Export to Excel file";
            this.btnExExcel.UseVisualStyleBackColor = true;
            this.btnExExcel.Click += new System.EventHandler(this.btnExExcel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(366, 346);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(126, 58);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rdbDay
            // 
            this.rdbDay.AutoSize = true;
            this.rdbDay.Location = new System.Drawing.Point(58, 255);
            this.rdbDay.Name = "rdbDay";
            this.rdbDay.Size = new System.Drawing.Size(123, 21);
            this.rdbDay.TabIndex = 3;
            this.rdbDay.TabStop = true;
            this.rdbDay.Text = "Export day info";
            this.rdbDay.UseVisualStyleBackColor = true;
            // 
            // rdbMonth
            // 
            this.rdbMonth.AutoSize = true;
            this.rdbMonth.Location = new System.Drawing.Point(58, 282);
            this.rdbMonth.Name = "rdbMonth";
            this.rdbMonth.Size = new System.Drawing.Size(139, 21);
            this.rdbMonth.TabIndex = 4;
            this.rdbMonth.TabStop = true;
            this.rdbMonth.Text = "Export month info";
            this.rdbMonth.UseVisualStyleBackColor = true;
            // 
            // rdbYear
            // 
            this.rdbYear.AutoSize = true;
            this.rdbYear.Location = new System.Drawing.Point(58, 309);
            this.rdbYear.Name = "rdbYear";
            this.rdbYear.Size = new System.Drawing.Size(128, 21);
            this.rdbYear.TabIndex = 5;
            this.rdbYear.TabStop = true;
            this.rdbYear.Text = "Export year info";
            this.rdbYear.UseVisualStyleBackColor = true;
            // 
            // dtpExportInfo
            // 
            this.dtpExportInfo.Location = new System.Drawing.Point(12, 207);
            this.dtpExportInfo.Name = "dtpExportInfo";
            this.dtpExportInfo.Size = new System.Drawing.Size(255, 22);
            this.dtpExportInfo.TabIndex = 6;
            // 
            // dsgExport
            // 
            this.dsgExport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dsgExport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dsgExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsgExport.Location = new System.Drawing.Point(12, 12);
            this.dsgExport.Name = "dsgExport";
            this.dsgExport.RowTemplate.Height = 24;
            this.dsgExport.Size = new System.Drawing.Size(480, 189);
            this.dsgExport.TabIndex = 7;
            // 
            // exportBindingSource
            // 
            this.exportBindingSource.DataSource = typeof(WindowsFormsApp5.Export);
            // 
            // workDayBindingSource
            // 
            this.workDayBindingSource.DataSource = typeof(WindowsFormsApp5.WorkDay);
            // 
            // Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 414);
            this.Controls.Add(this.dsgExport);
            this.Controls.Add(this.dtpExportInfo);
            this.Controls.Add(this.rdbYear);
            this.Controls.Add(this.rdbMonth);
            this.Controls.Add(this.rdbDay);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnExExcel);
            this.Controls.Add(this.btnExText);
            this.Name = "Export";
            this.Text = "Export";
            this.Load += new System.EventHandler(this.Export_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsgExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workDayBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExText;
        private System.Windows.Forms.Button btnExExcel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rdbDay;
        private System.Windows.Forms.RadioButton rdbMonth;
        private System.Windows.Forms.RadioButton rdbYear;
        private System.Windows.Forms.DateTimePicker dtpExportInfo;
        private System.Windows.Forms.BindingSource exportBindingSource;
        private System.Windows.Forms.BindingSource workDayBindingSource;
        private System.Windows.Forms.DataGridView dsgExport;
    }
}