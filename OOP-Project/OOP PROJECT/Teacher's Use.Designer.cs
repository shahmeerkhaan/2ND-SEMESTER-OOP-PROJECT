namespace OOP_PROJECT
{
    partial class Teacher_s_Use
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
            this.Upload_Assignment_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Std_Attendance = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(515, 51);
            this.label2.TabIndex = 7;
            this.label2.Text = "Perform your Desire Task..";
            // 
            // Upload_Assignment_button
            // 
            this.Upload_Assignment_button.Location = new System.Drawing.Point(255, 64);
            this.Upload_Assignment_button.Margin = new System.Windows.Forms.Padding(4);
            this.Upload_Assignment_button.Name = "Upload_Assignment_button";
            this.Upload_Assignment_button.Size = new System.Drawing.Size(181, 28);
            this.Upload_Assignment_button.TabIndex = 8;
            this.Upload_Assignment_button.Text = "Upload Assignment";
            this.Upload_Assignment_button.UseVisualStyleBackColor = true;
            this.Upload_Assignment_button.Click += new System.EventHandler(this.Upload_Assignment_button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(255, 244);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Std_Attendance
            // 
            this.Std_Attendance.Location = new System.Drawing.Point(255, 122);
            this.Std_Attendance.Margin = new System.Windows.Forms.Padding(4);
            this.Std_Attendance.Name = "Std_Attendance";
            this.Std_Attendance.Size = new System.Drawing.Size(181, 28);
            this.Std_Attendance.TabIndex = 10;
            this.Std_Attendance.Text = "Mark STD Attendance";
            this.Std_Attendance.UseVisualStyleBackColor = true;
            this.Std_Attendance.Click += new System.EventHandler(this.Std_Attendance_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 182);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Mark Attendance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Teacher_s_Use
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 295);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Std_Attendance);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Upload_Assignment_button);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Teacher_s_Use";
            this.Text = "Teacher_s_Use";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Upload_Assignment_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Std_Attendance;
        private System.Windows.Forms.Button button1;
    }
}