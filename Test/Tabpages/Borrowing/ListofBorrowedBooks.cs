using ResearchRecordingSystem;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Test.Tabpages
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
                borrowBindingSource.DataSource = ctx.Borrows.ToList();
            }
        }
    }
}
