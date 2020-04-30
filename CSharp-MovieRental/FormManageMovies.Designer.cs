namespace CSharp_MovieRental
{
    partial class FormManageMovies
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
            this.genreDataGridView = new System.Windows.Forms.DataGridView();
            this.movieDataGridView = new System.Windows.Forms.DataGridView();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.borrowMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.pbxMoviePoster = new System.Windows.Forms.PictureBox();
            this.gbxGenre = new System.Windows.Forms.GroupBox();
            this.gbxMoviePoster = new System.Windows.Forms.GroupBox();
            this.gbxMovies = new System.Windows.Forms.GroupBox();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.genreDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMoviePoster)).BeginInit();
            this.gbxGenre.SuspendLayout();
            this.gbxMoviePoster.SuspendLayout();
            this.gbxMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // genreDataGridView
            // 
            this.genreDataGridView.AutoGenerateColumns = false;
            this.genreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.genreDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.genreDataGridView.DataSource = this.genreBindingSource;
            this.genreDataGridView.Location = new System.Drawing.Point(31, 36);
            this.genreDataGridView.Name = "genreDataGridView";
            this.genreDataGridView.RowHeadersWidth = 51;
            this.genreDataGridView.RowTemplate.Height = 24;
            this.genreDataGridView.Size = new System.Drawing.Size(391, 255);
            this.genreDataGridView.TabIndex = 1;
            // 
            // movieDataGridView
            // 
            this.movieDataGridView.AutoGenerateColumns = false;
            this.movieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movieDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.movieDataGridView.DataSource = this.movieBindingSource;
            this.movieDataGridView.Location = new System.Drawing.Point(31, 40);
            this.movieDataGridView.Name = "movieDataGridView";
            this.movieDataGridView.RowHeadersWidth = 51;
            this.movieDataGridView.RowTemplate.Height = 24;
            this.movieDataGridView.Size = new System.Drawing.Size(1266, 282);
            this.movieDataGridView.TabIndex = 2;
            this.movieDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.movieDataGridView_CellClick);
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataMember = "Movie";
            this.movieBindingSource.DataSource = this.genreBindingSource;
            this.movieBindingSource.DataError += new System.Windows.Forms.BindingManagerDataErrorEventHandler(this.movieBindingSource_DataError);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1387, 30);
            this.menuStrip1.TabIndex = 3;
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(582, 70);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(165, 25);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Manage Movies";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1197, 338);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 31);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.genreBindingNavigatorSaveItem_Click);
            // 
            // pbxMoviePoster
            // 
            this.pbxMoviePoster.Location = new System.Drawing.Point(28, 33);
            this.pbxMoviePoster.Name = "pbxMoviePoster";
            this.pbxMoviePoster.Size = new System.Drawing.Size(293, 258);
            this.pbxMoviePoster.TabIndex = 6;
            this.pbxMoviePoster.TabStop = false;
            // 
            // gbxGenre
            // 
            this.gbxGenre.Controls.Add(this.genreDataGridView);
            this.gbxGenre.Location = new System.Drawing.Point(32, 113);
            this.gbxGenre.Name = "gbxGenre";
            this.gbxGenre.Size = new System.Drawing.Size(457, 312);
            this.gbxGenre.TabIndex = 7;
            this.gbxGenre.TabStop = false;
            this.gbxGenre.Text = "Genre";
            // 
            // gbxMoviePoster
            // 
            this.gbxMoviePoster.Controls.Add(this.pbxMoviePoster);
            this.gbxMoviePoster.Location = new System.Drawing.Point(1008, 113);
            this.gbxMoviePoster.Name = "gbxMoviePoster";
            this.gbxMoviePoster.Size = new System.Drawing.Size(353, 312);
            this.gbxMoviePoster.TabIndex = 8;
            this.gbxMoviePoster.TabStop = false;
            this.gbxMoviePoster.Text = "Movie Poster";
            // 
            // gbxMovies
            // 
            this.gbxMovies.Controls.Add(this.movieDataGridView);
            this.gbxMovies.Controls.Add(this.btnSave);
            this.gbxMovies.Location = new System.Drawing.Point(32, 444);
            this.gbxMovies.Name = "gbxMovies";
            this.gbxMovies.Size = new System.Drawing.Size(1339, 384);
            this.gbxMovies.TabIndex = 9;
            this.gbxMovies.TabStop = false;
            this.gbxMovies.Text = "Movies";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MovieId";
            this.dataGridViewTextBoxColumn3.HeaderText = "MovieId";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Name";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Director";
            this.dataGridViewTextBoxColumn5.HeaderText = "Director";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Rating";
            this.dataGridViewTextBoxColumn6.HeaderText = "Rating";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Year";
            this.dataGridViewTextBoxColumn7.HeaderText = "Year";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Duration";
            this.dataGridViewTextBoxColumn8.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Synopsis";
            this.dataGridViewTextBoxColumn9.HeaderText = "Synopsis";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ImageURL";
            this.dataGridViewTextBoxColumn10.HeaderText = "ImageURL";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // genreBindingSource
            // 
            this.genreBindingSource.DataSource = typeof(CSharp_MovieRental.Genre);
            this.genreBindingSource.DataError += new System.Windows.Forms.BindingManagerDataErrorEventHandler(this.genreBindingSource_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "GenreId";
            this.dataGridViewTextBoxColumn1.HeaderText = "GenreId";
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
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // FormManageMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 953);
            this.Controls.Add(this.gbxMovies);
            this.Controls.Add(this.gbxMoviePoster);
            this.Controls.Add(this.gbxGenre);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormManageMovies";
            this.Text = "FormManageMovies";
            this.Click += new System.EventHandler(this.genreBindingNavigatorSaveItem_Click);
            ((System.ComponentModel.ISupportInitialize)(this.genreDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMoviePoster)).EndInit();
            this.gbxGenre.ResumeLayout(false);
            this.gbxMoviePoster.ResumeLayout(false);
            this.gbxMovies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource genreBindingSource;
        private System.Windows.Forms.DataGridView genreDataGridView;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private System.Windows.Forms.DataGridView movieDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem borrowMoviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnMoviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageMoviesToolStripMenuItem;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pbxMoviePoster;
        private System.Windows.Forms.GroupBox gbxGenre;
        private System.Windows.Forms.GroupBox gbxMoviePoster;
        private System.Windows.Forms.GroupBox gbxMovies;
    }
}