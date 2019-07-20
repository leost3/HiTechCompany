using HiTech.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiTech.Gui
{
    public partial class MisManagerForm : Form
    {
        public MisManagerForm()
        {
            InitializeComponent();
        }

        public void ClearUserTxt()
        {
            txtUserId.Text = "";
            txtFn.Text = "";
            txtLn.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtRoleID.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtUserId.Text == "" || txtFn.Text == "" || txtLn.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" || txtRoleID.Text == "" )
            {
                MessageBox.Show("Can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //create object
                User user = new User();
                //fill the object with textbox input
                //user.UserId = Convert.ToInt32(txtUserId.Text);
                user.FirstName = txtFn.Text;
                user.LastName = txtLn.Text;
                user.Username = txtUsername.Text;
                user.Password = txtPassword.Text;
                user.RoleId = Convert.ToInt32(txtRoleID.Text);
                //call function to save employee in database
                if (user.Save(user)) //if(emp.SaveEmployee(emp)==true)
                    MessageBox.Show("Employee Save correctly");
                else
                    MessageBox.Show("Employee can not save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearUserTxt();
            }

        }


































        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
