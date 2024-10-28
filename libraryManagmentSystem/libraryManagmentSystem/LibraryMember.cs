namespace libraryManagmentSystem
{
    public sealed class LibraryMember :Person
    {
        public LibraryMember(string name) : base(name)
        {
        }
        public DateTime MembershipDate { get; set; }
    }
}
