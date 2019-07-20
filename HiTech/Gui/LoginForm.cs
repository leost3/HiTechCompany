using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HiTech.Business;


namespace HiTech.Gui
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" || txtUser.Text == "")
            {
                MessageBox.Show("Can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                User user = new User();
                user.Username = txtUser.Text;
                user.Password = txtPassword.Text;
                int id = user.Login(user);
                if (id > 0)
                {
                    
                    if (id == 1)
                    {
                        MessageBox.Show("Mis Manager");
                        MisManagerForm mainform = new MisManagerForm();
                        this.Hide();
                        mainform.Show();
                    }
                    else if (id == 2)
                    {
                        MessageBox.Show("Sales Manager");
                        SalesManager mainform = new SalesManager();
                        this.Hide();
                        mainform.Show();
                    }
                    else if (id == 3)
                    {
                        MessageBox.Show("Orders Clerk");
                        OrdersClark mainform = new OrdersClark();
                        this.Hide();
                        mainform.Show();
                    }
     
                    else if (id == 4)
                    {
                        MessageBox.Show("Accountant");
                        Accountant mainform = new Accountant();
                        this.Hide();
                        mainform.Show();

                    }
                    else if (id == 5)
                    {
                        MessageBox.Show("Iventory Controller");
                        Inventory_Controller mainform = new Inventory_Controller();
                        this.Hide();
                        mainform.Show();

                    }

                    //MainForm mainform = new MainForm();
                    //this.Hide();
                    //mainform.Show();
                }
                else
                {
                    MessageBox.Show("Can not Login, contact with administrator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
