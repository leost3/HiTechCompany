namespace HiTech
{
    partial class Accountant
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
            this.SubTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Taxes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShowBooks = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.SubTotal,
            this.Taxes,
            this.Total});
            this.listView1.Location = new System.Drawing.Point(12, 155);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(784, 283);
            this.listView1.TabIndex = 58;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Customer Full Name";
            this.columnHeader4.Width = 105;
            // 
            // SubTotal
            // 
            this.SubTotal.Text = "SubTotal";
            this.SubTotal.Width = 187;
            // 
            // Taxes
            // 
            this.Taxes.Text = "Taxes";
            this.Taxes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Taxes.Width = 181;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(288, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 31);
            this.label3.TabIndex = 57;
            this.label3.Text = "Accountant";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(146, 115);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 54;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnShowBooks
            // 
            this.btnShowBooks.Location = new System.Drawing.Point(575, 115);
            this.btnShowBooks.Name = "btnShowBooks";
            this.btnShowBooks.Size = new System.Drawing.Size(75, 23);
            this.btnShowBooks.TabIndex = 53;
            this.btnShowBooks.Text = "List";
            this.btnShowBooks.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(345, 115);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 52;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(242, 115);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 51;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(345, 74);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 23);
            this.btnSearch.TabIndex = 50;
            this.btnSearch.Text = "See Invoices";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(233, 75);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(84, 22);
            this.txtCustID.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Customer Id";
            // 
            // Total
            // 
            this.Total.Text = "Total";
            // 
            // Accountant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnShowBooks);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCustID);
            this.Controls.Add(this.label1);
            this.Name = "Accountant";
            this.Text = "Accountant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader SubTotal;
        private System.Windows.Forms.ColumnHeader Taxes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShowBooks;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Total;
    }
}