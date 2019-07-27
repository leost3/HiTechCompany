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
    public partial class Inventory_Controller : Form
    {
        public Inventory_Controller()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            HiTech_DBEntities4 HiTechEntity = new HiTech_DBEntities4();
            Book book1 = new Book();

            book1.ISBN = Convert.ToInt32(txtBookISBN.Text.Trim());
            book1.Title = txtBookTitle.Text;
            book1.UnitPrice = Convert.ToDouble(txtPrice.Text);
            book1.YearPublished = Convert.ToInt32(txtYear.Text);
            book1.QOH = Convert.ToInt32(txtQOH.Text);
            book1.Category = txtCategory.Text;
            book1.Auhtor_Id = Convert.ToInt32(txtAuthorID.Text);
            book1.Publisher_Id = Convert.ToInt32(txtPublisherID.Text);
            HiTechEntity.Books.Add(book1);
            HiTechEntity.SaveChanges();
            MessageBox.Show("Book saved sucessfully");



        }
    }
}
