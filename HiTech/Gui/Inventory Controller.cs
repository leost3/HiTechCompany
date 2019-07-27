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

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                txtBookISBN.Text = item.SubItems[0].Text;
                txtBookTitle.Text = item.SubItems[1].Text;
                txtPrice.Text = item.SubItems[2].Text;
                txtYear.Text = item.SubItems[3].Text;
                txtQOH.Text = item.SubItems[4].Text;
                txtCategory.Text = item.SubItems[5].Text;
                txtAuthorID.Text = item.SubItems[6].Text;
                txtPublisherID.Text = item.SubItems[7].Text;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            HiTech_DBEntities4 HiTechEntity = new HiTech_DBEntities4();

            int ISBN = Convert.ToInt32(txtBookISBN.Text);
            var book = HiTechEntity.Books.Find(ISBN);
            if (book == null)
            {
                MessageBox.Show("Book does not exist", "Error");
                return;
            }
            HiTechEntity.Books.Remove(book);
            HiTechEntity.SaveChanges();

            MessageBox.Show("Book removed sucessfully");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            HiTech_DBEntities4 HiTechEntity = new HiTech_DBEntities4();

            Book book = new Book();

            int ISBN = Convert.ToInt32(txtBookISBN.Text);
            book = HiTechEntity.Books.Find(ISBN);

            if (book == null)
            {
                MessageBox.Show("Book does not exist", "Error");
                return;
            }

            book.ISBN = ISBN;
            book.Title = txtBookTitle.Text;
            book.UnitPrice = Convert.ToDouble(txtPrice.Text);
            book.YearPublished = Convert.ToInt32(txtYear.Text);
            book.QOH = Convert.ToInt32(txtQOH.Text);
            book.Category = txtCategory.Text;
            book.Auhtor_Id = Convert.ToInt32(txtAuthorID.Text);
            book.Publisher_Id = Convert.ToInt32(txtPublisherID.Text);

            HiTechEntity.SaveChanges();

            MessageBox.Show("Book saved sucessfully");
            clearText();
        }
       

        private void btnSearch_Click(object sender, EventArgs e)
        {
            HiTech_DBEntities4 HiTechEntity = new HiTech_DBEntities4();

            int ISBN = Convert.ToInt32(txtSearch.Text);
            var book = HiTechEntity.Books.Find(ISBN);

            if (book == null)
            {
                MessageBox.Show("Book does not exist", "Error");
                return;
            }

            var myBookList = from book1 in HiTechEntity.Books
                           where book1.ISBN == ISBN
                           select book1;
            listView1.Items.Clear();

            foreach (var book1 in myBookList)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(book1.ISBN));
                item.SubItems.Add(book1.Title);
                item.SubItems.Add(Convert.ToString(book1.UnitPrice));
                item.SubItems.Add(Convert.ToString(book1.YearPublished));
                item.SubItems.Add(Convert.ToString(book1.QOH));
                item.SubItems.Add(book1.Category);
                item.SubItems.Add(Convert.ToString(book1.Auhtor_Id));
                item.SubItems.Add(Convert.ToString(book1.Publisher_Id));
                listView1.Items.Add(item);
            }
        }
    }
}
