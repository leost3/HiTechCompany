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
    public partial class Accountant : Form
    {
        public Accountant()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            HiTech_DBEntities4 HiTechEntitity = new HiTech_DBEntities4();

            var totals = from order in HiTechEntitity.Orders
                            group order by order.Customer_ID into g
                            select g.Sum(p => p.total);

            int customerId = Convert.ToInt32(txtCustID.Text);

            Customer customer = new Customer();
            customer.CustomerId = customerId;
            string customerName = customer.SearchCustomer(customer);

            listView1.Items.Clear();
            foreach (var total in totals)
            {

                ListViewItem item = new ListViewItem(Convert.ToString(customerName));
                item.SubItems.Add(Convert.ToString("CAD " + total));
                item.SubItems.Add(Convert.ToString("CAD " + total * 0.15));
                item.SubItems.Add(Convert.ToString("CAD " + (total + total*0.15)));

                listView1.Items.Add(item);
            }
        }
    }
    
}
