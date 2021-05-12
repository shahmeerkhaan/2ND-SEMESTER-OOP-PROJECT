namespace OOP_PROJECT
{
    partial class Primary_Student_s_Data
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
            this.Assignment_Button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "Perform your Desire Task..";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Assignment_Button
            // 
            this.Assignment_Button.Location = new System.Drawing.Point(174, 136);
            this.Assignment_Button.Name = "Assignment_Button";
            this.Assignment_Button.Size = new System.Drawing.Size(158, 23);
            this.Assignment_Button.TabIndex = 4;
            this.Assignment_Button.Text = "Assignment";
            this.Assignment_Button.UseVisualStyleBackColor = true;
            this.Assignment_Button.Click += new System.EventHandler(this.Assignment_Button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Primary_Student_s_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 289);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Assignment_Button);
            this.Controls.Add(this.label2);
            this.Name = "Primary_Student_s_Data";
            this.Text = "Primary_Student_s_Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Assignment_Button;
        private System.Windows.Forms.Button button2;
    }
}