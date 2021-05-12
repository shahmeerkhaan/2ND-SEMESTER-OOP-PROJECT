
namespace OOP_PROJECT
{
    partial class Students_Attendance
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
            this.Combo_Loader = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.Data_View = new System.Windows.Forms.DataGridView();
            this.Loader_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Mark_Button = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Data_View)).BeginInit();
            this.SuspendLayout();
            // 
            // Combo_Loader
            // 
            this.Combo_Loader.FormattingEnabled = true;
            this.Combo_Loader.Items.AddRange(new object[] {
            "Primary-Students",
            "Secondary-Students",
            "Senior-Students"});
            this.Combo_Loader.Location = new System.Drawing.Point(381, 47);
            this.Combo_Loader.Name = "Combo_Loader";
            this.Combo_Loader.Size = new System.Drawing.Size(206, 24);
            this.Combo_Loader.TabIndex = 121;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 26);
            this.label4.TabIndex = 120;
            this.label4.Text = "Type:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(210, -1);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(358, 46);
            this.label26.TabIndex = 122;
            this.label26.Text = "Students Attendance";
            // 
            // Data_View
            // 
            this.Data_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_View.Location = new System.Drawing.Point(70, 155);
            this.Data_View.Name = "Data_View";
            this.Data_View.RowHeadersWidth = 51;
            this.Data_View.RowTemplate.Height = 24;
            this.Data_View.Size = new System.Drawing.Size(662, 237);
            this.Data_View.TabIndex = 123;
            // 
            // Loader_Button
            // 
            this.Loader_Button.Location = new System.Drawing.Point(284, 113);
            this.Loader_Button.Name = "Loader_Button";
            this.Loader_Button.Size = new System.Drawing.Size(221, 36);
            this.Loader_Button.TabIndex = 125;
            this.Loader_Button.Text = "Load File";
            this.Loader_Button.UseVisualStyleBackColor = true;
            this.Loader_Button.Click += new System.EventHandler(this.Loader_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 26);
            this.label1.TabIndex = 124;
            this.label1.Text = "*Upload Attendance\'s Excel File:";
            // 
            // Mark_Button
            // 
            this.Mark_Button.Location = new System.Drawing.Point(125, 400);
            this.Mark_Button.Name = "Mark_Button";
            this.Mark_Button.Size = new System.Drawing.Size(136, 38);
            this.Mark_Button.TabIndex = 126;
            this.Mark_Button.Text = "Mark";
            this.Mark_Button.UseVisualStyleBackColor = true;
            this.Mark_Button.Click += new System.EventHandler(this.Mark_Button_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(516, 400);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(136, 38);
            this.Close.TabIndex = 127;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Students_Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Mark_Button);
            this.Controls.Add(this.Loader_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Data_View);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.Combo_Loader);
            this.Controls.Add(this.label4);
            this.Name = "Students_Attendance";
            this.Text = "Students_Attendance";
            this.Load += new System.EventHandler(this.Students_Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data_View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Combo_Loader;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DataGridView Data_View;
        private System.Windows.Forms.Button Loader_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Mark_Button;
        private System.Windows.Forms.Button Close;
    }
}