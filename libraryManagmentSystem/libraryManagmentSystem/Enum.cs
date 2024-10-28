namespace libraryManagmentSystem
{
    public enum BookJenre
    {
            Fiction,
            NonFiction,
            Science, 
            Art
    }
    public struct LibraryLocation 
    {
        public int Aisle { get; set; }
        public int Shelf { get; set; }
        public LibraryLocation(int aisle, int shelf)
        {
            Aisle = aisle;
            Shelf = shelf;
        }

    }
}
