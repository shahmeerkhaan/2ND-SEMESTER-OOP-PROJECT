
namespace OOP_PROJECT
{
    partial class Secondary_Assignment
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
            this.button1 = new System.Windows.Forms.Button();
            this.Sec_Task_Viewer = new System.Windows.Forms.DataGridView();
            this.SA = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Sec_Task_Viewer)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 34);
            this.button1.TabIndex = 117;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sec_Task_Viewer
            // 
            this.Sec_Task_Viewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Sec_Task_Viewer.Location = new System.Drawing.Point(86, 106);
            this.Sec_Task_Viewer.Name = "Sec_Task_Viewer";
            this.Sec_Task_Viewer.RowHeadersWidth = 51;
            this.Sec_Task_Viewer.RowTemplate.Height = 24;
            this.Sec_Task_Viewer.Size = new System.Drawing.Size(629, 290);
            this.Sec_Task_Viewer.TabIndex = 116;
            // 
            // SA
            // 
            this.SA.Location = new System.Drawing.Point(328, 66);
            this.SA.Name = "SA";
            this.SA.Size = new System.Drawing.Size(126, 34);
            this.SA.TabIndex = 115;
            this.SA.Text = "Show";
            this.SA.UseVisualStyleBackColor = true;
            this.SA.Click += new System.EventHandler(this.SA_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, -4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(612, 51);
            this.label2.TabIndex = 114;
            this.label2.Text = "Secondary Student\'s Assignment";
            // 
            // Secondary_Assignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Sec_Task_Viewer);
            this.Controls.Add(this.SA);
            this.Controls.Add(this.label2);
            this.Name = "Secondary_Assignment";
            this.Text = "Secondary_Assignment";
            ((System.ComponentModel.ISupportInitialize)(this.Sec_Task_Viewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Sec_Task_Viewer;
        private System.Windows.Forms.Button SA;
        private System.Windows.Forms.Label label2;
    }
}