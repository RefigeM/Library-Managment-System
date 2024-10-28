namespace libraryManagmentSystem
{
    internal class DVD: LibraryItem
    {
        protected DVD(string title, int? PublicationYear = null) : base(title, PublicationYear)
        {
            Title = title;
            this.PublicationYear = PublicationYear;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("Bu DVD classidir.");
        }
    }
}
