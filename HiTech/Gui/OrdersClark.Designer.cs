namespace HiTech
{
    partial class OrdersClark
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.txtQte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShowBooks = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearchByCID = new System.Windows.Forms.Button();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.Author = new System.Windows.Forms.Label();
            this.txtCustomerrId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchOrderByCID = new System.Windows.Forms.TextBox();
            this.comboBoxOrderedBy = new System.Windows.Forms.ComboBox();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearchOrder = new System.Windows.Forms.Button();
            this.txtSearchOrderByOrderID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader3,
            this.columnHeader2,
            this.columnHeader1});
            this.listView1.Location = new System.Drawing.Point(56, 300);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1102, 215);
            this.listView1.TabIndex = 58;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Customer ID";
            this.columnHeader4.Width = 105;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Order Id";
            this.columnHeader5.Width = 187;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Book ISBN";
            this.columnHeader6.Width = 181;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 5;
            this.columnHeader3.Text = "Qde";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ordered By";
            this.columnHeader2.Width = 153;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 3;
            this.columnHeader1.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(290, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 31);
            this.label3.TabIndex = 57;
            this.label3.Text = "Orders Clerk";
            // 
            // txtQte
            // 
            this.txtQte.Location = new System.Drawing.Point(56, 184);
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(58, 22);
            this.txtQte.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 55;
            this.label2.Text = "Quantity";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(184, 271);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 54;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnShowBooks
            // 
            this.btnShowBooks.Location = new System.Drawing.Point(416, 271);
            this.btnShowBooks.Name = "btnShowBooks";
            this.btnShowBooks.Size = new System.Drawing.Size(75, 23);
            this.btnShowBooks.TabIndex = 53;
            this.btnShowBooks.Text = "List";
            this.btnShowBooks.UseVisualStyleBackColor = true;
            this.btnShowBooks.Click += new System.EventHandler(this.btnShowBooks_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(473, 68);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 23);
            this.btnDelete.TabIndex = 52;
            this.btnDelete.Text = "Delete order";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(296, 271);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 51;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearchByCID
            // 
            this.btnSearchByCID.Location = new System.Drawing.Point(889, 106);
            this.btnSearchByCID.Name = "btnSearchByCID";
            this.btnSearchByCID.Size = new System.Drawing.Size(75, 23);
            this.btnSearchByCID.TabIndex = 50;
            this.btnSearchByCID.Text = "Search";
            this.btnSearchByCID.UseVisualStyleBackColor = true;
            this.btnSearchByCID.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(56, 129);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(143, 22);
            this.txtISBN.TabIndex = 49;
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Location = new System.Drawing.Point(53, 109);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(75, 17);
            this.Author.TabIndex = 48;
            this.Author.Text = "Book ISBN";
            // 
            // txtCustomerrId
            // 
            this.txtCustomerrId.Location = new System.Drawing.Point(56, 69);
            this.txtCustomerrId.Name = "txtCustomerrId";
            this.txtCustomerrId.Size = new System.Drawing.Size(143, 22);
            this.txtCustomerrId.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Customer ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 59;
            this.label4.Text = "Ordered by";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(886, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 17);
            this.label5.TabIndex = 46;
            this.label5.Text = "Search Customer\'s Orders";
            // 
            // txtSearchOrderByCID
            // 
            this.txtSearchOrderByCID.Location = new System.Drawing.Point(889, 69);
            this.txtSearchOrderByCID.Name = "txtSearchOrderByCID";
            this.txtSearchOrderByCID.Size = new System.Drawing.Size(143, 22);
            this.txtSearchOrderByCID.TabIndex = 47;
            // 
            // comboBoxOrderedBy
            // 
            this.comboBoxOrderedBy.FormattingEnabled = true;
            this.comboBoxOrderedBy.Items.AddRange(new object[] {
            "Phone",
            "Fax",
            "Email"});
            this.comboBoxOrderedBy.Location = new System.Drawing.Point(56, 245);
            this.comboBoxOrderedBy.Name = "comboBoxOrderedBy";
            this.comboBoxOrderedBy.Size = new System.Drawing.Size(121, 24);
            this.comboBoxOrderedBy.TabIndex = 61;
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(315, 69);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(143, 22);
            this.txtOrderId.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 62;
            this.label6.Text = "Order ID";
            // 
            // btnSearchOrder
            // 
            this.btnSearchOrder.Location = new System.Drawing.Point(889, 233);
            this.btnSearchOrder.Name = "btnSearchOrder";
            this.btnSearchOrder.Size = new System.Drawing.Size(75, 23);
            this.btnSearchOrder.TabIndex = 66;
            this.btnSearchOrder.Text = "Search";
            this.btnSearchOrder.UseVisualStyleBackColor = true;
            this.btnSearchOrder.Click += new System.EventHandler(this.btnSearchOrder_Click_1);
            // 
            // txtSearchOrderByOrderID
            // 
            this.txtSearchOrderByOrderID.Location = new System.Drawing.Point(889, 196);
            this.txtSearchOrderByOrderID.Name = "txtSearchOrderByOrderID";
            this.txtSearchOrderByOrderID.Size = new System.Drawing.Size(143, 22);
            this.txtSearchOrderByOrderID.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(886, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 64;
            this.label7.Text = "Search order";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(791, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 67;
            this.label8.Text = "Customer ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(791, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 68;
            this.label9.Text = "Order ID";
            // 
            // OrdersClark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 527);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSearchOrder);
            this.Controls.Add(this.txtSearchOrderByOrderID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxOrderedBy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnShowBooks);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearchByCID);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.txtSearchOrderByCID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCustomerrId);
            this.Controls.Add(this.label1);
            this.Name = "OrdersClark";
            this.Text = "OrdersClark";
            this.Load += new System.EventHandler(this.OrdersClark_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShowBooks;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearchByCID;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.TextBox txtCustomerrId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearchOrderByCID;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox comboBoxOrderedBy;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearchOrder;
        private System.Windows.Forms.TextBox txtSearchOrderByOrderID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}