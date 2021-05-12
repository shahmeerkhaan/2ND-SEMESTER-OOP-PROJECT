using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OOP_PROJECT
{
    public partial class Students_Attendance : Form
    {
        public string Path_of_File;
        public string Extension_of_File;
        Attendance_Work ATT_Marker;
        public string Date = DateTime.Now.ToString("MM/dd/yyyy");
        public Students_Attendance()
        {
            InitializeComponent();
        }

        private void Students_Attendance_Load(object sender, EventArgs e)
        {

        }
        public void File_Loader()
        {
            ATT_Marker = new Attendance_Work();
            OpenFileDialog File = new OpenFileDialog(); //Will open dialogbox to choose our desire file from where we want to import data..
            if (File.ShowDialog() == DialogResult.OK) //using this for if there is a file choosen by the user  
            {
                Path_of_File = File.FileName;//this will get the path of the file  
                Extension_of_File = Path.GetExtension(Path_of_File);// this will get the file extension  
                if (Extension_of_File.CompareTo(".xls") == 0 || Extension_of_File.CompareTo(".xlsx") == 0)
                {
                    DataTable dtExcel = new DataTable();
                    dtExcel = ATT_Marker.ReadFile(Path_of_File, Extension_of_File);//read excel file  
                    Data_View.Visible = true;
                    Data_View.DataSource = dtExcel;
                }
                else
                {
                    MessageBox.Show("Please choose .xls or .xlsx file only.");
                    //custom messageBox to show error  
                }
            }
        }
        public void Attendance_Insertion()
        {
            ATT_Marker = new Attendance_Work();
            if (Combo_Loader.Text == "Primary-Students")
            {
                foreach (DataGridViewRow each_row in Data_View.Rows)
                {
                    for (int i = 1; i < each_row.Cells.Count - 1; i++)
                    {
                        string Querry = "Insert into PrimaryStdAttendance([Date],[Name],[Status],[Type],[Type_ID]) values ('" + Date + "', '" + each_row.Cells[0].Value + "', '" + each_row.Cells[1].Value + "', '" + each_row.Cells[2].Value + "', '" + each_row.Cells[3].Value + "')";
                        ATT_Marker.ATT(Querry);
                        break;
                    }
                }
            }
            else if(Combo_Loader.Text == "Secondary-Students")
            {
                foreach (DataGridViewRow each_row in Data_View.Rows)
                {
                    for (int i = 1; i < each_row.Cells.Count - 1; i++)
                    {
                        string Querry = "Insert into SecondaryStdAttendance([Date],[Name],[Status],[Type],[Type_ID]) values ('" + Date + "', '" + each_row.Cells[0].Value + "', '" + each_row.Cells[1].Value + "', '" + each_row.Cells[2].Value + "', '" + each_row.Cells[3].Value + "')";
                        ATT_Marker.ATT(Querry);
                        break;
                    }
                }
            }
            else if(Combo_Loader.Text == "Senior-Students")
            {
                foreach (DataGridViewRow each_row in Data_View.Rows)
                {
                    for (int i = 1; i < each_row.Cells.Count - 1; i++)
                    {
                        string Querry = "Insert into SeniorStdAttendance([Date],[Name],[Status],[Type],[Type_ID]) values ('" + Date + "', '" + each_row.Cells[0].Value + "', '" + each_row.Cells[1].Value + "', '" + each_row.Cells[2].Value + "', '" + each_row.Cells[3].Value + "')";
                        ATT_Marker.ATT(Querry);
                        break;
                    }
                }
            }
            MessageBox.Show("Attendance Data Saved!!!");
        }
        private void Loader_Button_Click(object sender, EventArgs e)
        {
            File_Loader();
        }

        private void Mark_Button_Click(object sender, EventArgs e)
        {
            Attendance_Insertion();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
