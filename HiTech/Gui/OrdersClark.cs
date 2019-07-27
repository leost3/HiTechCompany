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
    public partial class OrdersClark : Form
    {
        public OrdersClark()
        {
            InitializeComponent();
        }

        private void clearText()
        {
            txtCustomerrId.Text = String.Empty;
            txtISBN.Text = "";
            txtQte.Text = "";
            txtOrderId.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            

            HiTech_DBEntities4 hiTechEntity = new HiTech_DBEntities4();

            Order order = new Order();
            int customerId = Convert.ToInt32(txtCustomerrId.Text);

            Order order1 = hiTechEntity.Orders.Find(customerId);

            if (order1 != null)
            {
                MessageBox.Show("Duplicated Employee Id", "Error");
                clearText();
                return;
            }

            order.Customer_ID = customerId;
            order.ISBN = Convert.ToInt32(txtISBN.Text);
            Book book = hiTechEntity.Books.Find(order.ISBN); // returns line from referred book table
            order.Qte = Convert.ToInt32(txtQte.Text);
            order.total = book.UnitPrice * order.Qte;
            order.OrderedBy = Convert.ToString(comboBoxOrderedBy.SelectedItem);

            hiTechEntity.Orders.Add(order);
            hiTechEntity.SaveChanges();
            MessageBox.Show("ORder saved sucessfully");

            string bookName = book.Title;



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            HiTech_DBEntities4 HiTechEntitity = new HiTech_DBEntities4();
            Order order = new Order();
            int orderId = Convert.ToInt32(txtOrderId.Text);
                order = HiTechEntitity.Orders.Find(orderId);
            if (order == null)
            {
                MessageBox.Show("Order does not exists", "Error");
                //Clear function
                return;
            }
            order.Customer_ID = Convert.ToInt32(txtCustomerrId.Text);
            order.ISBN = Convert.ToInt32(txtISBN.Text);
            order.OrderedBy = Convert.ToString(comboBoxOrderedBy.SelectedItem);
            order.Qte = Convert.ToInt32(txtQte.Text);
            Book book = HiTechEntitity.Books.Find(order.ISBN);
            order.total = order.Qte * book.UnitPrice;
            HiTechEntitity.SaveChanges();
            MessageBox.Show("Order updated sucessfully");
            clearText();
        }

        private void btnShowBooks_Click(object sender, EventArgs e)
        {
            HiTech_DBEntities4 HiTechEntitity = new HiTech_DBEntities4();

            var orderList = from order in HiTechEntitity.Orders
                            select order;

            listView1.Items.Clear();
            foreach (var order in orderList)
            {
                //order.Customer_ID
                ListViewItem item = new ListViewItem(Convert.ToString(order.Customer_ID));
                item.SubItems.Add(Convert.ToString(order.order_ID));
                item.SubItems.Add(Convert.ToString(order.ISBN));
                item.SubItems.Add(Convert.ToString(order.Qte));
                item.SubItems.Add(order.OrderedBy);
                item.SubItems.Add(Convert.ToString(order.total));
                listView1.Items.Add(item);
            }
        }

        private void OrdersClark_Load(object sender, EventArgs e)
        {
            listView1.FullRowSelect = true;
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                txtCustomerrId.Text = item.SubItems[0].Text.Trim();
                txtOrderId.Text = item.SubItems[1].Text.Trim();  
                txtISBN.Text = item.SubItems[2].Text.Trim();  
                comboBoxOrderedBy.Text = item.SubItems[4].Text.Trim();
                txtQte.Text = item.SubItems[3].Text.Trim();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            HiTech_DBEntities4 HiTechEntitity = new HiTech_DBEntities4();
            Order order = new Order();
            int orderId = Convert.ToInt32(txtOrderId.Text);
            order = HiTechEntitity.Orders.Find(orderId);
            if (order == null)
            {
                MessageBox.Show("Order does not exists", "Error");
                //Clear function
                return;
            }
            HiTechEntitity.Orders.Remove(order);
            HiTechEntitity.SaveChanges();
            MessageBox.Show("Order removed successfully");
            clearText();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            HiTech_DBEntities4 HiTechEntitity = new HiTech_DBEntities4();
            int customerId = Convert.ToInt32(txtSearchOrderByCID.Text);
            var orderList = HiTechEntitity.Orders.Where(x => x.Customer_ID == customerId).ToList<Order>();
            if (orderList.Count != 0)
            {
                listView1.Items.Clear();
                foreach (var order in orderList)
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(order.Customer_ID));
                    item.SubItems.Add(Convert.ToString(order.order_ID));
                    item.SubItems.Add(Convert.ToString(order.ISBN));
                    item.SubItems.Add(Convert.ToString(order.Qte));
                    item.SubItems.Add(order.OrderedBy);
                    item.SubItems.Add(Convert.ToString(order.total));
                    listView1.Items.Add(item);
                }
            }else
            {
                MessageBox.Show("Custmer does not have orders", "Error");
            }
        }

        
        // WHy it doesnt go to the else??
        private void btnSearchOrder_Click_1(object sender, EventArgs e)
        {
            HiTech_DBEntities4 HiTechEntitity = new HiTech_DBEntities4();

            int orderId = Convert.ToInt32(txtSearchOrderByOrderID.Text);

            var orderList = from order in HiTechEntitity.Orders
                            where order.order_ID == orderId
                            select order
                            ;

            listView1.Items.Clear();
            if (orderList !=  null)
            {
                foreach (var order in orderList)
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(order.Customer_ID));
                    item.SubItems.Add(Convert.ToString(order.order_ID));
                    item.SubItems.Add(Convert.ToString(order.ISBN));
                    item.SubItems.Add(Convert.ToString(order.Qte));
                    item.SubItems.Add(order.OrderedBy);
                    item.SubItems.Add(Convert.ToString(order.total));
                    listView1.Items.Add(item);
                }
            }
            if (orderList == null)
            {
                MessageBox.Show("Order does not exist", "Error");
            }
            
        }
    }
}
