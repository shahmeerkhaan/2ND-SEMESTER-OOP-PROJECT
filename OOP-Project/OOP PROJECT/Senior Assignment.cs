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
    public partial class Senior_Assignment : Form
    {
        public Senior_Assignment()
        {
            InitializeComponent();
        }

        private void Senior_Assignment_Load(object sender, EventArgs e)
        {

        }

        private void SEA_Click(object sender, EventArgs e)
        {
            string Querry = "Select * From SeniorAssignment";
            DataLoader LSDL = new DataLoader();
            Sen_Task_Viewer.DataSource = LSDL.Loader(Querry);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
