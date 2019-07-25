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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            

            HiTech_DBEntities4 hiTechEntity = new HiTech_DBEntities4();

            Order order = new Order();
            //Customer ID
            //Book Name or Book ISBN?
            // Total
            // Ordered by

            order.Customer_ID = Convert.ToInt32(txtCustomerrId.Text);
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




    }
}
