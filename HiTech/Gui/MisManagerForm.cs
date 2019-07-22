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
                user.UserId = Convert.ToInt32(txtUserId.Text);
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

        private void populateListView(DataTable data)
        {
            foreach (DataRow row in data.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < data.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                listView1.Items.Add(item);
            }
        }


        private void btnListEmps_Click(object sender, EventArgs e)
        {
            User user = new User();
            var data = user.listUsers();
            if (listView1.Items.Count > 0)
            {
                listView1.Items.Clear();
                populateListView(data);
            }
            else
            {
                populateListView(data);
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                txtUserId.Text = item.SubItems[0].Text;
                txtUsername.Text = item.SubItems[1].Text;
                txtPassword.Text = item.SubItems[2].Text;
                txtFn.Text = item.SubItems[3].Text;
                txtLn.Text = item.SubItems[4].Text;
                txtRoleID.Text = item.SubItems[5].Text;

            }

        }

        private void MisManagerForm_Load(object sender, EventArgs e)
        {
            listView1.FullRowSelect = true;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtUserId.Text == "" || txtFn.Text == "" || txtLn.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" || txtRoleID.Text == "")
            {
                MessageBox.Show("Employee/User can not be empty. You should Enter data!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                User user = new User();
                user.UserId = Convert.ToInt32(txtUserId.Text);
                user.FirstName = txtFn.Text;
                user.LastName = txtLn.Text;
                user.Username = txtUsername.Text;
                user.Password = txtPassword.Text;
                user.RoleId = Convert.ToInt32(txtRoleID.Text);

                if (user.Delete(user.UserId))
                {
                    MessageBox.Show("User is deleted");
                }
                else
                {
                    MessageBox.Show("Unable to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ClearUserTxt();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUserId.Text == "" || txtFn.Text == "" || txtLn.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" || txtRoleID.Text == "")
            {
                MessageBox.Show("Can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                User user = new User();

                user.UserId = Convert.ToInt32(txtUserId.Text);
                user.FirstName = txtFn.Text;
                user.LastName = txtLn.Text;
                user.Username = txtUsername.Text;
                user.Password = txtPassword.Text;
                user.RoleId = Convert.ToInt32(txtRoleID.Text);

                if (user.UpdateUsers(user))
                {
                    MessageBox.Show("Employee Update correctly");
                }
                else
                    MessageBox.Show("Not Update!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearUserTxt();
                //txtEmployeeId.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //bool found = true;
                User user = new User();
                user.UserId = Convert.ToInt32(txtSearch.Text);
                string firstName = user.SearchUser(user);

                
                    MessageBox.Show("Employee / user FirstName is: " + firstName);
            }
        }
    }
    
}
