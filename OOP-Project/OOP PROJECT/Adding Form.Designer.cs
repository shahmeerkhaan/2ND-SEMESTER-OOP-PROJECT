namespace OOP_PROJECT
{
    partial class Adding_Manager
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
            this.label1 = new System.Windows.Forms.Label();
            this.Name_Textbox = new System.Windows.Forms.TextBox();
            this.Address_Textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Add_Button = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Type_Combobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Contact_Textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name:";
            // 
            // Name_Textbox
            // 
            this.Name_Textbox.Location = new System.Drawing.Point(279, 88);
            this.Name_Textbox.Margin = new System.Windows.Forms.Padding(4);
            this.Name_Textbox.Name = "Name_Textbox";
            this.Name_Textbox.Size = new System.Drawing.Size(335, 22);
            this.Name_Textbox.TabIndex = 14;
            // 
            // Address_Textbox
            // 
            this.Address_Textbox.Location = new System.Drawing.Point(279, 133);
            this.Address_Textbox.Margin = new System.Windows.Forms.Padding(4);
            this.Address_Textbox.Name = "Address_Textbox";
            this.Address_Textbox.Size = new System.Drawing.Size(335, 22);
            this.Address_Textbox.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 26);
            this.label3.TabIndex = 19;
            this.label3.Text = "Address:";
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(127, 449);
            this.Add_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(149, 38);
            this.Add_Button.TabIndex = 39;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_New_Sen_Teacher_Pass_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(230, 9);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(324, 46);
            this.label26.TabIndex = 73;
            this.label26.Text = "Addition Manager";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(467, 449);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 38);
            this.button3.TabIndex = 74;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Type_Combobox
            // 
            this.Type_Combobox.FormattingEnabled = true;
            this.Type_Combobox.Items.AddRange(new object[] {
            "Primary-Student",
            "Secondary-Student",
            "Senior-Student",
            "Primary-Teacher",
            "Secondary-Teacher",
            "Senior-Teacher",
            "Clerk",
            "Assistant",
            "Receptionist"});
            this.Type_Combobox.Location = new System.Drawing.Point(279, 229);
            this.Type_Combobox.Margin = new System.Windows.Forms.Padding(4);
            this.Type_Combobox.Name = "Type_Combobox";
            this.Type_Combobox.Size = new System.Drawing.Size(219, 24);
            this.Type_Combobox.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(154, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 26);
            this.label4.TabIndex = 77;
            this.label4.Text = "Type:";
            // 
            // Contact_Textbox
            // 
            this.Contact_Textbox.Location = new System.Drawing.Point(279, 182);
            this.Contact_Textbox.Margin = new System.Windows.Forms.Padding(4);
            this.Contact_Textbox.Name = "Contact_Textbox";
            this.Contact_Textbox.Size = new System.Drawing.Size(335, 22);
            this.Contact_Textbox.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(122, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 26);
            this.label5.TabIndex = 78;
            this.label5.Text = "Contact:";
            // 
            // Adding_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(764, 503);
            this.Controls.Add(this.Contact_Textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Type_Combobox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.Address_Textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Name_Textbox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Adding_Manager";
            this.Text = "Adding Manager";
            this.Load += new System.EventHandler(this.Adding_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name_Textbox;
        private System.Windows.Forms.TextBox Address_Textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox Type_Combobox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Contact_Textbox;
        private System.Windows.Forms.Label label5;
    }
}