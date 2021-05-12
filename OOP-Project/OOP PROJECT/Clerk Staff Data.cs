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
    public partial class Admin_Staff_Work : Form
    {
        public Admin_Staff_Work()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Attendance_Button_Click(object sender, EventArgs e)
        {
            Local_Staff_Attendance Staff_Attendance = new Local_Staff_Attendance();
            Staff_Attendance.Show();
        }

        private void Staff_s_Check_Click(object sender, EventArgs e)
        {
            Staffs_Data StaffData = new Staffs_Data();
            StaffData.Show();
        }
    }
}
