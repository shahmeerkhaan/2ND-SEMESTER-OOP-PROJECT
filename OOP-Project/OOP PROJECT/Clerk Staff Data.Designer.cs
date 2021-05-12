namespace OOP_PROJECT
{
    partial class Admin_Staff_Work
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Staff_s_Check = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Attendance_Button = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(515, 51);
            this.label2.TabIndex = 3;
            this.label2.Text = "Perform your Desire Task..";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(518, 26);
            this.label3.TabIndex = 110;
            this.label3.Text = "*To check Staff\'s Data Click on the Button below:";
            // 
            // Staff_s_Check
            // 
            this.Staff_s_Check.Location = new System.Drawing.Point(323, 128);
            this.Staff_s_Check.Name = "Staff_s_Check";
            this.Staff_s_Check.Size = new System.Drawing.Size(124, 37);
            this.Staff_s_Check.TabIndex = 111;
            this.Staff_s_Check.Text = "Check";
            this.Staff_s_Check.UseVisualStyleBackColor = true;
            this.Staff_s_Check.Click += new System.EventHandler(this.Staff_s_Check_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 181);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(581, 26);
            this.label1.TabIndex = 112;
            this.label1.Text = "*To mark Staff\'s Attendance Click on the Button below:";
            // 
            // Attendance_Button
            // 
            this.Attendance_Button.Location = new System.Drawing.Point(323, 222);
            this.Attendance_Button.Name = "Attendance_Button";
            this.Attendance_Button.Size = new System.Drawing.Size(124, 40);
            this.Attendance_Button.TabIndex = 113;
            this.Attendance_Button.Text = "Attendance";
            this.Attendance_Button.UseVisualStyleBackColor = true;
            this.Attendance_Button.Click += new System.EventHandler(this.Attendance_Button_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(323, 313);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(124, 37);
            this.Close.TabIndex = 114;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Admin_Staff_Work
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 382);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Attendance_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Staff_s_Check);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Admin_Staff_Work";
            this.Text = "Admin_Staff_Work";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Staff_s_Check;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Attendance_Button;
        private System.Windows.Forms.Button Close;
    }
}