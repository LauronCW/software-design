namespace lab3
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnShowInfo = new Button();
            lblTitle = new Label();
            lblAuthor = new Label();
            lblExtra = new Label();
            listBooks = new ListBox();
            btnShowAll = new Button();
            Title = new Label();
            Author = new Label();
            Issue = new Label();
            SuspendLayout();
            // 
            // btnShowInfo
            // 
            btnShowInfo.Location = new Point(138, 192);
            btnShowInfo.Name = "btnShowInfo";
            btnShowInfo.Size = new Size(94, 29);
            btnShowInfo.TabIndex = 0;
            btnShowInfo.Text = "Show Info";
            btnShowInfo.UseVisualStyleBackColor = true;
            btnShowInfo.Click += btnShowInfo_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(138, 85);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(41, 20);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Title:";
            lblTitle.Click += btnShowInfo_Click;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(138, 118);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(57, 20);
            lblAuthor.TabIndex = 2;
            lblAuthor.Text = "Author:";
            lblAuthor.Click += btnShowInfo_Click;
            // 
            // lblExtra
            // 
            lblExtra.AutoSize = true;
            lblExtra.Location = new Point(138, 151);
            lblExtra.Name = "lblExtra";
            lblExtra.Size = new Size(61, 20);
            lblExtra.TabIndex = 3;
            lblExtra.Text = "Issue # :";
            lblExtra.Click += btnShowInfo_Click;
            // 
            // listBooks
            // 
            listBooks.FormattingEnabled = true;
            listBooks.Location = new Point(138, 247);
            listBooks.Name = "listBooks";
            listBooks.Size = new Size(573, 324);
            listBooks.TabIndex = 4;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(138, 587);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(94, 29);
            btnShowAll.TabIndex = 5;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(185, 85);
            Title.Name = "Title";
            Title.Size = new Size(76, 20);
            Title.TabIndex = 6;
            Title.Text = "Book Title";
            // 
            // Author
            // 
            Author.AutoSize = true;
            Author.Location = new Point(201, 118);
            Author.Name = "Author";
            Author.Size = new Size(49, 20);
            Author.TabIndex = 7;
            Author.Text = "Name";
            // 
            // Issue
            // 
            Issue.AutoSize = true;
            Issue.Location = new Point(205, 151);
            Issue.Name = "Issue";
            Issue.Size = new Size(99, 20);
            Issue.TabIndex = 8;
            Issue.Text = "Issue Number";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 660);
            Controls.Add(Issue);
            Controls.Add(Author);
            Controls.Add(Title);
            Controls.Add(btnShowAll);
            Controls.Add(listBooks);
            Controls.Add(lblExtra);
            Controls.Add(lblAuthor);
            Controls.Add(lblTitle);
            Controls.Add(btnShowInfo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnShowInfo;
        private Label lblTitle;
        private Label lblAuthor;
        private Label lblExtra;
        private ListBox listBooks;
        private Button btnShowAll;
        private Label Title;
        private Label Author;
        private Label Issue;
    }
}
