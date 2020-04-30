using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_MovieRental
{
    public partial class FormReports : Form
    {
        MovieRentalContext context; //connect to database
        ObservableListSource<BorrowHistory> bhList = new ObservableListSource<BorrowHistory>();
        int overDueAfterThisManyDays = -1; // Days (temporarily set to a negative number for testing)
        DateTime overDueDate;

        public FormReports()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            context = new MovieRentalContext();

            this.overDueDate = DateTime.Today.AddDays(-overDueAfterThisManyDays);

            // Find the records (in the borrowHistory table) related to movies that were borrowed by this user but never returned (return date is 1900)
            List<BorrowHistory> tempList = context.BorrowHistories.Where(b => DateTime.Compare(b.BorrowDate, overDueDate) < 0 && DateTime.Compare(b.ReturnDate, new DateTime(1910, 1, 1, 0, 0, 0)) < 0).ToList();
            foreach (BorrowHistory bh in tempList) // convert the normal list to an observable list
            {
                bhList.Add(bh);
            }

            // bingding the data to the control in form
            this.OverDueMoviesDataGridView.DataSource = bhList;
            OverDueMoviesDataGridView.Columns[5].Visible = false;
            OverDueMoviesDataGridView.Columns[6].Visible = false;
        }

        private void btnSaveReport_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("OverDueList.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    // Write table titels to file
                    sw.WriteLine($"User Id \t User Email \t\t Movie Id \t Movie Name \t\t Borrow Date");

                    foreach (BorrowHistory bh in bhList)
                    {
                        // Fetch info about the user and the movie (like a SQL join)
                        User user = context.Users.Where(u => u.UserId == bh.UserId).FirstOrDefault();
                        Movie movie = context.Movies.Where(m => m.MovieId == bh.MovieId).FirstOrDefault();
                        // Write Info
                        sw.WriteLine($"{bh.UserId} \t\t {user.Email} \t\t {bh.MovieId} \t\t {movie.Name} \t\t {bh.BorrowDate}");
                    }
                    sw.Flush();
                    sw.Close();
                    fs.Close();
                    MessageBox.Show("File Saved Successfully", "File Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // Sorting Using DB OrderBy
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedItem = (string)comboBox.SelectedItem;

            List<BorrowHistory> tempList = new List<BorrowHistory>();

            // Find the records (in the borrowHistory table) related to movies that were borrowed by this user but never returned (return date is 1900) and are overdue
            switch ((string)comboBox.SelectedItem)
            {
                case "User ID":
                    tempList = context.BorrowHistories.Where(b => DateTime.Compare(b.BorrowDate, overDueDate) < 0 && DateTime.Compare(b.ReturnDate, new DateTime(1910, 1, 1, 0, 0, 0)) < 0).OrderBy(b => b.UserId).ToList();
                    break;
                case "Movie ID":
                    tempList = context.BorrowHistories.Where(b => DateTime.Compare(b.BorrowDate, overDueDate) < 0 && DateTime.Compare(b.ReturnDate, new DateTime(1910, 1, 1, 0, 0, 0)) < 0).OrderBy(b => b.MovieId).ToList();
                    break;
                case "Borrow Date":
                    tempList = context.BorrowHistories.Where(b => DateTime.Compare(b.BorrowDate, overDueDate) < 0 && DateTime.Compare(b.ReturnDate, new DateTime(1910, 1, 1, 0, 0, 0)) < 0).OrderBy(b => b.BorrowDate).ToList();
                    break;
            }

            bhList.Clear();
            foreach (BorrowHistory bh in tempList) // convert the normal list to an observable list
            {
                bhList.Add(bh);
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.context.Dispose();
            Application.Exit();
        }

        #region Navigation
        private void manageMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FormManageMovies formMovies = new FormManageMovies())
            {
                formMovies.ShowDialog();
            }
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FormManageUsers formUsers = new FormManageUsers())
            {
                formUsers.ShowDialog();
            }
        }

        private void returnMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FormReturnMovies returnMovies = new FormReturnMovies())
            {
                returnMovies.ShowDialog();
            }
        }

        private void borrowMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FormBorrowMovies borrowMovies = new FormBorrowMovies())
            {
                borrowMovies.ShowDialog();
            }
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Current Page
        }
        #endregion
    }
}
