namespace LibraryManagement
{
    class BookManager
    {
        private static BookManager instance;

        private List<Book> books = new List<Book>();

        BookManager getInstance() {
            if (instance == null) { 
                instance = BookManager();
            }
            return instance;
        }

//         public void getBooks() {
//             Console.Write("All Books Are:");

//             for(int i=0; i<books.count; i++)
//               Console.WriteLine($"{i+1} => {books[i]}");
//         }

//         public void getExistingBook()
//         {
//           Console.Write("All Available Books Are:");

          for(int i=0; i<books.count; i++)
            if (books[i].status == BookStatus.Available)
              Console.WriteLine($"{i+1} => {books[i]}");
        }
        public static bool addBook(Book book){
          books.Add(book)

          Console.Write("successfully")
          return true ;
        }
        public static bool removeBook(int bookID){
          for(int i=0; i<books.count; i++)
            if (books[i].bookID == bookID)
              books.RemoveAt(i)

          Console.Write("successfully")
          return true ;
        }

    }
}

