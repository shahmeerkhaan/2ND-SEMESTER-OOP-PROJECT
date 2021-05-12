
namespace OOP_PROJECT
{
    partial class Staffs_Data
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
            this.Data_Viewer = new System.Windows.Forms.DataGridView();
            this.label26 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Show = new System.Windows.Forms.Button();
            this.SDATA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Viewer)).BeginInit();
            this.SuspendLayout();
            // 
            // Data_Viewer
            // 
            this.Data_Viewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_Viewer.Location = new System.Drawing.Point(79, 108);
            this.Data_Viewer.Name = "Data_Viewer";
            this.Data_Viewer.RowHeadersWidth = 51;
            this.Data_Viewer.RowTemplate.Height = 24;
            this.Data_Viewer.Size = new System.Drawing.Size(629, 290);
            this.Data_Viewer.TabIndex = 0;
            this.Data_Viewer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataViewer_CellContentClick);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(283, 9);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(226, 46);
            this.label26.TabIndex = 107;
            this.label26.Text = "Staffs Status";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 34);
            this.button1.TabIndex = 108;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(559, 68);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(126, 34);
            this.Show.TabIndex = 109;
            this.Show.Text = "Show Status";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // SDATA
            // 
            this.SDATA.Location = new System.Drawing.Point(112, 68);
            this.SDATA.Name = "SDATA";
            this.SDATA.Size = new System.Drawing.Size(126, 34);
            this.SDATA.TabIndex = 110;
            this.SDATA.Text = "Show Data";
            this.SDATA.UseVisualStyleBackColor = true;
            this.SDATA.Click += new System.EventHandler(this.SDATA_Click);
            // 
            // Staffs_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SDATA);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.Data_Viewer);
            this.Name = "Staffs_Data";
            this.Text = "Staffs_Data";
            this.Load += new System.EventHandler(this.Staffs_Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data_Viewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Data_Viewer;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.Button SDATA;
    }
}