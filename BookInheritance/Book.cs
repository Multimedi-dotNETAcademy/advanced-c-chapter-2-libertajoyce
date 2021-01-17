namespace BookInheritance
{
    internal class Book
    {
        public int ISBN { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        private double _Price;

        public virtual double Price
        {
            get { return _Price; }
            set { _Price = value; }
        }

        public static Book AddUp(Book book1, Book book2)
        {
            Book result = new Book();
            result.Title = $"Omnibus of {book1.Title}, {book2.Title}";
            result.Author = $"Authors {book1.Author}, {book2.Author}";
            result.ISBN = 0;
            result.Price = (book1.Price + book2.Price) / 2;

            return result;
        }
        public override string ToString()
        {
            return $"{Title} - {Author} (ISBN:{ISBN}) {Price} euros)";
        }
       
    }
}