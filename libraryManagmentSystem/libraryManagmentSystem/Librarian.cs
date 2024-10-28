namespace libraryManagmentSystem
{
    public class Librarian : Person
    {
        public Librarian(string name) : base(name)
        {
        }

        public DateTime HireDate { get; set; }
    }
}
