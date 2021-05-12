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
    public partial class Admin_s_Login_Form : Form
    {
        public Admin_s_Login_Form()
        {
            InitializeComponent();
            Admin_s_Password_TextBox.PasswordChar = '*';
        }

        private void ID_TextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Password_TextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            DAO Loginn = new DAO();
            Loginn.login(Admin_s_ID_TextBox.Text, Admin_s_Password_TextBox.Text);
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
