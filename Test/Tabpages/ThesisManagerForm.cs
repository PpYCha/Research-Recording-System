using ResearchRecordingSystem;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Test
{
    public partial class ThesisManagerForm : Form
    {
        private int? tempId;

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
                            select new { p1.Title, p1.PublishedYear, p1.CourseNameRb, p1.Remarks, f1.AuthorName/*, f1.AuthorLName*/ };
                //Bind the gridview.


                dataGridView_Thesis.DataSource = query.ToList();
                dataGridView_Thesis.Columns[0].HeaderCell.Value = "Title";
                dataGridView_Thesis.Columns[1].HeaderCell.Value = "Published Year";
                dataGridView_Thesis.Columns[2].HeaderCell.Value = "Course";
                dataGridView_Thesis.Columns[3].HeaderCell.Value = "Remarks";
                dataGridView_Thesis.Columns[4].HeaderCell.Value = "Author Name";
                //dataGridView_Thesis.Columns[4].HeaderCell.Value = "Author Last Name";




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

                var course_List = ctx.Courses.Where(x => x.IsActive == true).ToList();
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
            if (tb_Title.Enabled == false)
            {
                AddAuthor();
            }
            else
            {
                if (!(tb_Title.Text == "" || cb_PublishedYear.SelectedIndex == -1 || cb_Course.SelectedIndex == -1 || tb_AuthorFName.Text == ""))
                {



                    try
                    {
                        using (var ctx = new RRSContext())
                        {
                            if (ctx.ResearchBooks.Any(o => o.Title == tb_Title.Text))
                            {
                                MessageBox.Show("Title Already Exist");
                            }
                            else
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

                                var author = new Author();

                                author.AuthorName = tb_AuthorFName.Text;
                                //AuthorMName = tb_AuthorMName.Text,
                                //AuthorLName = tb_AuthorLName.Text,
                                author.AuthorContactNumber = tb_AuthorContactNumber.Text;
                                author.Gender = cb_Gender.SelectedItem.ToString();
                                author.ThesisTitleId = thesisTitle.ThesisTitleId;

                                tempId = author.ThesisTitleId;
                                ctx.Authors.Add(author);
                                ctx.SaveChanges();



                                LoadThesis();
                                MessageBox.Show("Save Successful");
                                ClearTextField();
                                DialogResult result = MessageBox.Show("Add more author?", " ", MessageBoxButtons.YesNo);

                                if (result == DialogResult.Yes)
                                {
                                    tb_Title.Enabled = false;
                                    tb_Remarks.Enabled = false;
                                    cb_Course.Enabled = false;
                                    cb_PublishedYear.Enabled = false;
                                }
                                if (result == DialogResult.No)
                                {

                                }
                            }

                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Select Publish Year and Course");
                    }
                }
                else
                {
                    MessageBox.Show("Please filled up all the required fields:");
                }
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
            cb_Gender.SelectedIndex = -1;
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
                    if (!(tb_AuthorFName.Text == ""))
                    {
                        var author = new Author()
                        {
                            AuthorName = tb_AuthorFName.Text,
                            //AuthorMName = tb_AuthorMName.Text,
                            //AuthorLName = tb_AuthorLName.Text,
                            AuthorContactNumber = tb_AuthorContactNumber.Text,
                            Gender = cb_Gender.SelectedItem.ToString(),
                            ThesisTitleId = tempId,
                        };

                        ctx.Authors.Add(author);
                        ctx.SaveChanges();
                        MessageBox.Show("Save Successful");
                        ClearTextField();
                        EnableAuthorControl();
                    }


                }




            }
            catch (Exception)
            {

                throw;
            }




        }

        private void dataGridView_Thesis_DoubleClick(object sender, EventArgs e)
        {

        }

        private void EnableAuthorControl()
        {
          
            DialogResult result = MessageBox.Show("Add more author?", " ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

            }
            if (result == DialogResult.No)
            {
                tb_Title.Enabled = true;
                tb_Remarks.Enabled = true;
                cb_Course.Enabled = true;
                cb_PublishedYear.Enabled = true;
            }
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
