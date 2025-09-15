namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.groupBoxBooks = new System.Windows.Forms.GroupBox();
            this.gridBooks = new System.Windows.Forms.DataGridView();
            this.labelTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.groupBoxUsers = new System.Windows.Forms.GroupBox();
            this.gridUsers = new System.Windows.Forms.DataGridView();
            this.labelUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.labelUserEmail = new System.Windows.Forms.Label();
            this.txtUserEmail = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.groupBoxLoans = new System.Windows.Forms.GroupBox();
            this.gridLoans = new System.Windows.Forms.DataGridView();
            this.labelLoanBook = new System.Windows.Forms.Label();
            this.cboLoanBook = new System.Windows.Forms.ComboBox();
            this.labelLoanUser = new System.Windows.Forms.Label();
            this.cboLoanUser = new System.Windows.Forms.ComboBox();
            this.btnCreateLoan = new System.Windows.Forms.Button();
            this.btnReturnLoan = new System.Windows.Forms.Button();
            this.chartBooks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartUsers = new System.Windows.Forms.DataVisualization.Charting.Chart();

            this.groupBoxBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBooks)).BeginInit();
            this.groupBoxUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).BeginInit();
            this.groupBoxLoans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLoans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxBooks
            // 
            this.groupBoxBooks.Controls.Add(this.gridBooks);
            this.groupBoxBooks.Controls.Add(this.labelTitle);
            this.groupBoxBooks.Controls.Add(this.txtTitle);
            this.groupBoxBooks.Controls.Add(this.labelAuthor);
            this.groupBoxBooks.Controls.Add(this.txtAuthor);
            this.groupBoxBooks.Controls.Add(this.labelYear);
            this.groupBoxBooks.Controls.Add(this.txtYear);
            this.groupBoxBooks.Controls.Add(this.btnAddBook);
            this.groupBoxBooks.Controls.Add(this.btnEditBook);
            this.groupBoxBooks.Controls.Add(this.btnDeleteBook);
            this.groupBoxBooks.Location = new System.Drawing.Point(12, 12);
            this.groupBoxBooks.Name = "groupBoxBooks";
            this.groupBoxBooks.Size = new System.Drawing.Size(500, 250);
            this.groupBoxBooks.TabIndex = 0;
            this.groupBoxBooks.TabStop = false;
            this.groupBoxBooks.Text = "📚 Administrar Libros";
            // 
            // gridBooks
            // 
            this.gridBooks.ColumnHeadersHeight = 34;
            this.gridBooks.Location = new System.Drawing.Point(10, 20);
            this.gridBooks.Name = "gridBooks";
            this.gridBooks.RowHeadersWidth = 62;
            this.gridBooks.Size = new System.Drawing.Size(480, 120);
            this.gridBooks.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(10, 150);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(47, 20);
            this.labelTitle.Text = "Título";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(60, 147);
            this.txtTitle.Size = new System.Drawing.Size(150, 26);
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(220, 150);
            this.labelAuthor.Size = new System.Drawing.Size(48, 20);
            this.labelAuthor.Text = "Autor";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(270, 147);
            this.txtAuthor.Size = new System.Drawing.Size(150, 26);
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(10, 180);
            this.labelYear.Size = new System.Drawing.Size(38, 20);
            this.labelYear.Text = "Año";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(60, 177);
            this.txtYear.Size = new System.Drawing.Size(100, 26);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(10, 210);
            this.btnAddBook.Size = new System.Drawing.Size(75, 34);
            this.btnAddBook.Text = "Agregar";
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.Location = new System.Drawing.Point(90, 210);
            this.btnEditBook.Size = new System.Drawing.Size(75, 34);
            this.btnEditBook.Text = "Editar";
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(170, 210);
            this.btnDeleteBook.Size = new System.Drawing.Size(75, 34);
            this.btnDeleteBook.Text = "Eliminar";
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // groupBoxUsers
            // 
            this.groupBoxUsers.Controls.Add(this.gridUsers);
            this.groupBoxUsers.Controls.Add(this.labelUserName);
            this.groupBoxUsers.Controls.Add(this.txtUserName);
            this.groupBoxUsers.Controls.Add(this.labelUserEmail);
            this.groupBoxUsers.Controls.Add(this.txtUserEmail);
            this.groupBoxUsers.Controls.Add(this.btnAddUser);
            this.groupBoxUsers.Controls.Add(this.btnEditUser);
            this.groupBoxUsers.Controls.Add(this.btnDeleteUser);
            this.groupBoxUsers.Location = new System.Drawing.Point(530, 12);
            this.groupBoxUsers.Size = new System.Drawing.Size(500, 250);
            this.groupBoxUsers.Text = "👤 Administrar Usuarios";
            // 
            // gridUsers
            // 
            this.gridUsers.ColumnHeadersHeight = 34;
            this.gridUsers.Location = new System.Drawing.Point(10, 20);
            this.gridUsers.Size = new System.Drawing.Size(480, 120);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(11, 150);
            this.labelUserName.Size = new System.Drawing.Size(65, 20);
            this.labelUserName.Text = "Nombre";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(74, 147);
            this.txtUserName.Size = new System.Drawing.Size(150, 26);
            // 
            // labelUserEmail
            // 
            this.labelUserEmail.AutoSize = true;
            this.labelUserEmail.Location = new System.Drawing.Point(232, 150);
            this.labelUserEmail.Size = new System.Drawing.Size(57, 20);
            this.labelUserEmail.Text = "Correo";
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.Location = new System.Drawing.Point(290, 147);
            this.txtUserEmail.Size = new System.Drawing.Size(200, 26);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(10, 210);
            this.btnAddUser.Size = new System.Drawing.Size(75, 34);
            this.btnAddUser.Text = "Agregar";
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(90, 210);
            this.btnEditUser.Size = new System.Drawing.Size(75, 34);
            this.btnEditUser.Text = "Editar";
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(170, 210);
            this.btnDeleteUser.Size = new System.Drawing.Size(75, 34);
            this.btnDeleteUser.Text = "Eliminar";
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // groupBoxLoans
            // 
            this.groupBoxLoans.Controls.Add(this.gridLoans);
            this.groupBoxLoans.Controls.Add(this.labelLoanBook);
            this.groupBoxLoans.Controls.Add(this.cboLoanBook);
            this.groupBoxLoans.Controls.Add(this.labelLoanUser);
            this.groupBoxLoans.Controls.Add(this.cboLoanUser);
            this.groupBoxLoans.Controls.Add(this.btnCreateLoan);
            this.groupBoxLoans.Controls.Add(this.btnReturnLoan);
            this.groupBoxLoans.Location = new System.Drawing.Point(12, 270);
            this.groupBoxLoans.Size = new System.Drawing.Size(1018, 250);
            this.groupBoxLoans.Text = "📖 Gestionar Préstamos";
            // 
            // gridLoans
            // 
            this.gridLoans.ColumnHeadersHeight = 34;
            this.gridLoans.Location = new System.Drawing.Point(10, 20);
            this.gridLoans.Size = new System.Drawing.Size(530, 150);
            // 
            // labelLoanBook
            // 
            this.labelLoanBook.AutoSize = true;
            this.labelLoanBook.Location = new System.Drawing.Point(10, 190);
            this.labelLoanBook.Text = "Libro";
            // 
            // cboLoanBook
            // 
            this.cboLoanBook.Location = new System.Drawing.Point(60, 187);
            this.cboLoanBook.Size = new System.Drawing.Size(200, 28);
            // 
            // labelLoanUser
            // 
            this.labelLoanUser.AutoSize = true;
            this.labelLoanUser.Location = new System.Drawing.Point(270, 190);
            this.labelLoanUser.Text = "Usuario";
            // 
            // cboLoanUser
            // 
            this.cboLoanUser.Location = new System.Drawing.Point(340, 187);
            this.cboLoanUser.Size = new System.Drawing.Size(200, 28);
            // 
            // btnCreateLoan
            // 
            this.btnCreateLoan.Location = new System.Drawing.Point(562, 60);
            this.btnCreateLoan.Size = new System.Drawing.Size(75, 30);
            this.btnCreateLoan.Text = "Crear";
            this.btnCreateLoan.Click += new System.EventHandler(this.btnCreateLoan_Click);
            // 
            // btnReturnLoan
            // 
            this.btnReturnLoan.Location = new System.Drawing.Point(562, 127);
            this.btnReturnLoan.Size = new System.Drawing.Size(98, 30);
            this.btnReturnLoan.Text = "Devolver";
            this.btnReturnLoan.Click += new System.EventHandler(this.btnReturnLoan_Click);
            // 
            // chartBooks
            // 
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            chartArea1.Name = "ChartArea1";
            legend1.Name = "Legend1";
            this.chartBooks.ChartAreas.Add(chartArea1);
            this.chartBooks.Legends.Add(legend1);
            this.chartBooks.Location = new System.Drawing.Point(12, 540);
            this.chartBooks.Size = new System.Drawing.Size(500, 250);
            this.chartBooks.Text = "chartBooks";
            // 
            // chartUsers
            // 
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            chartArea2.Name = "ChartArea1";
            legend2.Name = "Legend1";
            this.chartUsers.ChartAreas.Add(chartArea2);
            this.chartUsers.Legends.Add(legend2);
            this.chartUsers.Location = new System.Drawing.Point(530, 540);
            this.chartUsers.Size = new System.Drawing.Size(500, 250);
            this.chartUsers.Text = "chartUsers";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1040, 820);
            this.Controls.Add(this.groupBoxBooks);
            this.Controls.Add(this.groupBoxUsers);
            this.Controls.Add(this.groupBoxLoans);
            this.Controls.Add(this.chartBooks);
            this.Controls.Add(this.chartUsers);
            this.Name = "Form1";
            this.Text = "Gestión de Biblioteca";

            this.groupBoxBooks.ResumeLayout(false);
            this.groupBoxBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBooks)).EndInit();
            this.groupBoxUsers.ResumeLayout(false);
            this.groupBoxUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).EndInit();
            this.groupBoxLoans.ResumeLayout(false);
            this.groupBoxLoans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLoans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsers)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBooks;
        private System.Windows.Forms.DataGridView gridBooks;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.Button btnDeleteBook;

        private System.Windows.Forms.GroupBox groupBoxUsers;
        private System.Windows.Forms.DataGridView gridUsers;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label labelUserEmail;
        private System.Windows.Forms.TextBox txtUserEmail;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnDeleteUser;

        private System.Windows.Forms.GroupBox groupBoxLoans;
        private System.Windows.Forms.DataGridView gridLoans;
        private System.Windows.Forms.Label labelLoanBook;
        private System.Windows.Forms.ComboBox cboLoanBook;
        private System.Windows.Forms.Label labelLoanUser;
        private System.Windows.Forms.ComboBox cboLoanUser;
        private System.Windows.Forms.Button btnCreateLoan;
        private System.Windows.Forms.Button btnReturnLoan;

        private System.Windows.Forms.DataVisualization.Charting.Chart chartBooks;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartUsers;
    }
}
