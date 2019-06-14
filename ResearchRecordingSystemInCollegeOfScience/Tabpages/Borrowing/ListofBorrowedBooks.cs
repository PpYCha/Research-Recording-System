using System;
using System.Linq;
using System.Windows.Forms;

namespace ResearchRecordingSystemInCollegeOfScience.Tabpages
{
    public partial class ListofBorrowedBooks : Form
    {
        public ListofBorrowedBooks()
        {
            InitializeComponent();
        }

        private void ListofBorrowedBooks_Load(object sender, EventArgs e)
        {
            LoadBorrowedBooks();
        }

        private void LoadBorrowedBooks()
        {
            using (RRSContext ctx = new RRSContext())
            {
                //borrowBindingSource.DataSource = ctx.Borrows.ToList();

                var query = from p1 in ctx.Borrows
                            join f1 in ctx.ResearchBooks on p1.BorrowerId equals f1.ThesisTitleId
                            select new { p1.BFullName, p1.BContactNumber, p1.BookBorrowedDate, p1.DateWillRetrun, f1.Title, p1.NoOfBookBorrowed /*, f1.AuthorLName*/ };



                dataGridView1.DataSource = query.ToList();
                dataGridView1.Columns[0].HeaderCell.Value = "Borrower";
                dataGridView1.Columns[1].HeaderCell.Value = "Contact No";
                dataGridView1.Columns[2].HeaderCell.Value = "Date Borrowed";
                dataGridView1.Columns[3].HeaderCell.Value = "Date will return";
                dataGridView1.Columns[4].HeaderCell.Value = "Title";
                dataGridView1.Columns[5].HeaderCell.Value = "No of Copies Borrowed";
                //dataGridView_Thesis.Columns[4].HeaderCell.Value = "Author Last Name";
            }



        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
