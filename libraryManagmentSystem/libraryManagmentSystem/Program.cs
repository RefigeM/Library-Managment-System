
namespace libraryManagmentSystem;

internal class Program
{

    static void Main(string[] args)
    {
        LibraryLocation location = new LibraryLocation(2, 5);
        Book myBook1 = new Book(1, "bOoK1", BookJenre.Art, location, 2002);
        Book myBook2 = new Book(2, "BOOk2", BookJenre.Fiction, location, 2004);

        Book myBook3 = new Book(3, "booK3", BookJenre.Science, location, 1950);
        Book myBook4 = new Book(4, "bOoK4", BookJenre.NonFiction, location, 1999);

        Book[] books = {myBook1, myBook2, myBook3, myBook4};    
        Console.WriteLine($"title;{myBook1.Title},genre;{myBook1.Genre},location;{location}, year;{myBook1.PublicationYear}");
        LibraryHelper.ToTitleCase(myBook1);
        //Book.DisplayInfo();
        try
        {
            var book = books[1];
            Console.WriteLine($"Kitap ID: {book.Id}, Title: {book.Title}");

            var nonExistentBook = books[3]; 
        }
        catch (CustomBoxError ex)
        {
            Console.WriteLine(ex.Message); 
        }
    }


}

