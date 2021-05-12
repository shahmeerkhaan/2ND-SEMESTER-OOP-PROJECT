namespace OOP_PROJECT
{
    partial class Admin_s_Use
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
            this.Add_Members = new System.Windows.Forms.Button();
            this.Remove_Members = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(515, 51);
            this.label2.TabIndex = 2;
            this.label2.Text = "Perform your Desire Task..";
            // 
            // Add_Members
            // 
            this.Add_Members.Location = new System.Drawing.Point(113, 137);
            this.Add_Members.Margin = new System.Windows.Forms.Padding(4);
            this.Add_Members.Name = "Add_Members";
            this.Add_Members.Size = new System.Drawing.Size(172, 37);
            this.Add_Members.TabIndex = 3;
            this.Add_Members.Text = "Add Members";
            this.Add_Members.UseVisualStyleBackColor = true;
            this.Add_Members.Click += new System.EventHandler(this.Add_Members_Click);
            // 
            // Remove_Members
            // 
            this.Remove_Members.Location = new System.Drawing.Point(428, 137);
            this.Remove_Members.Margin = new System.Windows.Forms.Padding(4);
            this.Remove_Members.Name = "Remove_Members";
            this.Remove_Members.Size = new System.Drawing.Size(192, 37);
            this.Remove_Members.TabIndex = 4;
            this.Remove_Members.Text = "Remove Members";
            this.Remove_Members.UseVisualStyleBackColor = true;
            this.Remove_Members.Click += new System.EventHandler(this.Remove_Members_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(254, 255);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 28);
            this.button3.TabIndex = 5;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Admin_s_Use
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 321);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Remove_Members);
            this.Controls.Add(this.Add_Members);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Admin_s_Use";
            this.Text = "Admin_s_Use";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Add_Members;
        private System.Windows.Forms.Button Remove_Members;
        private System.Windows.Forms.Button button3;
    }
}