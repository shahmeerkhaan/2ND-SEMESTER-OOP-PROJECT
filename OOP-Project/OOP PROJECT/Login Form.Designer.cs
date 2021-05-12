namespace OOP_PROJECT
{
    partial class Admin_s_Login_Form
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
            this.Login_Label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Admin_s_ID_TextBox = new System.Windows.Forms.TextBox();
            this.Admin_s_Password_TextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Login_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login_Label
            // 
            this.Login_Label.AutoSize = true;
            this.Login_Label.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Label.Location = new System.Drawing.Point(436, 40);
            this.Login_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Login_Label.Name = "Login_Label";
            this.Login_Label.Size = new System.Drawing.Size(147, 46);
            this.Login_Label.TabIndex = 0;
            this.Login_Label.Text = "LOGIN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(347, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "*ID:";
            // 
            // Admin_s_ID_TextBox
            // 
            this.Admin_s_ID_TextBox.Location = new System.Drawing.Point(423, 146);
            this.Admin_s_ID_TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Admin_s_ID_TextBox.Multiline = true;
            this.Admin_s_ID_TextBox.Name = "Admin_s_ID_TextBox";
            this.Admin_s_ID_TextBox.Size = new System.Drawing.Size(251, 29);
            this.Admin_s_ID_TextBox.TabIndex = 7;
            this.Admin_s_ID_TextBox.TextChanged += new System.EventHandler(this.ID_TextBox_TextChanged);
            // 
            // Admin_s_Password_TextBox
            // 
            this.Admin_s_Password_TextBox.Location = new System.Drawing.Point(423, 203);
            this.Admin_s_Password_TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Admin_s_Password_TextBox.Multiline = true;
            this.Admin_s_Password_TextBox.Name = "Admin_s_Password_TextBox";
            this.Admin_s_Password_TextBox.Size = new System.Drawing.Size(251, 29);
            this.Admin_s_Password_TextBox.TabIndex = 9;
            this.Admin_s_Password_TextBox.TextChanged += new System.EventHandler(this.Password_TextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(241, 202);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 31);
            this.label7.TabIndex = 8;
            this.label7.Text = "*Password:";
            // 
            // Login_Button
            // 
            this.Login_Button.Location = new System.Drawing.Point(112, 286);
            this.Login_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(177, 42);
            this.Login_Button.TabIndex = 10;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(744, 286);
            this.Cancel_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(177, 42);
            this.Cancel_Button.TabIndex = 11;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Admin_s_Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 410);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.Admin_s_Password_TextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Admin_s_ID_TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Login_Label);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Admin_s_Login_Form";
            this.Text = "Admin_s_Login_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login_Label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Admin_s_ID_TextBox;
        private System.Windows.Forms.TextBox Admin_s_Password_TextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Button Cancel_Button;
    }
}