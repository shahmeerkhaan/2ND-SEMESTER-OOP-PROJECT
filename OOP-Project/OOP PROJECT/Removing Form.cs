using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OOP_PROJECT
{
    public partial class Removing_Teachers_Form : Form
    {
        public Removing_Teachers_Form()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Remove_New_Primary_Teacher_Click(object sender, EventArgs e)
        {
            Remover();
        }

        public void Remover()
        {
            while (true)
            {
                if (Combo_Loader.Text == "")
                {
                    MessageBox.Show("Load Data in Grid View First!!!");
                    break;
                }
                if (Combo_Loader.Text == "Teachers-Data" || Combo_Loader.Text == "Students-Data" || Combo_Loader.Text == "Local-Staffs-Data")
                {
                    int selectedIndex = DataShower.SelectedRows[0].Index;
                    if (selectedIndex != -1)
                    {
                        string selected = DataShower.SelectedRows[0].Cells[0].Value.ToString();
                        int id = Convert.ToInt32(selected);
                        Remove(id);
                        break;
                    }
                }
            }
        }
        public void Remove(int id)
        {
            ADDER_REMOVER REM = new ADDER_REMOVER();
            if (Combo_Loader.Text == "Teachers-Data")
            {
                foreach (DataGridViewRow item in this.DataShower.SelectedRows)
                {
                    DataShower.Rows.RemoveAt(item.Index);
                    string del_query = "delete from TeachersData where TeacherID = " + id.ToString() + "";
                    REM.CONNECTION(del_query);
                }
            }
            else if(Combo_Loader.Text == "Students-Data")
            {
                foreach (DataGridViewRow item in this.DataShower.SelectedRows)
                {
                    DataShower.Rows.RemoveAt(item.Index);
                    string del_query = "delete from StudentsData where StudentID = " + id.ToString() + "";
                    REM.CONNECTION(del_query);
                }
            }
            else if(Combo_Loader.Text == "Local-Staffs-Data")
            {
                foreach (DataGridViewRow item in this.DataShower.SelectedRows)
                {
                    DataShower.Rows.RemoveAt(item.Index);
                    string del_query = "delete from LocalStaffsData where LocalStaffID = " + id.ToString() + "";
                    REM.CONNECTION(del_query);
                }
            }
        }

        private void Remove_New_Pri_Teacher_ID_Click(object sender, EventArgs e)
        {

        }

        private void Remove_New_Pri_Teacher_Pass_Click(object sender, EventArgs e)
        {

        }

        private void Remove_New_Secondary_Teacher_Click(object sender, EventArgs e)
        {

        }

        private void Remove_New_Sec_Teacher_ID_Click(object sender, EventArgs e)
        {

        }

        private void Remove_New_Sec_Teacher_Pass_Click(object sender, EventArgs e)
        {

        }

        private void Remove_New_Senior_Teacher_Click(object sender, EventArgs e)
        {

        }

        private void Remove_New_Sen_Teacher_ID_Click(object sender, EventArgs e)
        {

        }
        private void Remove_New_Sen_Teacher_Pass_Click(object sender, EventArgs e)
        {

        }
        
        private void Students_Data_Load_Click(object sender, EventArgs e)
        {

        }

        private void Removing_Teachers_Form_Load(object sender, EventArgs e)
        {

        }

        private void Teachers_Data_Load_Click(object sender, EventArgs e)
        {

        }

        private void Local_Staff_Data_Load_Click(object sender, EventArgs e)
        {

        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Remove_Pri_Teacher_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Update_Button_Click(object sender, EventArgs e)
        {

        }

        private void Tch_Update_Button_Click(object sender, EventArgs e)
        {

        }

        private void Staff_Update_Butt_Click(object sender, EventArgs e)
        {

        }

        private void Combo_Loader_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Combo_Loader.Text == "Students-Data")
            {
                StdsData_loader();
            }
            else if(Combo_Loader.Text == "Teachers-Data")
            {
                TeachersData_Loader();
            }
            else if(Combo_Loader.Text == "Local-Staffs-Data")
            {
                localStaffsData_Loader();
            }
        }

        public void StdsData_loader()
        {
            string Querry = "Select * From StudentsData";
            DataLoader STDL = new DataLoader();
            DataShower.DataSource = STDL.Loader(Querry);
        }
        public void TeachersData_Loader()
        {
            string Querry = "Select * From TeachersData";
            DataLoader TDL = new DataLoader();
            DataShower.DataSource = TDL.Loader(Querry);
        }
        public void localStaffsData_Loader()
        {
            string Querry = "Select * From LocalStaffsData";
            DataLoader LSDL = new DataLoader();
            DataShower.DataSource = LSDL.Loader(Querry);
        }
    }
    //public class Updater : Global_Variables
    //{
    //    public void Std_Modifier(string Querry)
    //    {
    //        CON = new OleDbConnection(Connection);
    //        cmd = new OleDbCommand(Querry, CON);
    //        CON.Open();
    //        a = cmd.ExecuteNonQuery();
    //        if (a > 0)
    //        {
    //            MessageBox.Show("Data Has been Inserted.");
    //        }
    //        else
    //        {
    //            MessageBox.Show("Data didn't got inserted into Database.");
    //        }
    //        CON.Close();
    //    }
    ////}
    //public class Remover : Global_Variables
    //{
    //    public void Deleter(string del_query)
    //    {
    //        CON = new OleDbConnection(Connection);
    //        OleDbCommand cmd1 = new OleDbCommand(del_query, CON);
    //        CON.Open();
    //        a = cmd1.ExecuteNonQuery();
    //        if (a > 0)
    //        {
    //            MessageBox.Show("Data Has Been Deleted!!!!!");
    //        }
    //        else
    //        {
    //            MessageBox.Show("Data didn't got Deleted!!!");
    //        }
    //        CON.Close();
    //    }
    //}
}
