using ResearchRecordingSystemInCollegeOfScience.Tabpages;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ResearchRecordingSystemInCollegeOfScience
{
    public partial class ThesisManagerForm : Form
    {
        private int? tempId;
        public string appSheEcopy;
        public string abstractEcopy;
        public DataGridViewRow dgvrAuthor;

        public ThesisManagerForm()
        {
            InitializeComponent();

        }



        private void ThesisManagerForm_Load(object sender, EventArgs e)
        {


            FillCbCourse();
            cbYear();
            //LoadThesis();
            //DisablAuthorControl();

            cb_Course.SelectedIndex = -1;

            try
            {



            }
            catch (Exception)
            {

                throw;
            }
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

            if (!(tb_Title.Text == "" || cb_PublishedYear.SelectedIndex == -1 || cb_Course.SelectedIndex == -1 || dataGridView1 == null || dataGridView1.Rows.Count == 0))
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
                                NumberOfCopies = Int32.Parse(tb_NumberOfCopies.Text),
                                Cataloging = tb_Cataloging.Text,
                                AbstractEcopy = label14.Text,
                                ApprovalSheetEcopy = label15.Text,
                                Classification = cb_Classfication.GetItemText(cb_Classfication.SelectedItem),

                            };


                            ctx.ResearchBooks.Add(thesisTitle);
                            ctx.SaveChanges();

                            var author = new Author();

                            //author.AuthorName = tb_AuthorFName.Text;
                            ////AuthorMName = tb_AuthorMName.Text,
                            ////AuthorLName = tb_AuthorLName.Text,
                            //author.AuthorContactNumber = tb_AuthorContactNumber.Text;
                            //author.Gender = cb_Gender.SelectedItem.ToString();
                            //author.ThesisTitleId = thesisTitle.ThesisTitleId;
                            //System.Text.StringBuilder sb = new System.Text.StringBuilder();
                            //foreach (object item in listBox1.Items)
                            //{
                            //    author.AuthorName = (item.ToString());
                            //    author.ThesisTitleId = thesisTitle.ThesisTitleId;
                            //    ctx.Authors.Add(author);

                            //}
                            for (int row = 0; row <= dataGridView1.Rows.Count; row++)
                            {
                                author.AuthorName = dataGridView1.Rows[row].Cells["Column1"].Value.ToString();
                                author.AuthorContactNumber = dataGridView1.Rows[row].Cells["Column2"].Value.ToString();
                                author.Gender = dataGridView1.Rows[row].Cells["Column3"].Value.ToString();
                                author.ThesisTitleId = thesisTitle.ThesisTitleId;
                                ctx.Authors.Add(author);
                                ctx.SaveChanges();

                            }


                            LoadThesis();
                            MessageBox.Show("Save Successful");
                            ClearTextField();
                            //DialogResult result = MessageBox.Show("Add more author?", " ", MessageBoxButtons.YesNo);

                            //if (result == DialogResult.Yes)
                            //{
                            //    tb_Title.Enabled = false;
                            //    tb_Remarks.Enabled = false;
                            //    cb_Course.Enabled = false;
                            //    cb_PublishedYear.Enabled = false;
                            //}
                            //if (result == DialogResult.No)
                            //{

                            //}
                        }

                    }
                }
                catch (Exception)
                {

                    //MessageBox.Show("Select Publish Year and Course");
                    LoadThesis();
                    MessageBox.Show("Save Successful");
                    ClearTextField();

                }
            }
            else
            {
                MessageBox.Show("Please filled up all the required fields:");
            }


        }



        private void ClearTextField()
        {
            tb_Title.Clear();
            tb_Remarks.Clear();
            cb_Course.SelectedIndex = -1;
            cb_PublishedYear.SelectedIndex = -1;
            tb_NumberOfCopies.Clear();
            cb_Classfication.SelectedIndex = -1;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            tb_Cataloging.Clear();
            label15.Text = "";
            label14.Text = "";
            ClearAuthor();
        }

        private void ClearAuthor()
        {
            tb_AuthorFName.Clear();
            tb_AuthorMName.Clear();
            tb_AuthorLName.Clear();
            tb_AuthorContactNumber.Clear();
            cb_Gender.SelectedIndex = -1;


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
                    label14.Text = opd.SafeFileName;
                    File.Copy(opd.FileName, Application.StartupPath + "\\E-copy\\Abstract\\" + "\\" + opd.SafeFileName);
                    //MessageBox.Show("Added Abstract Successfully");
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
                    label15.Text = opd.SafeFileName;
                    File.Copy(opd.FileName, Application.StartupPath + "\\E-copy\\Approval Sheet\\" + "\\" + opd.SafeFileName);
                    //MessageBox.Show("Added Approval Sheet Successfully");
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

        private void button1_Click(object sender, EventArgs e)
        {


            //listBox1.Items.Add((tb_AuthorFName.Text + ("\t \t \t") + tb_AuthorContactNumber.Text + "\t" + cb_Gender.SelectedItem.ToString()).Replace("\r", "").Replace("\n", ""));
            try
            {
                dataGridView1.Rows.Add(tb_AuthorFName.Text, tb_AuthorContactNumber.Text, cb_Gender.SelectedItem.ToString());
                ClearAuthor();
            }
            catch (Exception)
            {

                MessageBox.Show("Please filled up all the required fields:");
            }


        }

        private void bt_RemoveAuthor_Click(object sender, EventArgs e)
        {
            //for (int i = listBox1.SelectedIndices.Count - 1; i >= 0; i--)
            //{
            //    listBox1.Items.RemoveAt(listBox1.SelectedIndices[i]);
            //}
            try
            {
                if (this.dataGridView1.SelectedRows.Count > 0)
                {
                    dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                }
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void cb_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (RRSContext ctx = new RRSContext())
            {


                if (cb_Course.SelectedIndex == -1)
                {

                }
                else
                {
                    try
                    {
                        string tempCourseI = cb_Course.SelectedValue.ToString();
                        int tempCourseId = Int32.Parse(tempCourseI);

                        var classfication_List = ctx.Classifacations.Where(x => x.CourseId == tempCourseId).ToList();
                        if (classfication_List.Count > 0)

                            cb_Classfication.DataSource = classfication_List;
                        //cb_Course.Items.Add(cb_Course.DataSource = ctx.Courses.ToString());
                        cb_Classfication.DisplayMember = "ClassificationName";
                        cb_Classfication.ValueMember = "ClassificationId";
                    }
                    catch (Exception)
                    {


                    }


                }
            }



            //if (cb_Course. == 0)
            //{
            //    using (RRSContext ctx = new RRSContext())
            //    {
            //        int tempCourseId = 2;
            //        var classfication_List = ctx.Classifacations.Where(x => x.CourseId == tempCourseId).ToList();
            //        if (classfication_List.Count > 0)

            //            cb_Classfication.DataSource = classfication_List;
            //        //cb_Course.Items.Add(cb_Course.DataSource = ctx.Courses.ToString());
            //        cb_Classfication.DisplayMember = "ClassificationName";
            //        cb_Classfication.ValueMember = "ClassificationId";

            //    }
            //}
            //else 
            //{


            //}
        }

        private void tb_AuthorContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            isNumeric(sender, e);
        }

        public void isNumeric(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tb_NumberOfCopies_KeyPress(object sender, KeyPressEventArgs e)
        {
            isNumeric(sender, e);
        }

        private void btn_AuthorSearchAdd_Click(object sender, EventArgs e)
        {
            SearchAuthor searchAuthor = new SearchAuthor();
            searchAuthor.ShowDialog();
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

