namespace libraryManagmentSystem
{
    public abstract class LibraryItem
    {
        public string Title { get; set; }
        public int? PublicationYear { get; set; }
        public int Id { get; internal set; }

        protected LibraryItem(string title,int? PublicationYear =null)
        {
            Title=title;
            this.PublicationYear = PublicationYear; 
        }
        abstract  public void DisplayInfo();

    }
}
