namespace libraryManagmentSystem
{
    public class Magazine: LibraryItem
    {
        protected Magazine(string title, int? PublicationYear = null) : base(title, PublicationYear)
        {
            Title = title;
            this.PublicationYear = PublicationYear;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("Bu Magazine classidir.");

        }
    }
}
