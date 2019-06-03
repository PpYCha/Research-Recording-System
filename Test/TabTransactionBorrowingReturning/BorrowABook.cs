using ResearchRecordingSystem;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Test.Tabpages
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

            using (var ctx = new RRSContext())
            {


                var borrow = new Borrow
                {
                    BFullaName = tb_BFName.Text,


                };



                ctx.Borrows.Add(borrow);
                ctx.SaveChanges();


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
                var query = from p1 in ctx.ResearchBooks
                                //from p2 in ctx.Borrows

                                //select new { p1.Title, p2.BFullaName, p2.BContactNumber, p2.BookBorrowedDate, p2.BookReturnedDate };
                            select new { p1.Title, p1.Borrower.BFullaName, p1.Borrower.BookBorrowedDate, p1.Borrower.BookReturnedDate };
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


                dataGridView_Borrow.BeginEdit(true);



            }
        }



        private void dataGridView_Borrow_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dataGridView_Borrow_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView_Borrow.SelectedRows.Count > 0)
            {




                dataGridView_Borrow.Enabled = false;
            }
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
    }
}
