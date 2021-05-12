
namespace OOP_PROJECT
{
    partial class Local_Staff_Attendance
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
            this.label1 = new System.Windows.Forms.Label();
            this.Loader_Button = new System.Windows.Forms.Button();
            this.Data_Shower = new System.Windows.Forms.DataGridView();
            this.Mark_Button = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Shower)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(437, 51);
            this.label2.TabIndex = 4;
            this.label2.Text = "Local Staff Attendance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 26);
            this.label1.TabIndex = 113;
            this.label1.Text = "*Upload Attendance\'s Excel File:";
            // 
            // Loader_Button
            // 
            this.Loader_Button.Location = new System.Drawing.Point(285, 102);
            this.Loader_Button.Name = "Loader_Button";
            this.Loader_Button.Size = new System.Drawing.Size(221, 36);
            this.Loader_Button.TabIndex = 114;
            this.Loader_Button.Text = "Load File";
            this.Loader_Button.UseVisualStyleBackColor = true;
            this.Loader_Button.Click += new System.EventHandler(this.Loader_Button_Click);
            // 
            // Data_Shower
            // 
            this.Data_Shower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_Shower.Location = new System.Drawing.Point(64, 144);
            this.Data_Shower.Name = "Data_Shower";
            this.Data_Shower.RowHeadersWidth = 51;
            this.Data_Shower.RowTemplate.Height = 24;
            this.Data_Shower.Size = new System.Drawing.Size(632, 200);
            this.Data_Shower.TabIndex = 115;
            // 
            // Mark_Button
            // 
            this.Mark_Button.Location = new System.Drawing.Point(125, 379);
            this.Mark_Button.Name = "Mark_Button";
            this.Mark_Button.Size = new System.Drawing.Size(136, 38);
            this.Mark_Button.TabIndex = 116;
            this.Mark_Button.Text = "Mark";
            this.Mark_Button.UseVisualStyleBackColor = true;
            this.Mark_Button.Click += new System.EventHandler(this.Mark_Button_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(494, 379);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(136, 38);
            this.Close.TabIndex = 117;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Local_Staff_Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 442);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Mark_Button);
            this.Controls.Add(this.Data_Shower);
            this.Controls.Add(this.Loader_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Local_Staff_Attendance";
            this.Text = "Local_Staff_Attendance";
            this.Load += new System.EventHandler(this.Local_Staff_Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data_Shower)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Loader_Button;
        private System.Windows.Forms.DataGridView Data_Shower;
        private System.Windows.Forms.Button Mark_Button;
        private System.Windows.Forms.Button Close;
    }
}