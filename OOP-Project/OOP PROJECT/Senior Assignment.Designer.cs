
namespace OOP_PROJECT
{
    partial class Senior_Assignment
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
            this.Sen_Task_Viewer = new System.Windows.Forms.DataGridView();
            this.SEA = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Sen_Task_Viewer)).BeginInit();
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
            // Sen_Task_Viewer
            // 
            this.Sen_Task_Viewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Sen_Task_Viewer.Location = new System.Drawing.Point(86, 106);
            this.Sen_Task_Viewer.Name = "Sen_Task_Viewer";
            this.Sen_Task_Viewer.RowHeadersWidth = 51;
            this.Sen_Task_Viewer.RowTemplate.Height = 24;
            this.Sen_Task_Viewer.Size = new System.Drawing.Size(629, 290);
            this.Sen_Task_Viewer.TabIndex = 116;
            // 
            // SEA
            // 
            this.SEA.Location = new System.Drawing.Point(328, 66);
            this.SEA.Name = "SEA";
            this.SEA.Size = new System.Drawing.Size(126, 34);
            this.SEA.TabIndex = 115;
            this.SEA.Text = "Show";
            this.SEA.UseVisualStyleBackColor = true;
            this.SEA.Click += new System.EventHandler(this.SEA_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(540, 51);
            this.label2.TabIndex = 114;
            this.label2.Text = "Senior Student\'s Assignment";
            // 
            // Senior_Assignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Sen_Task_Viewer);
            this.Controls.Add(this.SEA);
            this.Controls.Add(this.label2);
            this.Name = "Senior_Assignment";
            this.Text = "Senior_Assignment";
            this.Load += new System.EventHandler(this.Senior_Assignment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sen_Task_Viewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Sen_Task_Viewer;
        private System.Windows.Forms.Button SEA;
        private System.Windows.Forms.Label label2;
    }
}