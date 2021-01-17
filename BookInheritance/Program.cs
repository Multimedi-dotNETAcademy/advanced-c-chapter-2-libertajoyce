using System;

namespace BookInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            TextBook book1 = new TextBook { Author = "JK Rowling", Title = "Harry Potter", ISBN = 5544 , Price = 40};
            CoffeeTableBook book2 = new CoffeeTableBook { Author = "Tolkien", Title = "Lord of the rings", ISBN = 5533 , Price = 80};
            Book omni = Book.AddUp(book1,book2); //The method instantiates
            Console.WriteLine(omni.ToString());
        }
    }
}
