using ResearchRecordingSystem;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Test
{
    public partial class ThesisManagerForm : Form
    {
        public ThesisManagerForm()
        {
            InitializeComponent();

        }

        private void ThesisManagerForm_Load(object sender, EventArgs e)
        {


            FillCbCourse();
            cbYear();
            LoadThesis();
            //DisablAuthorControl();

            cb_Course.SelectedIndex = -1;
        }

        private void DisablAuthorControl()
        {
            //bt_AddAuthor.Enabled = false;
            tb_AuthorFName.Enabled = false;
            tb_AuthorMName.Enabled = false;
            tb_AuthorLName.Enabled = false;
            tb_AuthorContactNumber.Enabled = false;
        }

        private void LoadThesis()
        {
            using (RRSContext ctx = new RRSContext())
            {
                var query = from p1 in ctx.ResearchBooks
                            join f1 in ctx.Authors on p1.ThesisTitleId equals f1.AuthorId
                            select new { p1.Title, p1.PublishedYear, p1.CourseNameRb, f1.AuthorFName, f1.AuthorLName };
                //Bind the gridview.


                dataGridView_Thesis.DataSource = query.ToList();
                dataGridView_Thesis.Columns[0].HeaderCell.Value = "Title";
                dataGridView_Thesis.Columns[1].HeaderCell.Value = "Published Year";
                dataGridView_Thesis.Columns[2].HeaderCell.Value = "Course";
                dataGridView_Thesis.Columns[3].HeaderCell.Value = "Author Name";
                dataGridView_Thesis.Columns[4].HeaderCell.Value = "Author Last Name";

                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();


            }

        }


        private void cbYear()
        {
            DateTime currentYear = DateTime.Now;
            int cyear = currentYear.Year;
            for (int i = 1999; i <= cyear; i++)
            {

                cb_PublishedYear.Items.Add(i);


            }
        }

        private void FillCbCourse()
        {
            using (RRSContext ctx = new RRSContext())
            {

                var course_List = ctx.Courses.ToList();
                if (course_List.Count > 0)
                {
                    cb_Course.DataSource = course_List;
                    //cb_Course.Items.Add(cb_Course.DataSource = ctx.Courses.ToString());
                    cb_Course.DisplayMember = "CourseName";
                    cb_Course.ValueMember = "CourseId";

                }



            }
        }

        private void bt_SaveCourse_Click(object sender, EventArgs e)
        {
            SaveCourse();


        }

        private void SaveCourse()
        {
            if (!(tb_Title.Text == ""))
            {


                try
                {
                    using (var ctx = new RRSContext())
                    {

                        //var course = new Course();
                        //course.ThesisTitleId = (Int32)cb_Course.SelectedValue;
                        var thesisTitle = new ResearchBook()
                        {
                            Title = tb_Title.Text,
                            Remarks = tb_Remarks.Text,
                            PublishedYear = cb_PublishedYear.SelectedItem.ToString(),
                            CourseNameRb = cb_Course.GetItemText(cb_Course.SelectedItem),
                        };
                        ctx.ResearchBooks.Add(thesisTitle);
                        ctx.SaveChanges();

                        var author = new Author()

                        {
                            AuthorFName = tb_AuthorFName.Text,
                            AuthorMName = tb_AuthorMName.Text,
                            AuthorLName = tb_AuthorLName.Text,
                            AuthorContactNumber = tb_AuthorContactNumber.Text,
                            ThesisTitleId = thesisTitle.ThesisTitleId,
                        };

                        ctx.Authors.Add(author);
                        ctx.SaveChanges();



                        LoadThesis();
                        MessageBox.Show("Save Successful");
                        ClearTextField();
                       


                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Select Publish Year and Course");
                }
            }
            else
            {
                MessageBox.Show("Please filled up the required fields:");
            }

        }

        private void ClearTextField()
        {
            tb_Title.Clear();
            tb_Remarks.Clear();
            cb_Course.SelectedIndex = -1;
            cb_PublishedYear.SelectedIndex = -1;

            tb_AuthorFName.Clear();
            tb_AuthorMName.Clear();
            tb_AuthorLName.Clear();
            tb_AuthorContactNumber.Clear();
        }

        private void bt_AddAuthor_Click(object sender, EventArgs e)
        {
            AddAuthor();
        }

        private void AddAuthor()
        {

            try
            {
                using (var ctx = new RRSContext())
                {

                    var author = new Author()
                    {
                        AuthorFName = tb_AuthorFName.Text,
                        AuthorMName = tb_AuthorMName.Text,
                        AuthorLName = tb_AuthorLName.Text,
                        AuthorContactNumber = tb_AuthorContactNumber.Text,

                    };

                    ctx.Authors.Add(author);
                    ctx.SaveChanges();
                    MessageBox.Show("Save Successful");

                }


                DisablAuthorControl();
                bt_SaveCourse.Enabled = true;

                tb_AuthorFName.Clear();
                tb_AuthorLName.Clear();
                tb_AuthorMName.Clear();
                tb_AuthorContactNumber.Clear();


            }
            catch (Exception)
            {

                throw;
            }


            dataGridView_Thesis.Enabled = true;

        }

        private void dataGridView_Thesis_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView_Thesis.SelectedRows.Count > 0)
            {


                EnableAuthorControl();
                bt_SaveCourse.Enabled = false;

                dataGridView_Thesis.Enabled = false;
            }
        }

        private void EnableAuthorControl()
        {
            //bt_AddAuthor.Enabled = true;
            tb_AuthorFName.Enabled = true;
            tb_AuthorMName.Enabled = true;
            tb_AuthorLName.Enabled = true;
            tb_AuthorContactNumber.Enabled = false;
        }

        private void bt_Ecopy1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Title = "Browse PDF";
            opd.DefaultExt = "pdf";
            opd.Filter = "PDF files (*.pdf |*.pdf;";
            opd.Multiselect = false;


            if (opd.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    File.Copy(opd.FileName, Application.StartupPath + "\\E-copy\\Abstract\\" + "\\" + opd.SafeFileName);
                    MessageBox.Show("Added Abstract Successfully");
                }
                catch (Exception)
                {

                    MessageBox.Show("File Already Exist");
                }

                //pictureBox2.Image = Image.FromFile(opd.FileName);
                //directoryPath = Path.GetFullPath(opd.FileName);
            }
        }

        private void bt_Ecopy2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Title = "Browse PDF";
            opd.DefaultExt = "pdf";
            opd.Filter = "PDF files (*.pdf |*.pdf;";
            opd.Multiselect = false;


            if (opd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.Copy(opd.FileName, Application.StartupPath + "\\E-copy\\Approval Sheet\\" + "\\" + opd.SafeFileName);
                    MessageBox.Show("Added Approval Sheet Successfully");
                }
                catch (Exception)
                {

                    MessageBox.Show("File Already Exist");
                }

            }
        }

        private void dataGridView_Thesis_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
