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
using System.Data.OleDb;

namespace OOP_PROJECT
{
    public partial class Assignment_Insertion : Form
    {
        public Assignment_Insertion()
        {
            InitializeComponent();
        }

        private byte[] Assignment()
        {
            MemoryStream MS = new MemoryStream();
            AssignmentBox.Image.Save(MS, AssignmentBox.Image.RawFormat);
            return MS.GetBuffer();
        }

        public void Image_Selector()
        {
            OpenFileDialog OFD = new OpenFileDialog();
            if(OFD.ShowDialog() == DialogResult.OK)
            {
                AssignmentBox.Image = new Bitmap(OFD.FileName);
            }
        }

        public void Upload()
        {
            Assignment A = new Assignment();
            if (Assignment_Type.Text == "Primary")
            {
                string Querry = "Insert into PrimaryAssignment([Name],[Assignment]) values ('" + Name_Textbox.Text + "', '" + Assignment() + "')";
                A.Uploader(Querry);
                MessageBox.Show("Assignment Uploaded!!!!");
            }
            else if(Assignment_Type.Text == "Secondary")
            {
                string Querry = "Insert into SecondaryAssignment([Name],[Assignment]) values ('" + Name_Textbox.Text + "', '" + Assignment() + "')";
                A.Uploader(Querry);
                MessageBox.Show("Assignment Uploaded!!!!");
            }
            else if(Assignment_Type.Text == "Senior")
            {
                string Querry = "Insert into SeniorAssignment([Name],[Assignment]) values ('" + Name_Textbox.Text + "', '" + Assignment() + "')";
                A.Uploader(Querry);
                MessageBox.Show("Assignment Uploaded!!!!");
            }
            else
            {
                MessageBox.Show("Select Given Type!!!!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Image_Selector();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Upload();
        }
    }
    public class Assignment : ADDER_REMOVER
    {
        public void Uploader(string Querry)
        {
            CONNECTION(Querry);
        }
    }
}
