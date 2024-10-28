using static System.Reflection.Metadata.BlobBuilder;

namespace libraryManagmentSystem
{
    public class LibraryHelper
    {
        public static void ToTitleCase(LibraryItem item)
        {
            if (item != null)
            {
                item.Title = char.ToUpper(item.Title[0]) + item.Title.Substring(1).ToLower();
                Console.WriteLine(item.Title);

            }
        }
        public static void CalculateAge()
        {
          private LibraryItem[] books = new LibraryItem[4];

        //int age = DateTime.Now.Year - item

        }

        public class LibraryCatalog
        {
            private LibraryItem[] books = new LibraryItem[4]; 

            
            public LibraryItem this[int id]
            {
                get
                {
                    foreach (var item in books)
                    {
                        if (item != null && item.Id ==id)
                        {
                            return item;
                        }
                        else { Console.WriteLine("bu id'li kitab yoxdur"); }
                    }
                    return null; 
                }
            }

        }
    }
}


