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
                        Borrow usr = ctx.Borrows.Find(br.Cells["borrowerIdDataGridViewTextBoxColumn"].Value);
                        ctx.Borrows.Remove(usr);
                        ctx.SaveChanges();

                        MessageBox.Show("Return Succesfully");
                        /////
                        dataGridView1.DataSource = ctx.Borrows.ToList();
                    }

                }
            }
        }

        private void DeleteBorrower(object dataBoundItem)
        {

        }

        private void ReturnABorrowedBook_Load(object sender, EventArgs e)
        {
            using (RRSContext ctx = new RRSContext())
            {
                borrowBindingSource.DataSource = ctx.Borrows.ToList();
            }
        }
    }
}
