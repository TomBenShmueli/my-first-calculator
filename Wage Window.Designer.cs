namespace WindowsFormsApp5
{
    partial class Form2
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
            this.btnWage = new System.Windows.Forms.Button();
            this.txtWage = new System.Windows.Forms.TextBox();
            this.lblWage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWage
            // 
            this.btnWage.Location = new System.Drawing.Point(98, 73);
            this.btnWage.Name = "btnWage";
            this.btnWage.Size = new System.Drawing.Size(75, 23);
            this.btnWage.TabIndex = 0;
            this.btnWage.Text = "Set!";
            this.btnWage.UseVisualStyleBackColor = true;
            this.btnWage.Click += new System.EventHandler(this.btnWage_Click);
            // 
            // txtWage
            // 
            this.txtWage.Location = new System.Drawing.Point(142, 27);
            this.txtWage.Name = "txtWage";
            this.txtWage.Size = new System.Drawing.Size(100, 22);
            this.txtWage.TabIndex = 1;
            // 
            // lblWage
            // 
            this.lblWage.AutoSize = true;
            this.lblWage.Location = new System.Drawing.Point(36, 27);
            this.lblWage.Name = "lblWage";
            this.lblWage.Size = new System.Drawing.Size(87, 17);
            this.lblWage.TabIndex = 2;
            this.lblWage.Text = "Enter Wage:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 116);
            this.Controls.Add(this.lblWage);
            this.Controls.Add(this.txtWage);
            this.Controls.Add(this.btnWage);
            this.Name = "Form2";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWage;
        private System.Windows.Forms.TextBox txtWage;
        private System.Windows.Forms.Label lblWage;
    }
}