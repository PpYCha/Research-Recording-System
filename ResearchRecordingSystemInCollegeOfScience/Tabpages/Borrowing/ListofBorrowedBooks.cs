﻿using System;
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
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            LoadBorrowedBooks();
        }

        private void LoadBorrowedBooks()
        {
            using (RRSContext ctx = new RRSContext())
            {
                //borrowBindingSource.DataSource = ctx.Borrows.ToList();

                //dataGridView1.AutoGenerateColumns = true;
                //dataGridView1.DataSource = null;
                //dataGridView1.Columns.Clear();
                //dataGridView1.Rows.Clear();

                //var query = 
                //            from p1 in ctx.Borrows
                //            join f1 in ctx.ResearchBooks on p1.BorrowerId equals f1.ThesisTitleId
                //            select new { p1.BFullName, p1.BContactNumber, p1.BookBorrowedDate, p1.DateWillRetrun, f1.Title, p1.NoOfBookBorrowed /*, f1.AuthorLName*/ };




                var result = from e in ctx.Borrows

                             join d in ctx.ResearchBooks

                             on e.ThesisTitleId equals d.ThesisTitleId into empDept

                             from ed in empDept.DefaultIfEmpty()

                             select new

                             {

                                 e.BFullName,
                                 e.BContactNumber,
                                 e.BookBorrowedDate,
                                 e.DateWillRetrun,
                                 ed.Title,
                                 e.NoOfBookBorrowed,

                             };


                //var query = from f1 in ctx.ResearchBooks
                //            from p1 in ctx.Borrows

                //            select new { p1.BFullName, p1.BContactNumber, p1.BookBorrowedDate, p1.DateWillRetrun, f1.Title, p1.NoOfBookBorrowed /*, f1.AuthorLName*/ };




                dataGridView1.DataSource = result.ToList();


                //dataGridView1.DataSource = query.ToList();
                dataGridView1.Columns[0].HeaderCell.Value = "Borrower";
                dataGridView1.Columns[1].HeaderCell.Value = "Contact No";
                dataGridView1.Columns[2].HeaderCell.Value = "Date Borrowed";
                dataGridView1.Columns[3].HeaderCell.Value = "Date will return";
                dataGridView1.Columns[4].HeaderCell.Value = "Book Title";
                dataGridView1.Columns[5].HeaderCell.Value = "No of Copies Borrowed";

                ////dataGridView_Thesis.Columns[4].HeaderCell.Value = "Author Last Name";
            }



        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
