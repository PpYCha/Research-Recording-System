using ResearchRecordingSystem;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Test.Tabpages
{
    public partial class BurrowBook : Form
    {
        public BurrowBook()
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
                var rb = new ResearchBook();



                var borrower = new Borrow()
                {

                };


                rb.Borrower = new Borrow
                {
                    BFullaName = tb_BFName.Text,
                    BContactNumber = tb_BContactNumber.Text,
                    BookBorrowedDate = dateTimePicker_Borowed.Value,
                    BookReturnedDate = dateTimePicker_Return.Value,
                    BorrowerId = rb.ThesisTitleId = 1,
                };
                //ctx.Borrows.Add(rb);
                //ctx.SaveChanges();
            }
        }

        private void BurrowBook_Load(object sender, EventArgs e)
        {
            using (RRSContext ctx = new RRSContext())
            {
                researchBookBindingSource.DataSource = ctx.ResearchBooks.ToList();

                //dataGridView_Borrow.DataSource = ctx.Borrows.ToList();
                //foreach (DataGridViewColumn c in dataGridView_Borrow.Columns)
                //{

                //}
                //dataGridView_Borrow.Columns["BFullaName"].HeaderText = "First Name";
                //dataGridView_Borrow.Columns["BFullaName"].Visible = true;

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
    }
}
