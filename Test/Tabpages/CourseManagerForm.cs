using ResearchRecordingSystem;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Test
{
    public partial class CourseManagerForm : Form
    {
        public CourseManagerForm()
        {
            InitializeComponent();
        }

        private void bt_SaveCourse_Click(object sender, EventArgs e)
        {
            SaveCoure();
        }

        private void SaveCoure()
        {

            if (dataGridView_Course.SelectedRows.Count > 0)
            {
                using (RRSContext ctx = new RRSContext())
                {
                    foreach (var item in courseBindingSource.List)
                    {
                        var course = (Course)item;
                        if (course.CourseId <= 0)
                            ctx.Courses.Add(course);
                        else
                        {
                            ctx.Courses.Attach(course);
                            ctx.Entry(course).State = System.Data.Entity.EntityState.Modified;
                        }
                    }

                    ctx.SaveChanges();
                    MessageBox.Show(this, "Update Successfull");
                    CourseManagerForm_Load(null, null);

                }
            }
            else
            {
                using (var ctx = new RRSContext())
                {

                    var course = new Course
                    {
                        CourseName = tb_Course.Text,
                        IsActive = true,
                    };
                    ctx.Courses.Add(course);
                    ctx.SaveChanges();
                    ClearText();
                    MessageBox.Show(this, "Save Successfull");
                    CourseManagerForm_Load(null, null);
                }
            }
        }




        private void bt_EditCourse_Click(object sender, EventArgs e)
        {
            EditCoure();
        }

        private void EditCoure()
        {

        }

        private void CourseManagerForm_Load(object sender, EventArgs e)
        {
            using (RRSContext ctx = new RRSContext())
            {
                courseBindingSource.DataSource = ctx.Courses.ToList();
            }
            //dataGridView_Course.Rows[0].Selected = false;
            dataGridView_Course.ClearSelection();
        }

        private void bt_DeleteCourse_Click(object sender, EventArgs e)
        {
            if (dataGridView_Course.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView_Course.SelectedRows)
                {
                    DeleteCourse(row.DataBoundItem);
                    courseBindingSource.Remove(row.DataBoundItem);
                }
            }
        }

        private void DeleteCourse(object dataBoundItem)
        {
            if (dataBoundItem == null)

                return;

            var course = (Course)dataBoundItem;

            using (RRSContext ctx = new RRSContext())
            {
                var toBeDeleted = ctx.Courses.Where(u => u.CourseId == course.CourseId).FirstOrDefault();
                if (toBeDeleted == null)
                    return;

                ctx.Courses.Remove(toBeDeleted);
                ctx.SaveChanges();
                MessageBox.Show(this, "Delete Successfull");

            }
        }

        private void ClearText()
        {
            tb_Course.Clear();
        }
    }
}
