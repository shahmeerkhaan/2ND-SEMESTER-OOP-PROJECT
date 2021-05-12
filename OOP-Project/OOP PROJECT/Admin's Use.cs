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
    public partial class Admin_s_Use : Form
    {
        public Admin_s_Use()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Add_Members_Click(object sender, EventArgs e)
        {
            Adding_Manager Adding_New_Teacher_s_Form = new Adding_Manager();
            Adding_New_Teacher_s_Form.Show();
        }

        private void Remove_Members_Click(object sender, EventArgs e)
        {
            Removing_Teachers_Form Removing_School_s_Members_Form = new Removing_Teachers_Form();
            Removing_School_s_Members_Form.Show();
        }

        private void Add_New_Student_Click(object sender, EventArgs e)
        {

        }

        private void Add_Staff_Members_Click(object sender, EventArgs e)
        {

        }

        private void Remove_Student_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Clerk_s_Purpose_Click(object sender, EventArgs e)
        {

        }
    }
}
