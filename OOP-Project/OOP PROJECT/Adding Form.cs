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
    public partial class Adding_Manager : Form
    {
        public Adding_Manager()
        {
            InitializeComponent();
        }

        private void Adding_Form_Load(object sender, EventArgs e)
        {

        }

        private void VScroller_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Add_New_Primary_Teacher_Click(object sender, EventArgs e)
        {

        }
        public void ADDER()
        {
            //==================================================================================================================
            Student_s_Addition SA = new Student_s_Addition();
            if (Type_Combobox.Text == "Primary-Student")
            {
                SA.Primary_Student(Name_Textbox.Text, Type_Combobox.Text, Address_Textbox.Text, Contact_Textbox.Text);//encapsulation
            }
            else if (Type_Combobox.Text == "Secondary-Student")
            {
                SA.Secondary_Student(Name_Textbox.Text, Type_Combobox.Text, Address_Textbox.Text, Contact_Textbox.Text);//encapsulation
            }
            else if (Type_Combobox.Text == "Senior-Student")
            {
                SA.Senior_Student(Name_Textbox.Text, Type_Combobox.Text, Address_Textbox.Text, Contact_Textbox.Text);//encapsulation
            }
            //==============================================================================================================
            Teacher_s_Addition TA = new Teacher_s_Addition();
            if (Type_Combobox.Text == "Primary-Teacher")
            {
                TA.Primary_Teacher(Name_Textbox.Text, Type_Combobox.Text, Address_Textbox.Text, Contact_Textbox.Text);//encapsulation
            }
            else if (Type_Combobox.Text == "Secondary-Teacher")
            {
                TA.Secondary_Teacher(Name_Textbox.Text, Type_Combobox.Text, Address_Textbox.Text, Contact_Textbox.Text);//encapsulation
            }
            else if (Type_Combobox.Text == "Senior-Teacher")
            {
                TA.Senior_Teacher(Name_Textbox.Text, Type_Combobox.Text, Address_Textbox.Text, Contact_Textbox.Text);//encapsulation
            }
            //==============================================================================================================
            Local_Staff_Addition LSA = new Local_Staff_Addition();
            if (Type_Combobox.Text == "Clerk")
            {
                LSA.Clerk(Name_Textbox.Text, Type_Combobox.Text, Address_Textbox.Text, Contact_Textbox.Text);//encapsulation
            }
            else if (Type_Combobox.Text == "Assistant")
            {
                LSA.Assistant(Name_Textbox.Text, Type_Combobox.Text, Address_Textbox.Text, Contact_Textbox.Text);//encapsulation
            }
            else if (Type_Combobox.Text == "Receptionist")
            {
                LSA.Receptionist(Name_Textbox.Text, Type_Combobox.Text, Address_Textbox.Text, Contact_Textbox.Text);//encapsulation
            }
            //==============================================================================================================
        }

        private void Add_New_Pri_Teacher_ID_Click(object sender, EventArgs e)
        {

        }

        private void Add_New_Pri_Teacher_Pass_Click(object sender, EventArgs e)
        {

        }

        private void Add_New_Secondary_Teacher_Click(object sender, EventArgs e)
        {

        }

        private void Add_New_Sec_Teacher_ID_Click(object sender, EventArgs e)
        {

        }

        private void Add_New_Sec_Teacher_Pass_Click(object sender, EventArgs e)
        {

        }

        private void Add_New_Senior_Teacher_Click(object sender, EventArgs e)
        {

        }

        private void Add_New_Sen_Teacher_ID_Click(object sender, EventArgs e)
        {

        }

        private void Add_New_Sen_Teacher_Pass_Click(object sender, EventArgs e)
        {
            ADDER();
        }
    }
    public class Student_s_Addition : ADDER_REMOVER//inheritance
    {
        public void Primary_Student(string Name, string Type, string Address, string Contact)//poly.. and method overloading passing of values baically
        {
            Querry = "Insert into StudentsData([Name],[Type],[Type_ID],[Address],[Contact]) values ('" + Name + "', '" + Type + "', '" + "2" + "', '" + Address + "', '" + Contact + "')";
            while (true)
            {
                Adder(Name, Type, Address, Contact, Querry);//poly.. and method overloading passing of values baically
                break;
            }
        }
        public void Secondary_Student(string Name, string Type, string Address, string Contact)//poly.. and method overloading passing of values baically
        {
            Querry = "Insert into StudentsData([Name],[Type],[Type_ID],[Address],[Contact]) values ('" + Name + "', '" + Type + "', '" + "3" + "', '" + Address + "', '" + Contact + "')";
            while (true)
            {
                Adder(Name, Type, Address, Contact, Querry);//poly.. and method overloading passing of values baically
                break;
            }
        }
        public void Senior_Student(string Name, string Type, string Address, string Contact)//poly.. and method overloading passing of values baically
        {
            Querry = "Insert into StudentsData([Name],[Type],[Type_ID],[Address],[Contact]) values ('" + Name + "', '" + Type + "', '" + "4" + "', '" + Address + "', '" + Contact + "')";
            while (true)
            {
                Adder(Name, Type, Address, Contact, Querry);//poly.. and method overloading passing of values baically
                break;
            }
        }
    }
    public class Teacher_s_Addition : ADDER_REMOVER//inheritance
    {
        public void Primary_Teacher(string Name, string Type, string Address, string Contact)//poly.. and method overloading passing of values baically
        {
            Querry = "Insert into TeachersData([Name],[Type],[Type_ID],[Address],[Contact]) values ('" + Name + "', '" + Type + "', '" + "5" + "', '" + Address + "', '" + Contact + "')";
            while (true)
            {
                Adder(Name, Type, Address, Contact, Querry);//poly.. and method overloading passing of values baically
                break;
            }
        }
        public void Secondary_Teacher(string Name, string Type, string Address, string Contact)//poly.. and method overloading passing of values baically
        {
            Querry = "Insert into TeachersData([Name],[Type],[Type_ID],[Address],[Contact]) values ('" + Name + "', '" + Type + "', '" + "6" + "', '" + Address + "', '" + Contact + "')";
            while (true)
            {
                Adder(Name, Type, Address, Contact, Querry);//poly.. and method overloading passing of values baically
                break;
            }
        }
        public void Senior_Teacher(string Name, string Type, string Address, string Contact)//poly.. and method overloading passing of values baically
        {
            Querry = "Insert into TeachersData([Name],[Type],[Type_ID],[Address],[Contact]) values ('" + Name + "', '" + Type + "', '" + "7" + "', '" + Address + "', '" + Contact + "')";
            while (true)
            {
                Adder(Name, Type, Address, Contact, Querry);//poly.. and method overloading passing of values baically
                break;
            }
        }
    }
    public class Local_Staff_Addition : ADDER_REMOVER//inheritance
    {
        public void Clerk(string Name, string Type, string Address, string Contact)//poly.. and method overloading passing of values baically
        {
            Querry = "Insert into LocalStaffsData([Name],[Type],[Type_ID],[Address],[Contact]) values ('" + Name + "', '" + Type + "', '" + "8" + "', '" + Address + "', '" + Contact + "')";
            while (true)
            {
                Adder(Name, Type, Address, Contact, Querry);//poly.. and method overloading passing of values baically
                break;
            }
        }
        public void Assistant(string Name, string Type, string Address, string Contact)//poly.. and method overloading passing of values baically
        {
            Querry = "Insert into LocalStaffsData([Name],[Type],[Type_ID],[Address],[Contact]) values ('" + Name + "', '" + Type + "', '" + "9" + "', '" + Address + "', '" + Contact + "')";
            while (true)
            {
                Adder(Name, Type, Address, Contact, Querry);//poly.. and method overloading passing of values baically
                break;
            }
        }
        public void Receptionist(string Name, string Type, string Address, string Contact)
        {
            Querry = "Insert into LocalStaffsData([Name],[Type],[Type_ID],[Address],[Contact]) values ('" + Name + "', '" + Type + "', '" + "10" + "', '" + Address + "', '" + Contact + "')";
            while (true)
            {
                Adder(Name, Type, Address, Contact, Querry);//poly.. and method overloading passing of values baically
                break;
            }
        }
    }
}
