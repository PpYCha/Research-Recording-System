using ResearchRecordingSystemInCollegeOfScience.Properties;
using ResearchRecordingSystemInCollegeOfScience.Tabpages;
using ResearchRecordingSystemInCollegeOfScience.Tabpages.ViewReport;
using System;
using System.Windows.Forms;

namespace ResearchRecordingSystemInCollegeOfScience
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

            if (loginForm.DialogResult == DialogResult.OK)
            {
                manageAccountToolStripMenuItem1.Visible = false;
                manageCourseToolStripMenuItem.Visible = false;
                manageBookToolStripMenuItem.Visible = false;
                //button1.Visible = false;
            }
            else if (loginForm.LoginAsClerk == true)
            {
                manageAccountToolStripMenuItem1.Visible = false;
                manageCourseToolStripMenuItem.Visible = false;
            }
        }




        private void bt_ManageAccount_Click(object sender, EventArgs e)
        {


        }

        private void bt_CourseManagement_Click(object sender, EventArgs e)
        {

        }

        private void bt_ManageThesis_Click(object sender, EventArgs e)
        {

        }

        private void tb_SearchForm_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void bt_ReturnABook_Click(object sender, EventArgs e)
        {

        }

        private void manageAccountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AccountManagerForm accountManagerForm = new AccountManagerForm();
            accountManagerForm.Show();
        }

        private void manageCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseManagerForm courseManagerForm = new CourseManagerForm();
            courseManagerForm.Show();
        }

        private void manageBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThesisManagerForm thesisManagerForm = new ThesisManagerForm();
            thesisManagerForm.Show();
        }

        private void borrowABookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrowABook burrow = new BorrowABook();
            burrow.Show();
        }

        private void returnABookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnABorrowedBook returnABorrowedBook = new ReturnABorrowedBook();
            returnABorrowedBook.ShowDialog();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchThesis searchThesis = new SearchThesis();
            searchThesis.Show();
        }

        private void borrowedBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //    ListofBorrowedBooks listofBorrowedBooks = new ListofBorrowedBooks();
            //    listofBorrowedBooks.ShowDialog();
            ViewListOfBorrowedBooks viewListOfBorrowedBooks = new ViewListOfBorrowedBooks();
            viewListOfBorrowedBooks.ShowDialog();
        }

        private void listByCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewByCourse viewByCourse = new ViewByCourse();
            viewByCourse.ShowDialog();
        }

        private void byAuthrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewByAuthor viewByAuthor = new ViewByAuthor();
            viewByAuthor.ShowDialog();
        }
    }
}
