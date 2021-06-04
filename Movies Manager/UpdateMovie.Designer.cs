
namespace Movies_Manager
{
    partial class UpdateMovie
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
            this.combGenreUpdateMovie = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseUpdateMovie = new System.Windows.Forms.Button();
            this.btnClearUpdateMovie = new System.Windows.Forms.Button();
            this.btnUpdateMoive = new System.Windows.Forms.Button();
            this.txtOfficeEarningUpdateMovie = new System.Windows.Forms.TextBox();
            this.txtRottenUpdateMovie = new System.Windows.Forms.TextBox();
            this.txtDirectorUpdateMovie = new System.Windows.Forms.TextBox();
            this.txtYearUpdateMovie = new System.Windows.Forms.TextBox();
            this.txtMovieTitleUpdateMovie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAddMovie = new System.Windows.Forms.Label();
            this.btnSearchUpdateMovie = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // combGenreUpdateMovie
            // 
            this.combGenreUpdateMovie.BackColor = System.Drawing.Color.White;
            this.combGenreUpdateMovie.FormattingEnabled = true;
            this.combGenreUpdateMovie.Items.AddRange(new object[] {
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
            this.combGenreUpdateMovie.Location = new System.Drawing.Point(105, 170);
            this.combGenreUpdateMovie.Name = "combGenreUpdateMovie";
            this.combGenreUpdateMovie.Size = new System.Drawing.Size(100, 21);
            this.combGenreUpdateMovie.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCloseUpdateMovie);
            this.panel1.Controls.Add(this.btnClearUpdateMovie);
            this.panel1.Controls.Add(this.btnUpdateMoive);
            this.panel1.Location = new System.Drawing.Point(12, 277);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 50);
            this.panel1.TabIndex = 7;
            // 
            // btnCloseUpdateMovie
            // 
            this.btnCloseUpdateMovie.Location = new System.Drawing.Point(583, 13);
            this.btnCloseUpdateMovie.Name = "btnCloseUpdateMovie";
            this.btnCloseUpdateMovie.Size = new System.Drawing.Size(75, 23);
            this.btnCloseUpdateMovie.TabIndex = 2;
            this.btnCloseUpdateMovie.Text = "Close";
            this.btnCloseUpdateMovie.UseVisualStyleBackColor = true;
            this.btnCloseUpdateMovie.Click += new System.EventHandler(this.btnCloseUpdateMovie_Click);
            // 
            // btnClearUpdateMovie
            // 
            this.btnClearUpdateMovie.Location = new System.Drawing.Point(105, 13);
            this.btnClearUpdateMovie.Name = "btnClearUpdateMovie";
            this.btnClearUpdateMovie.Size = new System.Drawing.Size(75, 23);
            this.btnClearUpdateMovie.TabIndex = 1;
            this.btnClearUpdateMovie.Text = "Clear";
            this.btnClearUpdateMovie.UseVisualStyleBackColor = true;
            this.btnClearUpdateMovie.Click += new System.EventHandler(this.btnClearUpdateMovie_Click);
            // 
            // btnUpdateMoive
            // 
            this.btnUpdateMoive.Location = new System.Drawing.Point(10, 13);
            this.btnUpdateMoive.Name = "btnUpdateMoive";
            this.btnUpdateMoive.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateMoive.TabIndex = 0;
            this.btnUpdateMoive.Text = "Update";
            this.btnUpdateMoive.UseVisualStyleBackColor = true;
            this.btnUpdateMoive.Click += new System.EventHandler(this.btnUpdateMoive_Click);
            // 
            // txtOfficeEarningUpdateMovie
            // 
            this.txtOfficeEarningUpdateMovie.Location = new System.Drawing.Point(435, 238);
            this.txtOfficeEarningUpdateMovie.Name = "txtOfficeEarningUpdateMovie";
            this.txtOfficeEarningUpdateMovie.Size = new System.Drawing.Size(108, 20);
            this.txtOfficeEarningUpdateMovie.TabIndex = 6;
            // 
            // txtRottenUpdateMovie
            // 
            this.txtRottenUpdateMovie.Location = new System.Drawing.Point(231, 238);
            this.txtRottenUpdateMovie.Name = "txtRottenUpdateMovie";
            this.txtRottenUpdateMovie.Size = new System.Drawing.Size(60, 20);
            this.txtRottenUpdateMovie.TabIndex = 5;
            // 
            // txtDirectorUpdateMovie
            // 
            this.txtDirectorUpdateMovie.Location = new System.Drawing.Point(105, 130);
            this.txtDirectorUpdateMovie.Name = "txtDirectorUpdateMovie";
            this.txtDirectorUpdateMovie.Size = new System.Drawing.Size(100, 20);
            this.txtDirectorUpdateMovie.TabIndex = 3;
            // 
            // txtYearUpdateMovie
            // 
            this.txtYearUpdateMovie.Location = new System.Drawing.Point(105, 96);
            this.txtYearUpdateMovie.Name = "txtYearUpdateMovie";
            this.txtYearUpdateMovie.Size = new System.Drawing.Size(100, 20);
            this.txtYearUpdateMovie.TabIndex = 2;
            // 
            // txtMovieTitleUpdateMovie
            // 
            this.txtMovieTitleUpdateMovie.Location = new System.Drawing.Point(105, 63);
            this.txtMovieTitleUpdateMovie.Name = "txtMovieTitleUpdateMovie";
            this.txtMovieTitleUpdateMovie.Size = new System.Drawing.Size(236, 20);
            this.txtMovieTitleUpdateMovie.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Box Office Earning:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Rotten Tomatoes Score:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Genre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Director:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Year:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Movie Title:";
            // 
            // lblAddMovie
            // 
            this.lblAddMovie.AutoSize = true;
            this.lblAddMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMovie.Location = new System.Drawing.Point(32, 19);
            this.lblAddMovie.Name = "lblAddMovie";
            this.lblAddMovie.Size = new System.Drawing.Size(211, 24);
            this.lblAddMovie.TabIndex = 19;
            this.lblAddMovie.Text = "Update Movie Screen";
            // 
            // btnSearchUpdateMovie
            // 
            this.btnSearchUpdateMovie.Location = new System.Drawing.Point(357, 59);
            this.btnSearchUpdateMovie.Name = "btnSearchUpdateMovie";
            this.btnSearchUpdateMovie.Size = new System.Drawing.Size(75, 23);
            this.btnSearchUpdateMovie.TabIndex = 1;
            this.btnSearchUpdateMovie.Text = "Search";
            this.btnSearchUpdateMovie.UseVisualStyleBackColor = true;
            this.btnSearchUpdateMovie.Click += new System.EventHandler(this.btnSearchUpdateMovie_Click);
            // 
            // UpdateMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 339);
            this.Controls.Add(this.btnSearchUpdateMovie);
            this.Controls.Add(this.combGenreUpdateMovie);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtOfficeEarningUpdateMovie);
            this.Controls.Add(this.txtRottenUpdateMovie);
            this.Controls.Add(this.txtDirectorUpdateMovie);
            this.Controls.Add(this.txtYearUpdateMovie);
            this.Controls.Add(this.txtMovieTitleUpdateMovie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAddMovie);
            this.Name = "UpdateMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Movie";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combGenreUpdateMovie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCloseUpdateMovie;
        private System.Windows.Forms.Button btnClearUpdateMovie;
        private System.Windows.Forms.Button btnUpdateMoive;
        private System.Windows.Forms.TextBox txtOfficeEarningUpdateMovie;
        private System.Windows.Forms.TextBox txtRottenUpdateMovie;
        private System.Windows.Forms.TextBox txtDirectorUpdateMovie;
        private System.Windows.Forms.TextBox txtYearUpdateMovie;
        private System.Windows.Forms.TextBox txtMovieTitleUpdateMovie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAddMovie;
        private System.Windows.Forms.Button btnSearchUpdateMovie;
    }
}