namespace CSharp_MovieRental
{
    partial class FormBorrowMovies
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.borrowMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblUserId = new System.Windows.Forms.Label();
            this.groupBoxMovieInfo = new System.Windows.Forms.GroupBox();
            this.groupBoxBorrow = new System.Windows.Forms.GroupBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBorrow = new System.Windows.Forms.Button();
            this.groupBoxSearchMovies = new System.Windows.Forms.GroupBox();
            this.comboGenre = new System.Windows.Forms.ComboBox();
            this.lblSearchByGenre = new System.Windows.Forms.Label();
            this.lblMessage1 = new System.Windows.Forms.Label();
            this.lblMovie = new System.Windows.Forms.Label();
            this.txtSearchMovie = new System.Windows.Forms.TextBox();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataGridView)).BeginInit();
            this.groupBoxMovieInfo.SuspendLayout();
            this.groupBoxBorrow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.groupBoxSearchMovies.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(481, 56);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(148, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Borrow Movies";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1114, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // borrowMoviesToolStripMenuItem
            // 
            this.borrowMoviesToolStripMenuItem.Name = "borrowMoviesToolStripMenuItem";
            this.borrowMoviesToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.borrowMoviesToolStripMenuItem.Text = "Borrow Movies";
            this.borrowMoviesToolStripMenuItem.Click += new System.EventHandler(this.borrowMoviesToolStripMenuItem_Click);
            // 
            // returnMoviesToolStripMenuItem
            // 
            this.returnMoviesToolStripMenuItem.Name = "returnMoviesToolStripMenuItem";
            this.returnMoviesToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.returnMoviesToolStripMenuItem.Text = "Return Movies";
            this.returnMoviesToolStripMenuItem.Click += new System.EventHandler(this.returnMoviesToolStripMenuItem_Click);
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // manageMoviesToolStripMenuItem
            // 
            this.manageMoviesToolStripMenuItem.Name = "manageMoviesToolStripMenuItem";
            this.manageMoviesToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.manageMoviesToolStripMenuItem.Text = "Manage Movies";
            this.manageMoviesToolStripMenuItem.Click += new System.EventHandler(this.manageMoviesToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataMember = "Movie";
            this.movieBindingSource.DataSource = this.genreBindingSource;
            // 
            // genreBindingSource
            // 
            this.genreBindingSource.DataSource = typeof(CSharp_MovieRental.Genre);
            // 
            // movieDataGridView
            // 
            this.movieDataGridView.AllowUserToAddRows = false;
            this.movieDataGridView.AllowUserToDeleteRows = false;
            this.movieDataGridView.AutoGenerateColumns = false;
            this.movieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movieDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.movieDataGridView.DataSource = this.movieBindingSource;
            this.movieDataGridView.Location = new System.Drawing.Point(9, 32);
            this.movieDataGridView.Name = "movieDataGridView";
            this.movieDataGridView.ReadOnly = true;
            this.movieDataGridView.RowHeadersWidth = 51;
            this.movieDataGridView.Size = new System.Drawing.Size(1054, 276);
            this.movieDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MovieId";
            this.dataGridViewTextBoxColumn1.HeaderText = "MovieId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Director";
            this.dataGridViewTextBoxColumn3.HeaderText = "Director";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Rating";
            this.dataGridViewTextBoxColumn4.HeaderText = "Rating";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Year";
            this.dataGridViewTextBoxColumn5.HeaderText = "Year";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Duration";
            this.dataGridViewTextBoxColumn6.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Synopsis";
            this.dataGridViewTextBoxColumn7.HeaderText = "Synopsis";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ImageURL";
            this.dataGridViewTextBoxColumn8.HeaderText = "ImageURL";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(988, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(60, 323);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(0, 13);
            this.lblUserId.TabIndex = 16;
            // 
            // groupBoxMovieInfo
            // 
            this.groupBoxMovieInfo.Controls.Add(this.movieDataGridView);
            this.groupBoxMovieInfo.Location = new System.Drawing.Point(13, 206);
            this.groupBoxMovieInfo.Name = "groupBoxMovieInfo";
            this.groupBoxMovieInfo.Size = new System.Drawing.Size(1085, 326);
            this.groupBoxMovieInfo.TabIndex = 18;
            this.groupBoxMovieInfo.TabStop = false;
            this.groupBoxMovieInfo.Text = "Available Movies";
            // 
            // groupBoxBorrow
            // 
            this.groupBoxBorrow.Controls.Add(this.emailLabel);
            this.groupBoxBorrow.Controls.Add(this.emailTextBox);
            this.groupBoxBorrow.Controls.Add(this.btnBorrow);
            this.groupBoxBorrow.Location = new System.Drawing.Point(13, 539);
            this.groupBoxBorrow.Name = "groupBoxBorrow";
            this.groupBoxBorrow.Size = new System.Drawing.Size(1085, 100);
            this.groupBoxBorrow.TabIndex = 19;
            this.groupBoxBorrow.TabStop = false;
            this.groupBoxBorrow.Text = "Borrow";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(30, 50);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 19;
            this.emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(104, 43);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(455, 20);
            this.emailTextBox.TabIndex = 20;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(CSharp_MovieRental.User);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(651, 40);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(75, 23);
            this.btnBorrow.TabIndex = 18;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // groupBoxSearchMovies
            // 
            this.groupBoxSearchMovies.Controls.Add(this.comboGenre);
            this.groupBoxSearchMovies.Controls.Add(this.lblSearchByGenre);
            this.groupBoxSearchMovies.Controls.Add(this.lblMessage1);
            this.groupBoxSearchMovies.Controls.Add(this.lblMovie);
            this.groupBoxSearchMovies.Controls.Add(this.txtSearchMovie);
            this.groupBoxSearchMovies.Controls.Add(this.lblSearchName);
            this.groupBoxSearchMovies.Controls.Add(this.btnSearch);
            this.groupBoxSearchMovies.Location = new System.Drawing.Point(13, 107);
            this.groupBoxSearchMovies.Name = "groupBoxSearchMovies";
            this.groupBoxSearchMovies.Size = new System.Drawing.Size(1085, 95);
            this.groupBoxSearchMovies.TabIndex = 20;
            this.groupBoxSearchMovies.TabStop = false;
            this.groupBoxSearchMovies.Text = "Search in Movies";
            // 
            // comboGenre
            // 
            this.comboGenre.FormattingEnabled = true;
            this.comboGenre.Location = new System.Drawing.Point(634, 35);
            this.comboGenre.Name = "comboGenre";
            this.comboGenre.Size = new System.Drawing.Size(121, 21);
            this.comboGenre.TabIndex = 17;
            // 
            // lblSearchByGenre
            // 
            this.lblSearchByGenre.AutoSize = true;
            this.lblSearchByGenre.Location = new System.Drawing.Point(582, 37);
            this.lblSearchByGenre.Name = "lblSearchByGenre";
            this.lblSearchByGenre.Size = new System.Drawing.Size(36, 13);
            this.lblSearchByGenre.TabIndex = 16;
            this.lblSearchByGenre.Text = "Genre";
            // 
            // lblMessage1
            // 
            this.lblMessage1.AutoSize = true;
            this.lblMessage1.Location = new System.Drawing.Point(104, 62);
            this.lblMessage1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage1.Name = "lblMessage1";
            this.lblMessage1.Size = new System.Drawing.Size(223, 13);
            this.lblMessage1.TabIndex = 15;
            this.lblMessage1.Text = "Leave this field empty to search for all movies.";
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.Location = new System.Drawing.Point(65, 58);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(0, 13);
            this.lblMovie.TabIndex = 2;
            // 
            // txtSearchMovie
            // 
            this.txtSearchMovie.Location = new System.Drawing.Point(104, 37);
            this.txtSearchMovie.Name = "txtSearchMovie";
            this.txtSearchMovie.Size = new System.Drawing.Size(455, 20);
            this.txtSearchMovie.TabIndex = 1;
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Location = new System.Drawing.Point(30, 41);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(35, 13);
            this.lblSearchName.TabIndex = 0;
            this.lblSearchName.Text = "Name";
            // 
            // FormBorrowMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 661);
            this.Controls.Add(this.groupBoxSearchMovies);
            this.Controls.Add(this.groupBoxBorrow);
            this.Controls.Add(this.groupBoxMovieInfo);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormBorrowMovies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrow Movies";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataGridView)).EndInit();
            this.groupBoxMovieInfo.ResumeLayout(false);
            this.groupBoxBorrow.ResumeLayout(false);
            this.groupBoxBorrow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.groupBoxSearchMovies.ResumeLayout(false);
            this.groupBoxSearchMovies.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem borrowMoviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnMoviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageMoviesToolStripMenuItem;
        private System.Windows.Forms.BindingSource genreBindingSource;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private System.Windows.Forms.DataGridView movieDataGridView;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.GroupBox groupBoxMovieInfo;
        private System.Windows.Forms.GroupBox groupBoxBorrow;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.GroupBox groupBoxSearchMovies;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.TextBox txtSearchMovie;
        private System.Windows.Forms.Label lblMovie;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label lblMessage1;
        private System.Windows.Forms.Label lblSearchByGenre;
        private System.Windows.Forms.ComboBox comboGenre;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
    }
}

