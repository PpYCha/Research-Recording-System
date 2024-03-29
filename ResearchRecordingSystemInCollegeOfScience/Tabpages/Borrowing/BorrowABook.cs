﻿using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;

namespace ResearchRecordingSystemInCollegeOfScience.Tabpages
{
    public partial class BorrowABook : Form
    {
        public BorrowABook()
        {
            InitializeComponent();
        }

        private void bt_AddAuthor_Click(object sender, EventArgs e)
        {
            AddBorrower();
        }

        private void AddBorrower()
        {
            try
            {
                if (!(tb_BFName.Text == ""))
                {


                    using (var ctx = new RRSContext())
                    {

                        int tempId = Int32.Parse(dataGridView_Borrow.SelectedRows[0].Cells[0].Value.ToString());

                        var categoryid = (from cats in ctx.ResearchBooks
                                          where cats.ThesisTitleId.Equals(tempId)
                                          select cats.NumberOfCopies).SingleOrDefault();
                        if (categoryid == 0)
                        {
                            MessageBox.Show("No books available");
                        }
                        else
                        {


                            var bookBorrowed = categoryid - 1;

                            var rb = new ResearchBook() { ThesisTitleId = tempId, NumberOfCopies = bookBorrowed };
                            ctx.ResearchBooks.Attach(rb);
                            ctx.Entry(rb).Property(x => x.NumberOfCopies).IsModified = true;
                            ctx.SaveChanges();


                            var borrow = new Borrow
                            {
                                BFullName = tb_BFName.Text,
                                BContactNumber = tb_BContactNumber.Text,
                                BookBorrowedDate = DateTime.Now,
                                DateWillRetrun = dateTimePicker_Return.Value.Date,
                                ThesisTitleId = tempId,
                                NoOfBookBorrowed = 1,
                            };
                            ctx.Borrows.AddOrUpdate(borrow);
                            ctx.SaveChanges();

                            tb_BFName.Clear();
                            tb_BContactNumber.Clear();
                            dateTimePicker_Return.Value = DateTime.Now;

                            LoadBorrower();

                            ListofBorrowedBooks listofBorrowedBooks = new ListofBorrowedBooks();
                            listofBorrowedBooks.ShowDialog();

                        }

                    }
                }
                else
                {
                    MessageBox.Show("Add a borrower name");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void BurrowBook_Load(object sender, EventArgs e)
        {
            LoadBorrower();
        }

        private void LoadBorrower()
        {

            using (RRSContext ctx = new RRSContext())
            {
                /* var query = from p1 in ctx.ResearchBooks
                                //from p2 in ctx.Borrows

                                //select new { p1.Title, p2.BFullaName, p2.BContactNumber, p2.BookBorrowedDate, p2.BookReturnedDate };
                            select new { p1.Title, p1.Borrower.BFullName, p1.Borrower.BookBorrowedDate, p1.Borrower.DateWillRetrun };
                //foreach (var item in query)
                //{
                //    dataGridView_Borrow.DataSource = query.ToList();
                //}


                dataGridView_Borrow.DataSource = query.ToList();
                dataGridView_Borrow.Columns[0].HeaderCell.Value = "Title";
                //dataGridView_Borrow.Columns[1].HeaderCell.Value = "Published Year";
                //dataGridView_Borrow.Columns[2].HeaderCell.Value = "Course";

                dataGridView_Borrow.Columns[1].HeaderCell.Value = "Borrower Name";
                dataGridView_Borrow.Columns[2].HeaderCell.Value = "Borrowed Date";
                dataGridView_Borrow.Columns[3].HeaderCell.Value = "Retrurn Date";
                ////dataGridView_Thesis.Columns[4].HeaderCell.Value = "Author Last Name";


                dataGridView_Borrow.BeginEdit(true); */

                researchBookBindingSource.DataSource = ctx.ResearchBooks.ToList();

            }
        }



        private void dataGridView_Borrow_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dataGridView_Borrow_DoubleClick(object sender, EventArgs e)
        {
            ViewBookInformation viewBookInformation = new ViewBookInformation();
            viewBookInformation.dgvr = dataGridView_Borrow.SelectedRows[0];
            viewBookInformation.Show();
        }

        private void dataGridView_Borrow_DataSourceChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_Borrow_DataSourceChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView_Borrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (RRSContext ctx = new RRSContext())
            {
                researchBookBindingSource.DataSource = ctx.ResearchBooks.Where(x => x.Title.Contains(textBox1.Text) ||
                                                                    x.PublishedYear.Contains(textBox1.Text) ||
                                                                    x.CourseNameRb.Contains(textBox1.Text) ||
                                                                    x.Remarks.Contains(textBox1.Text)).ToList();


            }
        }

        private void tb_BContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            isNumeric(sender, e);
        }

        public void isNumeric(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
