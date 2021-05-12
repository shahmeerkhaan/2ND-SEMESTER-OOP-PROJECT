
namespace OOP_PROJECT
{
    partial class Assignment_Insertion
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
            this.Name_Textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Assignment_Type = new System.Windows.Forms.ComboBox();
            this.AssignmentBox = new System.Windows.Forms.PictureBox();
            this.Save = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AssignmentBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 51);
            this.label2.TabIndex = 8;
            this.label2.Text = "Assignment Insertion";
            // 
            // Name_Textbox
            // 
            this.Name_Textbox.Location = new System.Drawing.Point(295, 119);
            this.Name_Textbox.Margin = new System.Windows.Forms.Padding(4);
            this.Name_Textbox.Name = "Name_Textbox";
            this.Name_Textbox.Size = new System.Drawing.Size(335, 22);
            this.Name_Textbox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Assignment Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "Type:";
            // 
            // Assignment_Type
            // 
            this.Assignment_Type.FormattingEnabled = true;
            this.Assignment_Type.Items.AddRange(new object[] {
            "Primary",
            "Secondary",
            "Senior"});
            this.Assignment_Type.Location = new System.Drawing.Point(295, 72);
            this.Assignment_Type.Name = "Assignment_Type";
            this.Assignment_Type.Size = new System.Drawing.Size(185, 24);
            this.Assignment_Type.TabIndex = 18;
            // 
            // AssignmentBox
            // 
            this.AssignmentBox.Location = new System.Drawing.Point(89, 148);
            this.AssignmentBox.Name = "AssignmentBox";
            this.AssignmentBox.Size = new System.Drawing.Size(541, 160);
            this.AssignmentBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AssignmentBox.TabIndex = 19;
            this.AssignmentBox.TabStop = false;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(121, 386);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(115, 42);
            this.Save.TabIndex = 20;
            this.Save.Text = "Upload";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(465, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 42);
            this.button1.TabIndex = 21;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(295, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 42);
            this.button2.TabIndex = 22;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Assignment_Insertion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.AssignmentBox);
            this.Controls.Add(this.Assignment_Type);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Name_Textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Assignment_Insertion";
            this.Text = "Assignment_Insertion";
            ((System.ComponentModel.ISupportInitialize)(this.AssignmentBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Name_Textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Assignment_Type;
        private System.Windows.Forms.PictureBox AssignmentBox;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}