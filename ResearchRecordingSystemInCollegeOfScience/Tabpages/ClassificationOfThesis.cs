using System;
using System.Linq;
using System.Windows.Forms;

namespace ResearchRecordingSystemInCollegeOfScience.Tabpages
{
    public partial class ClassificationOfThesis : Form
    {
        public ClassificationOfThesis()
        {
            InitializeComponent();
        }

        public DataGridViewRow dgvr;

        private void ClassificationOfThesis_Load(object sender, EventArgs e)
        {
            using (RRSContext ctx = new RRSContext())
            {
                int tempId = Int32.Parse(dgvr.Cells[0].Value.ToString());
                classifacationBindingSource.DataSource = ctx.Classifacations.Where(x => x.CourseId == tempId).ToList();
            }

            tb_Course.Text = dgvr.Cells[1].Value.ToString();

        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            SaveAll();
        }

        private void SaveAll()
        {
            int tempId = Int32.Parse(dgvr.Cells[0].Value.ToString());
            using (RRSContext ctx = new RRSContext())
            {
                //if (tb_ClassificationName.Text == "")
                //{

                //var classfication = new Classifacation()
                //{
                //    ClassificationName = tb_ClassificationName.Text,
                //    CourseId = tempId,
                //};

                //ctx.Classifacations.Add(classfication);
                //ctx.SaveChanges();
                //tb_ClassificationName.Clear();
                //ClassificationOfThesis_Load(null, null);
                //}


                if (dataGridView1.SelectedRows.Count > 0)
                {

                    foreach (var item in classifacationBindingSource.List)
                    {
                        var classifacation = (Classifacation)item;
                        if (classifacation.ClassificationId <= 0)
                            ctx.Classifacations.Add(classifacation);
                        else
                        {
                            ctx.Classifacations.Attach(classifacation);
                            ctx.Entry(classifacation).State = System.Data.Entity.EntityState.Modified;
                        }
                    }

                    ctx.SaveChanges();
                    MessageBox.Show(this, "Update Successfull");


                }


            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}