using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace OOP_PROJECT
{
    public class Global_Variables//apparently working as a parent abstract class with incomplete variable which will be encapsulated later on in other classes
    {
        public string Connection = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\Kiet 2nd Semester\OOP\OOP Project\Main Database.accdb";
        //abstractions
        public DataTable AccessData;
        public DataTable Data_Table_of_Excel;
        public OleDbConnection CON;
        public OleDbCommand cmd;
        public OleDbDataAdapter DataAdapter;
        public DataTable DATA;
        public int a;
    }
    public class DAO
    {
        public string Connection = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\Kiet 2nd Semester\OOP\OOP Project\Main Database.accdb";
        public void login(string id, string Pass)//polymorphism and method overloading
        {
            string Querry = "Select * From LoginTable";
            DataTable accessData = new DataTable();
            OleDbConnection con = new OleDbConnection(Connection);
            con.Open();
            OleDbCommand cmd = new OleDbCommand(Querry, con);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd);
            dataAdapter.Fill(accessData);
            if (id == accessData.Rows[0]["ID"].ToString() && Pass == accessData.Rows[0]["Password"].ToString())
            {
                Admin_s_Use Admin_Work = new Admin_s_Use();
                Admin_Work.Show();
                con.Close();
            }
            else if (id == accessData.Rows[1]["ID"].ToString() && Pass == accessData.Rows[1]["Password"].ToString()) 
            {
                Primary_Student_s_Data Primary_Student_Work = new Primary_Student_s_Data();
                Primary_Student_Work.Show();
                con.Close();
            }
            else if (id == accessData.Rows[2]["ID"].ToString() && Pass == accessData.Rows[2]["Password"].ToString())
            {
                Secondary_Student_s_Data Secondary_Students_use = new Secondary_Student_s_Data();
                Secondary_Students_use.Show();
                con.Close();
            }
            else if (id == accessData.Rows[3]["ID"].ToString() && Pass == accessData.Rows[3]["Password"].ToString())
            {
                Senior_Student_s_Data Senior_Students_use = new Senior_Student_s_Data();
                Senior_Students_use.Show();
                con.Close();
            }
            else if (id == accessData.Rows[4]["ID"].ToString() && Pass == accessData.Rows[4]["Password"].ToString())
            {
                Teacher_s_Use Teacher_Work = new Teacher_s_Use();
                Teacher_Work.Show();
                con.Close();
            }
            else if (id == accessData.Rows[5]["ID"].ToString() && Pass == accessData.Rows[5]["Password"].ToString())
            {
                Teacher_s_Use Teacher_Work = new Teacher_s_Use();
                Teacher_Work.Show();
                con.Close();
            }
            else if (id == accessData.Rows[6]["ID"].ToString() && Pass == accessData.Rows[6]["Password"].ToString()) 
            {
                Teacher_s_Use Teacher_Work = new Teacher_s_Use();
                Teacher_Work.Show();
                con.Close();
            }
            else if (id == accessData.Rows[7]["ID"].ToString() && Pass == accessData.Rows[7]["Password"].ToString())
            {
                Admin_Staff_Work Staff_Work = new Admin_Staff_Work();
                Staff_Work.Show();
                con.Close();
            }
            else if (id == accessData.Rows[8]["ID"].ToString() && Pass == accessData.Rows[8]["Password"].ToString())
            {
                Admin_Staff_Work Staff_Work = new Admin_Staff_Work();
                Staff_Work.Show();
                con.Close();
            }
            else if (id == accessData.Rows[9]["ID"].ToString() && Pass == accessData.Rows[9]["Password"].ToString())
            {
                Admin_Staff_Work Staff_Work = new Admin_Staff_Work();
                Staff_Work.Show();
                con.Close();
            }
            else
            {
                MessageBox.Show("Invalid ID or/and Password!!!!!!!!");
            }
        }
    }

    public class ADDER_REMOVER : Global_Variables//inheritance
    {
        public string Querry;
        public void Adder(string Name, string Type, string Address, string Contact, string querry)//polymorphism and method overloading
        {
            CONNECTION(Querry);
        }
        public void CONNECTION(string Querry)//polymorphism and method overloading
        {
            while (true)
            {
                CON = new OleDbConnection(Connection);
                cmd = new OleDbCommand(Querry, CON);
                CON.Open();
                a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Task Completed!!");
                    CON.Close();
                }
                else
                {
                    MessageBox.Show("Task didn't got Completed!!!");
                    CON.Close();
                }
                break;
            }
        }
        public void Attendance_Conn(string Querry)
        {
            CON = new OleDbConnection(Connection);
            cmd = new OleDbCommand(Querry, CON);
            CON.Open();
            if (a <= 0)
            {
                MessageBox.Show("Failed!!!");
            }
            CON.Close();
        }
    }
    public class DataLoader : Global_Variables//inheritance
    {
        public void LoaderEngine(string Querry)
        {
            CON = new OleDbConnection(Connection);
            cmd = new OleDbCommand(Querry, CON);
            DataAdapter = new OleDbDataAdapter(cmd);
            AccessData = new DataTable();
            DataAdapter.Fill(AccessData);
            DATA = new DataTable();
            DATA = AccessData;
        }
        public DataTable Loader(string Querry)
        {
            LoaderEngine(Querry);
            return DATA;
        }
    }
    public class Attendance_Work : ADDER_REMOVER//inheritance
    {
        public string connection;//abstraction
        public DataTable ReadFile(string File_Name, string File_Extension)//polymorphism and method overloading
        {
            Data_Table_of_Excel = new DataTable();
            if (File_Extension.CompareTo(".xls") == 0)
            {
                connection = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + File_Name + ";Extended Properties='Excel 8.0;HRD=Yes;IMEX=1';";
                //for below excel 2007  
            }
            else
            {
                connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + File_Name + ";Extended Properties='Excel 12.0;HDR=NO';";
                //for above excel 2007 
            }
            CON = new OleDbConnection(connection);
            DataAdapter = new OleDbDataAdapter("select * from [Sheet1$]", CON); //here we read data from sheet1 pf any Excel file..  
            DataAdapter.Fill(Data_Table_of_Excel); //fills excel data into dataTable of gridviewer.. 
            return Data_Table_of_Excel;
        }
        public void ATT(string Querry)
        {
            Attendance_Conn(Querry);
        }
        public void T_ATT(string Date, string Name, string Status, string Type, string Type_ID, string Querry)//polymorphism and method overloading
        {
            CONNECTION(Querry);
        }
    }
}
