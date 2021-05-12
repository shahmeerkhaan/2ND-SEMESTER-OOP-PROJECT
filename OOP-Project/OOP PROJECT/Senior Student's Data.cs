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
    public partial class Senior_Student_s_Data : Form
    {
        public Senior_Student_s_Data()
        {
            InitializeComponent();
        }

        private void Assignment_Button_Click(object sender, EventArgs e)
        {
            Senior_Assignment SEA = new Senior_Assignment();
            SEA.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
