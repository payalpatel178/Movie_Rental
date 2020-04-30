namespace CSharp_MovieRental
{
    partial class FormReturnMovies
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpBorrowedMovies = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnReturn = new System.Windows.Forms.Button();
            this.grpUserInformation = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.txtUserEmail = new System.Windows.Forms.TextBox();
            this.lblReturnMovies = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.borrowMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBorrowedMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            this.grpUserInformation.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBorrowedMovies
            // 
            this.grpBorrowedMovies.Controls.Add(this.dataGridView1);
            this.grpBorrowedMovies.Location = new System.Drawing.Point(72, 250);
            this.grpBorrowedMovies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBorrowedMovies.Name = "grpBorrowedMovies";
            this.grpBorrowedMovies.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBorrowedMovies.Size = new System.Drawing.Size(972, 273);
            this.grpBorrowedMovies.TabIndex = 13;
            this.grpBorrowedMovies.TabStop = false;
            this.grpBorrowedMovies.Text = "Borrowed Movies";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(919, 213);
            this.dataGridView1.TabIndex = 0;
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataSource = typeof(CSharp_MovieRental.ObservableListSource<CSharp_MovieRental.Movie>);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(508, 547);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 26);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // grpUserInformation
            // 
            this.grpUserInformation.Controls.Add(this.btnSearch);
            this.grpUserInformation.Controls.Add(this.lblUserEmail);
            this.grpUserInformation.Controls.Add(this.txtUserEmail);
            this.grpUserInformation.Location = new System.Drawing.Point(260, 131);
            this.grpUserInformation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpUserInformation.Name = "grpUserInformation";
            this.grpUserInformation.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpUserInformation.Size = new System.Drawing.Size(611, 85);
            this.grpUserInformation.TabIndex = 11;
            this.grpUserInformation.TabStop = false;
            this.grpUserInformation.Text = "User Information";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(499, 33);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 26);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.Location = new System.Drawing.Point(7, 39);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(121, 17);
            this.lblUserEmail.TabIndex = 1;
            this.lblUserEmail.Text = "Username (Email)";
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.Location = new System.Drawing.Point(152, 34);
            this.txtUserEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Size = new System.Drawing.Size(307, 22);
            this.txtUserEmail.TabIndex = 0;
            // 
            // lblReturnMovies
            // 
            this.lblReturnMovies.AutoSize = true;
            this.lblReturnMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnMovies.Location = new System.Drawing.Point(450, 72);
            this.lblReturnMovies.Name = "lblReturnMovies";
            this.lblReturnMovies.Size = new System.Drawing.Size(180, 29);
            this.lblReturnMovies.TabIndex = 10;
            this.lblReturnMovies.Text = "Return Movies";
            this.lblReturnMovies.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrowMoviesToolStripMenuItem,
            this.returnMoviesToolStripMenuItem,
            this.manageUsersToolStripMenuItem,
            this.manageMoviesToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1116, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // borrowMoviesToolStripMenuItem
            // 
            this.borrowMoviesToolStripMenuItem.Name = "borrowMoviesToolStripMenuItem";
            this.borrowMoviesToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.borrowMoviesToolStripMenuItem.Text = "Borrow Movies";
            this.borrowMoviesToolStripMenuItem.Click += new System.EventHandler(this.borrowMoviesToolStripMenuItem_Click);
            // 
            // returnMoviesToolStripMenuItem
            // 
            this.returnMoviesToolStripMenuItem.Name = "returnMoviesToolStripMenuItem";
            this.returnMoviesToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.returnMoviesToolStripMenuItem.Text = "Return Movies";
            this.returnMoviesToolStripMenuItem.Click += new System.EventHandler(this.returnMoviesToolStripMenuItem_Click);
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // manageMoviesToolStripMenuItem
            // 
            this.manageMoviesToolStripMenuItem.Name = "manageMoviesToolStripMenuItem";
            this.manageMoviesToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.manageMoviesToolStripMenuItem.Text = "Manage Movies";
            this.manageMoviesToolStripMenuItem.Click += new System.EventHandler(this.manageMoviesToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // FormReturnMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 593);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.grpBorrowedMovies);
            this.Controls.Add(this.grpUserInformation);
            this.Controls.Add(this.lblReturnMovies);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormReturnMovies";
            this.Text = "FormReturn";
            this.grpBorrowedMovies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            this.grpUserInformation.ResumeLayout(false);
            this.grpUserInformation.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpBorrowedMovies;
        private System.Windows.Forms.GroupBox grpUserInformation;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblUserEmail;
        private System.Windows.Forms.TextBox txtUserEmail;
        private System.Windows.Forms.Label lblReturnMovies;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem borrowMoviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnMoviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageMoviesToolStripMenuItem;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
    }
}
