using System;
using System.Linq;
using System.Windows.Forms;

namespace ResearchRecordingSystemInCollegeOfScience.Tabpages
{
    public partial class ReturnABorrowedBook : Form
    {
        public ReturnABorrowedBook()
        {
            InitializeComponent();
        }

        private void bt_AddAuthor_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow br in dataGridView1.SelectedRows)
                {


                    using (RRSContext ctx = new RRSContext())
                    {

                        int tempId = Int32.Parse(dataGridView1.SelectedRows[0].Cells[7].Value.ToString());

                        var categoryid = (from cats in ctx.ResearchBooks
                                          where cats.ThesisTitleId.Equals(tempId)
                                          select cats.NumberOfCopies).SingleOrDefault();

                        var bookReturn = categoryid + 1;

                        var rb = new ResearchBook() { ThesisTitleId = tempId, NumberOfCopies = bookReturn };
                        ctx.ResearchBooks.Attach(rb);
                        ctx.Entry(rb).Property(x => x.NumberOfCopies).IsModified = true;
                        ctx.SaveChanges();


                        Borrow usr = ctx.Borrows.Find(br.Cells[0].Value);
                        ctx.Borrows.Remove(usr);
                        ctx.SaveChanges();



                        MessageBox.Show("Return Succesfully");
                        /////
                        ReturnABorrowedBook_Load(null, null);
                    }

                }
            }





        }

        private void DeleteBorrower(object dataBoundItem)
        {

        }

        private void ReturnABorrowedBook_Load(object sender, EventArgs e)
        {
            //using (RRSContext ctx = new RRSContext())
            //{
            //    borrowBindingSource.DataSource = ctx.Borrows.ToList();
            //}

            using (RRSContext ctx = new RRSContext())
            {
                var result = from f in ctx.Borrows

                             join d in ctx.ResearchBooks

                             on f.ThesisTitleId equals d.ThesisTitleId into empDept

                             from ed in empDept.DefaultIfEmpty()

                             select new

                             {
                                 f.BorrowerId,
                                 f.BFullName,
                                 f.BContactNumber,
                                 f.BookBorrowedDate,
                                 f.DateWillRetrun,
                                 ed.Title,
                                 f.NoOfBookBorrowed,
                                 ed.ThesisTitleId,
                             };

                dataGridView1.DataSource = result.ToList();
                this.dataGridView1.Columns["BorrowerId"].Visible = false;
                this.dataGridView1.Columns["ThesisTitleId"].Visible = false;
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
