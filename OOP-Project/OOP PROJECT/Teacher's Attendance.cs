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
    public partial class Teacher_s_Attendance : Form
    {
        public Teacher_s_Attendance()
        {
            InitializeComponent();
        }

        private void Mark_Att_Button_Click(object sender, EventArgs e)
        {
            Teacher_Attendance T_att = new Teacher_Attendance();
            T_att.Teachers_Attendance(Name_Textbox.Text, Status_Textbox.Text, Type_Combo.Text, Type_ID_Textbox.Text);//encapsulation
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    public class Teacher_Attendance : Attendance_Work//inheritance
    {
        public void Teachers_Attendance(string Name, string Status, string Type, string Type_ID)//poly.. and method overloading passing of values baically
        {
            string Date = DateTime.Now.ToString("mm/dd/yyyy");
            Querry = "Insert into TeachersAttendance([Date],[Name],[Status],[Type],[Type_ID]) values ('" + Date + "', '" + Name + "', '" + Status + "', '" + Type + "', '" + Type_ID + "')";
            while (true)
            {
                T_ATT(Date, Name, Status, Type, Type_ID, Querry);//poly.. and method overloading passing of values baically
                break;
            }
        }
    }
}
