using System;

public class Book1
{
    public string title;
    public string author;

    public Book1(string title, string author)
    {
        this.title = title; 
        this.author = author;
    }

    public Book1()
    {

    }

}

public class Book2 : Book1
{
    public Book2(string title, string author)
    {
        this.title = title;
        this.author = author;
    }
}
public class BooksMain
{
    public static void Main(string[] args)
    {
        string title1;
        string title2;
        string author1;
        string author2;

        Console.WriteLine("Insert the information of two books :");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Information of book 1 :");
        Console.Write("Input name of the book: ");
        title1 = Console.ReadLine();
        Console.Write("Input the author: ");
        author1 = Console.ReadLine();
        Console.WriteLine("Information of book 2 :");
        Console.Write("Input name of the book: ");
        title2 = Console.ReadLine();
        Console.Write("Input the author: ");
        author2 = Console.ReadLine();

        Book1 book1 = new Book1(title1,author1);
        Book2 book2 = new Book2(title2,author2);
    }
}