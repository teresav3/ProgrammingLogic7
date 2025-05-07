using System.Runtime.CompilerServices;

class Book
{
    private string title;
    private string author;
    
    public Book()  // Default Constructor
    {
        title = "Unknown Title";
        author = "Unknown Author";
    }

    public string GetTitle()
    {
        return title;
    }
    public void SetTitle(string newTitle)
    {
        title = newTitle;
    }
    public Book(string newTitle, string newAuthor)  // Parameterized Constructor
    {
        title = newTitle;
        author = newAuthor;
    }

    public Book(string newTitle)  // Single Parameter Constructor
    {
        title = newTitle;
        author = "Unknown Author";
    }
    public string GetAuthor()
    {
        return author;  
    }
    public void SetAuthor(string newAuthor)
    {
        author = newAuthor;
    }
  }
  class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book();
        Console.WriteLine(book1.GetTitle());  // Output: Unknown Title
    
        book1.SetTitle("C# Fundamentals");
        Console.WriteLine(book1.GetTitle()); // Output: C# Fundamentals

        Book book2 = new Book("Advanced C#");
        Console.WriteLine(book2.GetTitle());  // Output: Advanced C#

        Book book3 = new Book("C# in Depth", "Jon Skeet");
        Console.WriteLine(book3.GetTitle());  // Output: C# in Depth

        book3.SetAuthor("New Author");
        Console.WriteLine(book3.GetAuthor());  // Output: New Author

        book3.SetTitle("C# in Action");
        Console.WriteLine(book3.GetTitle());  // Output: C# in Action


    }
}
