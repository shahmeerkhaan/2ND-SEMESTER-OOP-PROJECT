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
    public partial class Secondary_Student_s_Data : Form
    {
        public Secondary_Student_s_Data()
        {
            InitializeComponent();
        }

        private void Assignment_Button_Click(object sender, EventArgs e)
        {
            Secondary_Assignment SA = new Secondary_Assignment();
            SA.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
