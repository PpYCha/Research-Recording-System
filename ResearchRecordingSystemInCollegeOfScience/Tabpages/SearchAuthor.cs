using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ResearchRecordingSystemInCollegeOfScience.Tabpages
{

    public partial class SearchAuthor : Form
    {
        public SearchAuthor()
        {
            InitializeComponent();
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            using (RRSContext ctx = new RRSContext())
            {
                authorBindingSource.DataSource = ctx.Authors
                                                                  .Where(x => x.AuthorName.Contains(tb_Search.Text)).ToList();



            }
        }

        private void SearchAuthor_Load(object sender, EventArgs e)
        {

        }

        private void btn_AddAuthor_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["ThesisManagerForm"];




            try
            {


                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    ((ThesisManagerForm)f).dataGridView1.Rows.Add((row.Cells[0].Value), (row.Cells[1].Value), (row.Cells[2].Value));

                }

                this.Close();

            }
            catch (Exception)
            {

            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
