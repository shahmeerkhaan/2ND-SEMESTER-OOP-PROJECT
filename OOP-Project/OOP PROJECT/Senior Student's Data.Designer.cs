namespace OOP_PROJECT
{
    partial class Senior_Student_s_Data
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
            this.button2 = new System.Windows.Forms.Button();
            this.Assignment_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Assignment_Button
            // 
            this.Assignment_Button.Location = new System.Drawing.Point(165, 155);
            this.Assignment_Button.Name = "Assignment_Button";
            this.Assignment_Button.Size = new System.Drawing.Size(158, 23);
            this.Assignment_Button.TabIndex = 7;
            this.Assignment_Button.Text = "Assignment";
            this.Assignment_Button.UseVisualStyleBackColor = true;
            this.Assignment_Button.Click += new System.EventHandler(this.Assignment_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 41);
            this.label2.TabIndex = 6;
            this.label2.Text = "Perform your Desire Task..";
            // 
            // Senior_Student_s_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 296);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Assignment_Button);
            this.Controls.Add(this.label2);
            this.Name = "Senior_Student_s_Data";
            this.Text = "Senior_Student_s_Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Assignment_Button;
        private System.Windows.Forms.Label label2;
    }
}