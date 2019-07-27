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

        private void clearText()
        {
            txtBookISBN.Text = String.Empty;
            txtBookTitle.Text = "";
            txtPrice.Text = "";
            txtYear.Text = "";
            txtQOH.Text = "";
            txtCategory.Text = "";
            txtAuthorID.Text = "";
            txtPublisherID.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            HiTech_DBEntities4 HiTechEntity = new HiTech_DBEntities4();
            Book book1 = new Book();
            int bookIsbn = Convert.ToInt32(txtBookISBN.Text);
            Book book2 = HiTechEntity.Books.Find(bookIsbn);
            if (book2 != null)
            {
                MessageBox.Show("Duplicated Employee Id", "Error");
                clearText();
                return;
            }

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
            clearText();
        }

        private void btnShowBooks_Click(object sender, EventArgs e)
        {
            HiTech_DBEntities4 HiTechEntity = new HiTech_DBEntities4();


            var booksList = from book in HiTechEntity.Books
                            select book;

            if (booksList != null)
            {
                listView1.Items.Clear();

                foreach (var book in booksList)
                {

                    ListViewItem item = new ListViewItem(Convert.ToString(book.ISBN));
                    item.SubItems.Add(book.Title);
                    item.SubItems.Add(Convert.ToString(book.UnitPrice));
                    item.SubItems.Add(Convert.ToString(book.YearPublished));
                    item.SubItems.Add(Convert.ToString(book.QOH));
                    item.SubItems.Add(book.Category);
                    item.SubItems.Add(Convert.ToString(book.Auhtor_Id));
                    item.SubItems.Add(Convert.ToString(book.Publisher_Id));
                    listView1.Items.Add(item);
                }
            }else
            {
                MessageBox.Show("No books listed!");
            }

        }

        private void Inventory_Controller_Load(object sender, EventArgs e)
        {
            listView1.FullRowSelect = true;
        }

    }
}
