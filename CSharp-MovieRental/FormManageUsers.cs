using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_MovieRental
{
    public partial class FormManageUsers : Form
    {
        MovieRentalContext context; //connect to database
        User user;
        User selectedUser;
        public FormManageUsers()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            context = new MovieRentalContext();
            resetForm();
        }

        private void borrowHistoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate(); // if any control has an event handler for the Validating event, it executes. 

            user.FirstName = firstNameTextBox.Text;
            user.LastName = lastNameTextBox.Text;
            user.Email = emailTextBox.Text;
            user.Phone = phoneTextBox.Text;

            context.Users.Add(user);

            
            foreach (var user in context.Users.Local.ToList())
            {
                if (!user.IsValid())
                {
                    this.context.Users.Remove(user);
                    List<string> errorList = user.Validate().ToList();
                    string errorMsg = "";
                    foreach (var error in errorList)
                    {
                        errorMsg += ("\n" + error);
                    }
                    MessageBox.Show("Error Updating the Database\n" + errorMsg, "Invalid Submission");
                }
            }
            

            this.borrowHistoryBindingSource.EndEdit(); // complete current edit, if any
            
            this.context.SaveChanges(); // write changes to database file
            //refresh page
            resetForm();
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
            // Current Page
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
            this.Hide();
            using (FormReports reports = new FormReports())
            {
                reports.ShowDialog();
            }
        }
        #endregion

        public void resetForm()
        {
            user = new User();

            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            emailTextBox.Clear();
            phoneTextBox.Clear();

            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            groupBox1.BackColor = SystemColors.Control;

            // populate user list
            List<User> userList = context.Users.ToList();
            this.dataGridViewUsers.DataSource = userList;
        }

        private void dataGridViewUsers_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewUsers.CurrentRow.Index != -1)
            {
                // Extracting a user from the form
                selectedUser = (User)dataGridViewUsers.CurrentRow.DataBoundItem;
                firstNameTextBox.Text = selectedUser.FirstName;
                lastNameTextBox.Text = selectedUser.LastName;
                emailTextBox.Text = selectedUser.Email;
                phoneTextBox.Text = selectedUser.Phone;

                btnSave.Enabled = false;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                groupBox1.BackColor = SystemColors.ActiveCaption;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this profile?", "Delete Profile", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                context.Users.Remove(selectedUser);
                context.SaveChanges();
            }
            resetForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Validate(); // if any control has an event handler for the Validating event, it executes. 

            selectedUser.FirstName = firstNameTextBox.Text;
            selectedUser.LastName = lastNameTextBox.Text;
            selectedUser.Email = emailTextBox.Text;
            selectedUser.Phone = phoneTextBox.Text;

                if (!selectedUser.IsValid())
                {
                    this.context.Users.Remove(selectedUser);
                    List<string> errorList = selectedUser.Validate().ToList();
                    string errorMsg = "";
                    foreach (var error in errorList)
                    {
                        errorMsg += ("\n" + error);
                    }
                    MessageBox.Show("Error Updating the Database\n" + errorMsg, "Invalid Submission");
                } else
                {
                    context.Entry(selectedUser).State = EntityState.Modified;
                    context.SaveChanges();
                }

            resetForm();
        }
        
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.context.Dispose();
            Application.Exit();
        }
    }
}

