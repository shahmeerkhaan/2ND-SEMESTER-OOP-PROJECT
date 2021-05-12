using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_PROJECT
{
    public partial class Primary_Assignment : Form
    {
        public Primary_Assignment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SDATA_Click(object sender, EventArgs e)
        {
            string Querry = "Select * From PrimaryAssignment";
            DataLoader LSDL = new DataLoader();
            Pri_Task_Viewer.DataSource = LSDL.Loader(Querry);
        }
    }
}
