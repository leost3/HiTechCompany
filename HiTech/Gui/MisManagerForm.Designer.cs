namespace HiTech.Gui
{
    partial class MisManagerForm
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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnListEmps = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtFn = new System.Windows.Forms.TextBox();
            this.Author = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRoleID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader3});
            this.listView1.Location = new System.Drawing.Point(414, 69);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(697, 413);
            this.listView1.TabIndex = 29;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "UserID";
            this.columnHeader4.Width = 105;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 3;
            this.columnHeader1.Text = "Username";
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 4;
            this.columnHeader2.Text = "Password";
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 1;
            this.columnHeader5.Text = "First Name";
            this.columnHeader5.Width = 187;
            // 
            // columnHeader6
            // 
            this.columnHeader6.DisplayIndex = 2;
            this.columnHeader6.Text = "Last Name";
            this.columnHeader6.Width = 181;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "RoleID";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(40, 372);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnListEmps
            // 
            this.btnListEmps.Location = new System.Drawing.Point(40, 459);
            this.btnListEmps.Name = "btnListEmps";
            this.btnListEmps.Size = new System.Drawing.Size(75, 23);
            this.btnListEmps.TabIndex = 27;
            this.btnListEmps.Text = "List";
            this.btnListEmps.UseVisualStyleBackColor = true;
            this.btnListEmps.Click += new System.EventHandler(this.btnListEmps_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(40, 430);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(38, 401);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(184, 429);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFn
            // 
            this.txtFn.Location = new System.Drawing.Point(40, 117);
            this.txtFn.Name = "txtFn";
            this.txtFn.Size = new System.Drawing.Size(313, 22);
            this.txtFn.TabIndex = 23;
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Location = new System.Drawing.Point(37, 97);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(76, 17);
            this.Author.TabIndex = 22;
            this.Author.Text = "First Name";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(40, 64);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(313, 22);
            this.txtUserId.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "User ID";
            // 
            // txtLn
            // 
            this.txtLn.Location = new System.Drawing.Point(40, 169);
            this.txtLn.Name = "txtLn";
            this.txtLn.Size = new System.Drawing.Size(313, 22);
            this.txtLn.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(121, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 31);
            this.label3.TabIndex = 32;
            this.label3.Text = "MIS Manager";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(165, 401);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(112, 22);
            this.txtSearch.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Search User by ID";
            // 
            // txtRoleID
            // 
            this.txtRoleID.Location = new System.Drawing.Point(40, 226);
            this.txtRoleID.Name = "txtRoleID";
            this.txtRoleID.Size = new System.Drawing.Size(313, 22);
            this.txtRoleID.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 52;
            this.label10.Text = "Role ID";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(40, 281);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(313, 22);
            this.txtUsername.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 261);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 17);
            this.label11.TabIndex = 54;
            this.label11.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(40, 334);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(313, 22);
            this.txtPassword.TabIndex = 57;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 314);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 17);
            this.label12.TabIndex = 56;
            this.label12.Text = "Password";
            // 
            // MisManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 613);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtRoleID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnListEmps);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtFn);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.label1);
            this.Name = "MisManagerForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MisManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnListEmps;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtFn;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRoleID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}