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
    public partial class Secondary_Assignment : Form
    {
        public Secondary_Assignment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SA_Click(object sender, EventArgs e)
        {
            string Querry = "Select * From SecondaryAssignment";
            DataLoader LSDL = new DataLoader();
            Sec_Task_Viewer.DataSource = LSDL.Loader(Querry);
        }
    }
}
