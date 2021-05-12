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
    public partial class Teacher_s_Use : Form
    {
        public Teacher_s_Use()
        {
            InitializeComponent();
        }

        private void Upload_Assignment_button_Click(object sender, EventArgs e)
        {
            Assignment_Insertion AI = new Assignment_Insertion();
            AI.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Std_Attendance_Click(object sender, EventArgs e)
        {
            Students_Attendance StdAttendance = new Students_Attendance();
            StdAttendance.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teacher_s_Attendance TAT = new Teacher_s_Attendance();
            TAT.Show();
        }
    }
}
