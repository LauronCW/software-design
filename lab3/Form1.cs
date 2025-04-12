namespace lab3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public class Book
		{
			public string Title { get; set; }
			public string Author { get; set; }
			public virtual string GetInfo()
			{
				return $"{Title} by {Author}";
			}
		}


		//SUBCLASSESS
		public class Magazine : Book
		{
			public int IssueNumber { get; set; }
			public override string GetInfo()
			{
				return $"{Title} - Issue {IssueNumber} by {Author}";
			}

		}


		

		public class Ebook : Book
		{
			public double FileSizeMB { get; set; }
            public override string GetInfo()
            {
				return $"{Title} (Ebook) - {FileSizeMB}MB by {Author}";
            }
        }


		public class Textbook : Book
		{
			public string Subject { get; set; }
            public override string GetInfo()
            {
				return $"{Title} (Textbook) - Subject: {Subject} by {Author}";
            }
        }



		public class Audiobook : Book
		{
			public string Narrator { get; set; }
			public double DurationHours { get; set; }
            public override string GetInfo()
            {
				return $"{Title} (Audiobook) - Narrated by {Narrator},and written by {Author}, {DurationHours} hrs";
            }
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            Book myBook = new Magazine
            {
                Title = "Dune Messiah",
                Author = "Frank Herbert",
                IssueNumber = 23
            };
			//MessageBox.Show(myBook.GetInfo());
			Title.Text = " " + myBook.Title;
            Author.Text = myBook.Author;
            //Issue.Text = myBook.IssueNumber;
            Issue.Text = ((Magazine)myBook).IssueNumber.ToString();

        }


        private void btnShowAll_Click(object sender, EventArgs e) {
			Book[] books = new Book[]
			{
				new Book { Title = "- To Kill A Mockingbird", Author = "Harper Lee"},
				new Magazine { Title = "- National Geographic: Cosmos", Author ="Ann Druyan", IssueNumber = 3},
				new Ebook { Title ="- Divergent", Author ="Veronica Roth", FileSizeMB = 4.5},
				new Textbook { Title ="- Astrophysics 101", Author ="Dr.Brian Cox", Subject = "Physics"},
				new Audiobook { Title ="- What's Up?", Author = "Ben Stiller", Narrator ="Adam Scott", DurationHours = 4.3}
			};
			DisplayBooks(books);
		}
        public void DisplayBooks(Book[] books)
        {
            listBooks.Items.Clear();
            foreach (Book book in books)
            {
                listBooks.Items.Add(book.GetInfo());
            }

        }
    }
}
