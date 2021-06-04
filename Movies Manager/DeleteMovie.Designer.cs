
namespace Movies_Manager
{
    partial class DeleteMovie
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
            this.combGenreDelMovie = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseDelMovie = new System.Windows.Forms.Button();
            this.btnClearDelMovie = new System.Windows.Forms.Button();
            this.btnAddDelMoive = new System.Windows.Forms.Button();
            this.txtOfficeEarningDelMovie = new System.Windows.Forms.TextBox();
            this.txtRottenDelMovie = new System.Windows.Forms.TextBox();
            this.txtDirectorDelMovie = new System.Windows.Forms.TextBox();
            this.txtYearDelMovie = new System.Windows.Forms.TextBox();
            this.txtMovieTitleDelMovie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAddMovie = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // combGenreDelMovie
            // 
            this.combGenreDelMovie.BackColor = System.Drawing.Color.White;
            this.combGenreDelMovie.FormattingEnabled = true;
            this.combGenreDelMovie.Items.AddRange(new object[] {
            "",
            "Animation",
            "Action",
            "Comedy",
            "Drama",
            "Horror",
            "Mystery",
            "Romance",
            "Science Fiction",
            "Western"});
            this.combGenreDelMovie.Location = new System.Drawing.Point(105, 170);
            this.combGenreDelMovie.Name = "combGenreDelMovie";
            this.combGenreDelMovie.Size = new System.Drawing.Size(100, 21);
            this.combGenreDelMovie.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCloseDelMovie);
            this.panel1.Controls.Add(this.btnClearDelMovie);
            this.panel1.Controls.Add(this.btnAddDelMoive);
            this.panel1.Location = new System.Drawing.Point(12, 277);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 50);
            this.panel1.TabIndex = 2;
            // 
            // btnCloseDelMovie
            // 
            this.btnCloseDelMovie.Location = new System.Drawing.Point(583, 13);
            this.btnCloseDelMovie.Name = "btnCloseDelMovie";
            this.btnCloseDelMovie.Size = new System.Drawing.Size(75, 23);
            this.btnCloseDelMovie.TabIndex = 2;
            this.btnCloseDelMovie.Text = "Close";
            this.btnCloseDelMovie.UseVisualStyleBackColor = true;
            this.btnCloseDelMovie.Click += new System.EventHandler(this.btnCloseDelMovie_Click);
            // 
            // btnClearDelMovie
            // 
            this.btnClearDelMovie.Location = new System.Drawing.Point(105, 13);
            this.btnClearDelMovie.Name = "btnClearDelMovie";
            this.btnClearDelMovie.Size = new System.Drawing.Size(75, 23);
            this.btnClearDelMovie.TabIndex = 1;
            this.btnClearDelMovie.Text = "Clear";
            this.btnClearDelMovie.UseVisualStyleBackColor = true;
            this.btnClearDelMovie.Click += new System.EventHandler(this.btnClearDelMovie_Click);
            // 
            // btnAddDelMoive
            // 
            this.btnAddDelMoive.Location = new System.Drawing.Point(10, 13);
            this.btnAddDelMoive.Name = "btnAddDelMoive";
            this.btnAddDelMoive.Size = new System.Drawing.Size(75, 23);
            this.btnAddDelMoive.TabIndex = 0;
            this.btnAddDelMoive.Text = "Delete";
            this.btnAddDelMoive.UseVisualStyleBackColor = true;
            this.btnAddDelMoive.Click += new System.EventHandler(this.btnDeleteDelMoive_Click);
            // 
            // txtOfficeEarningDelMovie
            // 
            this.txtOfficeEarningDelMovie.Location = new System.Drawing.Point(435, 238);
            this.txtOfficeEarningDelMovie.Name = "txtOfficeEarningDelMovie";
            this.txtOfficeEarningDelMovie.Size = new System.Drawing.Size(108, 20);
            this.txtOfficeEarningDelMovie.TabIndex = 7;
            // 
            // txtRottenDelMovie
            // 
            this.txtRottenDelMovie.Location = new System.Drawing.Point(231, 238);
            this.txtRottenDelMovie.Name = "txtRottenDelMovie";
            this.txtRottenDelMovie.Size = new System.Drawing.Size(60, 20);
            this.txtRottenDelMovie.TabIndex = 6;
            // 
            // txtDirectorDelMovie
            // 
            this.txtDirectorDelMovie.Location = new System.Drawing.Point(105, 130);
            this.txtDirectorDelMovie.Name = "txtDirectorDelMovie";
            this.txtDirectorDelMovie.Size = new System.Drawing.Size(100, 20);
            this.txtDirectorDelMovie.TabIndex = 4;
            // 
            // txtYearDelMovie
            // 
            this.txtYearDelMovie.Location = new System.Drawing.Point(105, 96);
            this.txtYearDelMovie.Name = "txtYearDelMovie";
            this.txtYearDelMovie.Size = new System.Drawing.Size(100, 20);
            this.txtYearDelMovie.TabIndex = 3;
            // 
            // txtMovieTitleDelMovie
            // 
            this.txtMovieTitleDelMovie.Location = new System.Drawing.Point(105, 63);
            this.txtMovieTitleDelMovie.Name = "txtMovieTitleDelMovie";
            this.txtMovieTitleDelMovie.Size = new System.Drawing.Size(236, 20);
            this.txtMovieTitleDelMovie.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Box Office Earning:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Rotten Tomatoes Score:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Genre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Director:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Year:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Movie Title:";
            // 
            // lblAddMovie
            // 
            this.lblAddMovie.AutoSize = true;
            this.lblAddMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMovie.Location = new System.Drawing.Point(32, 19);
            this.lblAddMovie.Name = "lblAddMovie";
            this.lblAddMovie.Size = new System.Drawing.Size(205, 24);
            this.lblAddMovie.TabIndex = 5;
            this.lblAddMovie.Text = "Delete Movie Screen";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(354, 60);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // DeleteMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 339);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.combGenreDelMovie);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtOfficeEarningDelMovie);
            this.Controls.Add(this.txtRottenDelMovie);
            this.Controls.Add(this.txtDirectorDelMovie);
            this.Controls.Add(this.txtYearDelMovie);
            this.Controls.Add(this.txtMovieTitleDelMovie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAddMovie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DeleteMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Delete Movie";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combGenreDelMovie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCloseDelMovie;
        private System.Windows.Forms.Button btnClearDelMovie;
        private System.Windows.Forms.Button btnAddDelMoive;
        private System.Windows.Forms.TextBox txtOfficeEarningDelMovie;
        private System.Windows.Forms.TextBox txtRottenDelMovie;
        private System.Windows.Forms.TextBox txtDirectorDelMovie;
        private System.Windows.Forms.TextBox txtYearDelMovie;
        private System.Windows.Forms.TextBox txtMovieTitleDelMovie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAddMovie;
        private System.Windows.Forms.Button btnSearch;
    }
}