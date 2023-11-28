namespace Exercises.Items
{
    public class OOPProj21 : ObjectOrientedProgrammingProj
    {
        public override string Description => "https://raisanenmarkus.github.io/csharp/part4/4/ EXERCISE 4-21: Book Class";
        class BookInformation
        {

            private string _name;
            private int _page;
            private int _publicationYear;

            public string Name { get { return _name; } set { _name = value; } }

            public BookInformation(string name, int page, int publicationYear)
            {
                _name = name;
                _page = page;
                _publicationYear = publicationYear;
            }

            public override string ToString()
            {
                // write code here
                return $"{_name}, {_page} pages, {_publicationYear}";
            }

        }

        public override void Run()
        {
            List<BookInformation> books = new();
            Console.WriteLine("Input book information. Press Enter to exit: ");
            while (true)
            {
                Console.Write("Name of book: ");
                string bookName = Console.ReadLine().Trim();

                if (string.IsNullOrEmpty(bookName))
                {
                    break;
                }

                Console.WriteLine("Pages: "); 
                int bookPage;
                while (!int.TryParse(Console.ReadLine(), out bookPage))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number for pages.");
                }

                Console.WriteLine("Publication year: ");
                int publicationYear;
                while (!int.TryParse(Console.ReadLine(), out publicationYear))
                {
                    Console.WriteLine("Invalid input. Please enter a valid year.");
                }

                BookInformation newBook = new(name: bookName, page: bookPage, publicationYear);
                books.Add(newBook);
            }

            Console.WriteLine("What information will be printed? ");
            var keyWord = Console.ReadLine();
            if (keyWord.ToLower() == "everything")
            {
                foreach (var book in books)
                {
                    Console.WriteLine(book);
                }
            }
            else if (keyWord.ToLower() == "title")
            {
                foreach (var book in books)
                {
                    Console.WriteLine(book.Name);
                }
            }
            else return;

        }
    }
}
