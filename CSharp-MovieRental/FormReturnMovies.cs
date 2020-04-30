using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_MovieRental
{
    public partial class FormReturnMovies : Form
    {
        MovieRentalContext context; //connect to database
        User returningUser;
        ObservableListSource<Movie> movieList;

        public FormReturnMovies()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            context = new MovieRentalContext();

            //Loading categories from DB
            context.Movies.Load();

            //bingding the data to the source
            this.movieBindingSource.DataSource = context.Movies.Local.ToBindingList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            movieList = new ObservableListSource<Movie>();
            this.dataGridView1.DataSource = movieList;

            returningUser = context.Users.Where(u => u.Email.Equals(txtUserEmail.Text)).FirstOrDefault();

            if (returningUser == null) // user does not exist
            {
                MessageBox.Show("User not found, Please try again.");
                this.txtUserEmail.Focus();
                movieList.Clear();
                return;
            }

            // Find the records (in the borrowHistory table) related to movies that were borrowed by this user but never returned (return date is 1900)
            List<BorrowHistory> bhList = context.BorrowHistories.Where(b => b.UserId == returningUser.UserId && DateTime.Compare(b.ReturnDate, new DateTime(1910,1,1,0,0,0)) < 0).ToList();

            // Find the movies related to above records
            foreach (BorrowHistory bh in bhList)
            {
                movieList.Add(context.Movies.Where(m => m.MovieId == bh.MovieId).FirstOrDefault());
            }
           
            // Add movies to the form
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            int movieId = (int)dataGridView1.CurrentRow.Cells[0].Value;

            BorrowHistory borrowHistory = context.BorrowHistories.Where(b => b.UserId == returningUser.UserId && b.MovieId == movieId && DateTime.Compare(b.ReturnDate, new DateTime(1910, 1, 1, 0, 0, 0)) < 0).FirstOrDefault();

            borrowHistory.ReturnDate = DateTime.Now;

            // Removing movie from the form (Auto update)
            Movie returnedMovie = context.Movies.Where(m => m.MovieId == movieId).FirstOrDefault();
            movieList.Remove(returnedMovie);

            // Save to DB
            context.SaveChanges();

            MessageBox.Show("Movie Returned Successfully!");
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.context.Dispose();
            Application.Exit();
        }

        // Navigation
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
            using(FormManageUsers formUsers = new FormManageUsers())
            {
                formUsers.ShowDialog();
            }
        }

        private void returnMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Current Page
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
            this.Hide();
            using (FormReports reports = new FormReports())
            {
                reports.ShowDialog();
            }
        }
    }
}

    

