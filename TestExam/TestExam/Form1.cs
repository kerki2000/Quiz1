using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestExam
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if ((txtFname.Text != "") && (txtLname.Text != "") && (txtPhone.Text != ""))
            {

                User user = new User();

                user.SetFname(txtFname.Text);
                string userName = user.GetFname();

                user.SetLname(txtLname.Text);
                string userLname = user.GetLname();

                user.SetTel(txtPhone.Text);
                string userTel = user.GetTel();
                string path = @"c:\test\users.txt";

                user.CreateFile("First name :"+ userName+ " Last name :" + userLname + " Phone :" + userTel+"\n", path);
            }
            else
            {
                MessageBox.Show("Enter all fields", "Registration Caption", MessageBoxButtons.OKCancel);
            }
        }
    

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFname.Text = "";
            txtLname.Text = "";
            txtPhone.Text = "";
        }

        private void btnDeleteUsers_Click(object sender, EventArgs e)
        {
            User user = new User();
            string path = @"c:\test\users.txt";
            if (user.DeleteFile(path))
            {
                MessageBox.Show("File deleted");
            }
            else
            {
                MessageBox.Show("File Not deleted");
            }
        }

        private void btnCountUsers_Click(object sender, EventArgs e)
        {
            User user = new User();
            string path = @"c:\test\users.txt";
            string fileContect = user.ReadFile(path);
            int lines = user.ReadLines(path);

            MessageBox.Show(fileContect);

            MessageBox.Show("total registered  :"+ lines);
        }
    }
}

