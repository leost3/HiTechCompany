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

namespace HiTech
{
    public partial class SalesManager : Form
    {
        public SalesManager()
        {
            InitializeComponent();
        }

        public void ClearUserTxt()
        {
            txtCustomerId.Text = "";
            txtCFn.Text = "";
            txtCLn.Text = "";
            txtCity.Text = "";
            txtZipCode.Text = "";
            txtPhoneNumber.Text = "";
            txtFaxNum.Text = "";
            txtCreditLimit.Text = "";
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (txtCFn.Text == "" || txtCLn.Text == "" || txtCity.Text == "" 
                || txtZipCode.Text == "" || txtPhoneNumber.Text == "" || txtFaxNum.Text == "" || txtCreditLimit.Text == "")
            {
                MessageBox.Show("Can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //create object
                Customer customer = new Customer();
                //fill the object with textbox input
                customer.CustomerId = Convert.ToInt32(txtCustomerId.Text);
                customer.FirstName = txtCFn.Text;
                customer.LastName = txtCLn.Text;
                customer.City = txtCity.Text;
                customer.ZipCode = txtZipCode.Text;
                customer.PhoneNumber = Convert.ToInt32(txtPhoneNumber.Text);
                customer.FaxNumber = Convert.ToInt32(txtFaxNum.Text);
                customer.CreditLimit = Convert.ToInt32(txtCreditLimit.Text);
                //call function to save employee in database
                if (customer.SaveCustomer(customer)) //if(emp.SaveEmployee(emp)==true)
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

        private void btnShowCustomers_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            var data = customer.ListCustomer();
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

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.CustomerId = Convert.ToInt32(txtCustomerId.Text);
            if (customer.DeleteUsers(customer.CustomerId))
            {
                MessageBox.Show("User is deleted");
            }else
            {
                MessageBox.Show("Unable to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearUserTxt();

        }

        private void SalesManager_Load(object sender, EventArgs e)
        {
            //listView1.FullRowSelect = true;
            listView1.FullRowSelect = Enabled;
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                txtCustomerId.Text = item.SubItems[0].Text;
                txtCFn.Text = item.SubItems[1].Text;
                txtCLn.Text = item.SubItems[2].Text;
                txtCity.Text = item.SubItems[3].Text;
                txtZipCode.Text = item.SubItems[4].Text;
                txtPhoneNumber.Text = item.SubItems[5].Text;
                txtFaxNum.Text = item.SubItems[6].Text;
                txtCreditLimit.Text = item.SubItems[7].Text;

            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (txtCFn.Text == "" || txtCLn.Text == "" || txtCity.Text == ""
                || txtZipCode.Text == "" || txtPhoneNumber.Text == "" || txtFaxNum.Text == "" || txtCreditLimit.Text == "")
            {
                MessageBox.Show("Can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Customer customer = new Customer();

                customer.CustomerId = Convert.ToInt32(txtCustomerId.Text);
                customer.FirstName = txtCFn.Text;
                customer.LastName = txtCLn.Text;
                customer.City = txtCity.Text;
                customer.ZipCode = txtZipCode.Text;
                customer.PhoneNumber = Convert.ToInt32(txtPhoneNumber.Text);
                customer.FaxNumber = Convert.ToInt32(txtFaxNum.Text);
                customer.CreditLimit = Convert.ToInt32(txtCreditLimit.Text);

                if (customer.updateUsers(customer))
                {
                    MessageBox.Show("Employee Update correctly");
                }
                else
                    MessageBox.Show("Not Update!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearUserTxt();
                //txtEmployeeId.Enabled = false;
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.CustomerId = Convert.ToInt32(txtSearchCustId.Text);
            string customerName = customer.SearchCustomer(customer);
            MessageBox.Show("Customer Name is :" + customerName);
        }
    }
}
