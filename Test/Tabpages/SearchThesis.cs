using ResearchRecordingSystem;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Test.Tabpages
{
    public partial class SearchThesis : Form
    {
        public SearchThesis()
        {
            InitializeComponent();
            LoadThesis();
        }

        private void LoadThesis()
        {
            using (RRSContext ctx = new RRSContext())
            {



                researchBookBindingSource.DataSource = ctx.ResearchBooks.ToList();



            }
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            using (RRSContext ctx = new RRSContext())
            {
                researchBookBindingSource.DataSource = ctx.ResearchBooks.Where(x => x.Title.Contains(tb_Search.Text) ||
                                                                    x.PublishedYear.Contains(tb_Search.Text) ||
                                                                    x.Remarks.Contains(tb_Search.Text)).ToList();


            }
        }



        private void SearchThesis_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewSearch_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void bt_ViewEcopy_Click(object sender, EventArgs e)
        {
            ViewECopyForm viewECopyForm = new ViewECopyForm();
            viewECopyForm.Show();
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            using (RRSContext ctx = new RRSContext())
            {
                researchBookBindingSource.DataSource = ctx.ResearchBooks.Where(x => x.Title.Contains(tb_Search.Text) ||
                                                                    x.PublishedYear.Contains(tb_Search.Text) ||
                                                                    x.Remarks.Contains(tb_Search.Text)).ToList();


            }
        }
    }
}
