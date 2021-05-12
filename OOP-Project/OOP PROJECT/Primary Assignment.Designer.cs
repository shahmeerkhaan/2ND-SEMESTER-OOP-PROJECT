
namespace OOP_PROJECT
{
    partial class Primary_Assignment
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
            this.SA = new System.Windows.Forms.Button();
            this.Pri_Task_Viewer = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pri_Task_Viewer)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(571, 51);
            this.label2.TabIndex = 4;
            this.label2.Text = "Primary Student\'s Assignment";
            // 
            // SA
            // 
            this.SA.Location = new System.Drawing.Point(334, 79);
            this.SA.Name = "SA";
            this.SA.Size = new System.Drawing.Size(126, 34);
            this.SA.TabIndex = 111;
            this.SA.Text = "Show";
            this.SA.UseVisualStyleBackColor = true;
            this.SA.Click += new System.EventHandler(this.SDATA_Click);
            // 
            // Pri_Task_Viewer
            // 
            this.Pri_Task_Viewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Pri_Task_Viewer.Location = new System.Drawing.Point(92, 119);
            this.Pri_Task_Viewer.Name = "Pri_Task_Viewer";
            this.Pri_Task_Viewer.RowHeadersWidth = 51;
            this.Pri_Task_Viewer.RowTemplate.Height = 24;
            this.Pri_Task_Viewer.Size = new System.Drawing.Size(629, 290);
            this.Pri_Task_Viewer.TabIndex = 112;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 34);
            this.button1.TabIndex = 113;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Primary_Assignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Pri_Task_Viewer);
            this.Controls.Add(this.SA);
            this.Controls.Add(this.label2);
            this.Name = "Primary_Assignment";
            this.Text = "Primary_Assignment";
            ((System.ComponentModel.ISupportInitialize)(this.Pri_Task_Viewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SA;
        private System.Windows.Forms.DataGridView Pri_Task_Viewer;
        private System.Windows.Forms.Button button1;
    }
}