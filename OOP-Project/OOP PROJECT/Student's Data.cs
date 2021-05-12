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
    public partial class Primary_Student_s_Data : Form
    {
        public Primary_Student_s_Data()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Assignment_Button_Click(object sender, EventArgs e)
        {
            Primary_Assignment PA = new Primary_Assignment();
            PA.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    //Student form Class
    public abstract class Student_s_Activity
    {
        public void HomeWork_Submission()
        {

        }
        public void Test_Results()
        {

        }
    }
    public class PrimaryStudent : Student_s_Activity
    {

    }

    public class SecondaryStudents : Student_s_Activity
    {

    }

    public class SeniorStudents:Student_s_Activity
    {
       
    }
}
