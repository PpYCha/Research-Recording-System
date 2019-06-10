using System;
using System.Windows.Forms;
using Test;
using Test.Tabpages;

namespace ResearchRecordingSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //LoginForm loginForm = new LoginForm();
            //loginForm.ShowDialog();

            //if (loginForm.DialogResult == DialogResult.OK)
            //{
            //    bt_ManageAccount.Visible = false;
            //    bt_CourseManagement.Visible = false;
            //    bt_ManageThesis.Visible = false;
            //    button1.Visible = false;
            //}
            //else if (loginForm.LoginAsClerk == true)
            //{
            //    bt_ManageAccount.Visible = false;
            //    bt_CourseManagement.Visible = false;
            //}
        }




        private void bt_ManageAccount_Click(object sender, EventArgs e)
        {
            AccountManagerForm accountManagerForm = new AccountManagerForm();
            accountManagerForm.Show();

        }

        private void bt_CourseManagement_Click(object sender, EventArgs e)
        {
            CourseManagerForm courseManagerForm = new CourseManagerForm();
            courseManagerForm.Show();
        }

        private void bt_ManageThesis_Click(object sender, EventArgs e)
        {
            ThesisManagerForm thesisManagerForm = new ThesisManagerForm();
            thesisManagerForm.Show();
        }

        private void tb_SearchForm_Click(object sender, EventArgs e)
        {
            SearchThesis searchThesis = new SearchThesis();
            searchThesis.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BorrowABook burrow = new BorrowABook();
            burrow.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListofBorrowedBooks listofBorrowedBooks = new ListofBorrowedBooks();
            listofBorrowedBooks.ShowDialog();
        }

        private void bt_ReturnABook_Click(object sender, EventArgs e)
        {
            ReturnABorrowedBook returnABorrowedBook = new ReturnABorrowedBook();
            returnABorrowedBook.ShowDialog();
        }
    }
}
