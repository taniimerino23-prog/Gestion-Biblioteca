using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private LibraryManager library;

        public Form1()
        {
            InitializeComponent();
            library = new LibraryManager();

            gridBooks.SelectionChanged += GridBooks_SelectionChanged;
            gridUsers.SelectionChanged += GridUsers_SelectionChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBooks();
            LoadUsers();
            LoadLoans();
        }

        // ================== LIBROS ==================
        private void LoadBooks()
        {
            gridBooks.DataSource = null;
            gridBooks.DataSource = library.Books.ToList();

            if (gridBooks.Columns["Id"] != null) gridBooks.Columns["Id"].HeaderText = "ID";
            if (gridBooks.Columns["Title"] != null) gridBooks.Columns["Title"].HeaderText = "Título";
            if (gridBooks.Columns["Author"] != null) gridBooks.Columns["Author"].HeaderText = "Autor";
            if (gridBooks.Columns["Year"] != null) gridBooks.Columns["Year"].HeaderText = "Año";
        }

        private void GridBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (gridBooks.CurrentRow?.DataBoundItem is Book book)
            {
                txtTitle.Text = book.Title;
                txtAuthor.Text = book.Author;
                txtYear.Text = book.Year.ToString();
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtAuthor.Text) ||
                string.IsNullOrWhiteSpace(txtYear.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            if (!int.TryParse(txtYear.Text, out int year))
            {
                MessageBox.Show("El año debe ser un número válido.");
                return;
            }

            var book = new Book
            {
                Title = txtTitle.Text,
                Author = txtAuthor.Text,
                Year = year
            };

            library.AddBook(book);
            LoadBooks();
            LoadComboBoxes();

            txtTitle.Clear();
            txtAuthor.Clear();
            txtYear.Clear();
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            if (gridBooks.CurrentRow?.DataBoundItem is Book book)
            {
                if (!string.IsNullOrWhiteSpace(txtTitle.Text))
                    book.Title = txtTitle.Text;
                if (!string.IsNullOrWhiteSpace(txtAuthor.Text))
                    book.Author = txtAuthor.Text;
                if (int.TryParse(txtYear.Text, out int year))
                    book.Year = year;

                LoadBooks();
                LoadComboBoxes();

                txtTitle.Clear();
                txtAuthor.Clear();
                txtYear.Clear();
            }
            else
            {
                MessageBox.Show("Selecciona un libro en la tabla.");
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (gridBooks.CurrentRow?.DataBoundItem is Book book)
            {
                library.Books.Remove(book);
                LoadBooks();
                LoadComboBoxes();

                txtTitle.Clear();
                txtAuthor.Clear();
                txtYear.Clear();
            }
            else
            {
                MessageBox.Show("Selecciona un libro en la tabla.");
            }
        }

        // ================== USUARIOS ==================
        private void LoadUsers()
        {
            gridUsers.DataSource = null;
            gridUsers.DataSource = library.Users.ToList();

            if (gridUsers.Columns["Id"] != null) gridUsers.Columns["Id"].HeaderText = "ID";
            if (gridUsers.Columns["Name"] != null) gridUsers.Columns["Name"].HeaderText = "Nombre";
            if (gridUsers.Columns["Email"] != null) gridUsers.Columns["Email"].HeaderText = "Correo";
        }

        private void GridUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (gridUsers.CurrentRow?.DataBoundItem is User user)
            {
                txtUserName.Text = user.Name;
                txtUserEmail.Text = user.Email;
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text) ||
                string.IsNullOrWhiteSpace(txtUserEmail.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            var user = new User
            {
                Name = txtUserName.Text,
                Email = txtUserEmail.Text
            };

            library.AddUser(user);
            LoadUsers();
            LoadComboBoxes();

            txtUserName.Clear();
            txtUserEmail.Clear();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (gridUsers.CurrentRow?.DataBoundItem is User user)
            {
                if (!string.IsNullOrWhiteSpace(txtUserName.Text))
                    user.Name = txtUserName.Text;
                if (!string.IsNullOrWhiteSpace(txtUserEmail.Text))
                    user.Email = txtUserEmail.Text;

                LoadUsers();
                LoadComboBoxes();

                txtUserName.Clear();
                txtUserEmail.Clear();
            }
            else
            {
                MessageBox.Show("Selecciona un usuario en la tabla.");
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (gridUsers.CurrentRow?.DataBoundItem is User user)
            {
                library.Users.Remove(user);
                LoadUsers();
                LoadComboBoxes();

                txtUserName.Clear();
                txtUserEmail.Clear();
            }
            else
            {
                MessageBox.Show("Selecciona un usuario en la tabla.");
            }
        }

        // ================== PRÉSTAMOS ==================
        private void LoadLoans()
        {
            gridLoans.DataSource = null;

            var loanData = from loan in library.Loans
                           join book in library.Books on loan.BookId equals book.Id
                           join user in library.Users on loan.UserId equals user.Id
                           select new
                           {
                               loan.Id,
                               Libro = book.Title,
                               Usuario = user.Name,
                               FechaDePréstamo = loan.LoanDate.ToString("dd/MM/yyyy"),
                               FechaDeDevolución = loan.ReturnDate.ToString("dd/MM/yyyy")
                           };

            gridLoans.DataSource = loanData.ToList();

            if (gridLoans.Columns["Id"] != null) gridLoans.Columns["Id"].HeaderText = "ID";

            LoadComboBoxes();
            UpdateCharts();
        }

        private void LoadComboBoxes()
        {
            cboLoanBook.DataSource = null;
            cboLoanBook.DataSource = library.Books.ToList();
            cboLoanBook.DisplayMember = "Title";
            cboLoanBook.ValueMember = "Id";

            cboLoanUser.DataSource = null;
            cboLoanUser.DataSource = library.Users.ToList();
            cboLoanUser.DisplayMember = "Name";
            cboLoanUser.ValueMember = "Id";
        }

        private void btnCreateLoan_Click(object sender, EventArgs e)
        {
            if (cboLoanBook.SelectedValue is int bookId &&
                cboLoanUser.SelectedValue is int userId)
            {
                library.AddLoan(bookId, userId);
                LoadLoans();
            }
            else
            {
                MessageBox.Show("Selecciona un libro y un usuario.");
            }
        }

        private void btnReturnLoan_Click(object sender, EventArgs e)
        {
            if (gridLoans.CurrentRow != null)
            {
                int loanId = (int)gridLoans.CurrentRow.Cells["Id"].Value;
                library.ReturnLoan(loanId);
                LoadLoans();
            }
            else
            {
                MessageBox.Show("Selecciona un préstamo en la tabla.");
            }
        }

        // ================== GRÁFICOS ==================
        private void UpdateCharts()
        {
            // Libros más prestados
            var bookStats = library.Loans
                .GroupBy(l => l.BookId)
                .Select(g => new { BookId = g.Key, Count = g.Count() })
                .OrderByDescending(x => x.Count)
                .ToList();

            chartBooks.Series.Clear();
            var seriesBooks = new Series("Libros más Prestados");
            seriesBooks.ChartType = SeriesChartType.Bar;

            foreach (var item in bookStats)
            {
                var book = library.Books.FirstOrDefault(b => b.Id == item.BookId);
                if (book != null)
                    seriesBooks.Points.AddXY(book.Title, item.Count);
            }

            chartBooks.Series.Add(seriesBooks);

            // Usuarios más activos
            var userStats = library.Loans
                .GroupBy(l => l.UserId)
                .Select(g => new { UserId = g.Key, Count = g.Count() })
                .OrderByDescending(x => x.Count)
                .ToList();

            chartUsers.Series.Clear();
            var seriesUsers = new Series("Usuarios más Activos");
            seriesUsers.ChartType = SeriesChartType.Bar;

            foreach (var item in userStats)
            {
                var user = library.Users.FirstOrDefault(u => u.Id == item.UserId);
                if (user != null)
                    seriesUsers.Points.AddXY(user.Name, item.Count);
            }

            chartUsers.Series.Add(seriesUsers);
        }
    }
}
