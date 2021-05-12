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
    public partial class Staffs_Data : Form
    {
        public Staffs_Data()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DataViewer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Show_Click(object sender, EventArgs e)
        {
            string Querry = "Select * From StaffsAttendance";
            DataLoader LSDL = new DataLoader();
            Data_Viewer.DataSource = LSDL.Loader(Querry);
        }

        private void Staffs_Data_Load(object sender, EventArgs e)
        {

        }

        private void SDATA_Click(object sender, EventArgs e)
        {
            string Querry = "Select * From LocalStaffsData";
            DataLoader LSDL = new DataLoader();
            Data_Viewer.DataSource = LSDL.Loader(Querry);
        }
    }
}
