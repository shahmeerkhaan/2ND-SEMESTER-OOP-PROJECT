namespace OOP_PROJECT
{
    partial class Removing_Teachers_Form
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
            this.button3 = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Remove_New_Primary_Teacher = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DataShower = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.Combo_Loader = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataShower)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(384, 513);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 37);
            this.button3.TabIndex = 107;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(342, 9);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(351, 46);
            this.label26.TabIndex = 106;
            this.label26.Text = "Removing Manager";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 453);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 26);
            this.label1.TabIndex = 76;
            this.label1.Text = "Remove the Selected Row:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Remove_New_Primary_Teacher
            // 
            this.Remove_New_Primary_Teacher.Location = new System.Drawing.Point(573, 455);
            this.Remove_New_Primary_Teacher.Margin = new System.Windows.Forms.Padding(4);
            this.Remove_New_Primary_Teacher.Name = "Remove_New_Primary_Teacher";
            this.Remove_New_Primary_Teacher.Size = new System.Drawing.Size(134, 29);
            this.Remove_New_Primary_Teacher.TabIndex = 75;
            this.Remove_New_Primary_Teacher.Text = "Remove";
            this.Remove_New_Primary_Teacher.UseVisualStyleBackColor = true;
            this.Remove_New_Primary_Teacher.Click += new System.EventHandler(this.Remove_New_Primary_Teacher_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 410);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(787, 26);
            this.label3.TabIndex = 109;
            this.label3.Text = "*Select the ROW of the table to delete the entire specific row if you want to:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // DataShower
            // 
            this.DataShower.AllowUserToOrderColumns = true;
            this.DataShower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataShower.Location = new System.Drawing.Point(56, 118);
            this.DataShower.Name = "DataShower";
            this.DataShower.RowHeadersWidth = 51;
            this.DataShower.RowTemplate.Height = 24;
            this.DataShower.Size = new System.Drawing.Size(875, 274);
            this.DataShower.TabIndex = 110;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(186, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 26);
            this.label4.TabIndex = 111;
            this.label4.Text = "Load Data:";
            // 
            // Combo_Loader
            // 
            this.Combo_Loader.FormattingEnabled = true;
            this.Combo_Loader.Items.AddRange(new object[] {
            "Students-Data",
            "Teachers-Data",
            "Local-Staffs-Data"});
            this.Combo_Loader.Location = new System.Drawing.Point(508, 84);
            this.Combo_Loader.Name = "Combo_Loader";
            this.Combo_Loader.Size = new System.Drawing.Size(206, 24);
            this.Combo_Loader.TabIndex = 119;
            this.Combo_Loader.SelectedIndexChanged += new System.EventHandler(this.Combo_Loader_SelectedIndexChanged);
            // 
            // Removing_Teachers_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 563);
            this.Controls.Add(this.Combo_Loader);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DataShower);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Remove_New_Primary_Teacher);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Removing_Teachers_Form";
            this.Text = "Removing_Teachers_Form";
            this.Load += new System.EventHandler(this.Removing_Teachers_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataShower)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Remove_New_Primary_Teacher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DataShower;
        private System.Windows.Forms.ComboBox Combo_Loader;
    }
}