namespace libraryManagmentSystem
{
    public class Book : LibraryItem
    {
       //public static int _counter;
        public int Id { get; set; }

        public BookJenre Genre { get; set; } //enum'in tipini clasinin adi olaraqq yazdiq
        public LibraryLocation Location { get; set; } //struct'in tipini clasinin adi olaraq yazdiq
        public Book(int id, string title, BookJenre jenre, LibraryLocation location, int? PublicationYear = null) :base(title, PublicationYear) 
        {

            Id = id;
            Title = title;
            this.PublicationYear = PublicationYear;
            Genre= jenre;
            Location = location;

        }
        public override  void DisplayInfo() 
        {
            Console.WriteLine($"title;{Title},genre;{Genre}, year;{PublicationYear}");

        }


    }
}
