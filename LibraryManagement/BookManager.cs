
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
        public List<Book> getBooks() {
            Console.Write("All Books return");
            return books;
        }
        public static List<Book> getExistingBook()
        {
          return books ;
        }
        public static bool addBook(Book book){
          return true ;
        }
        public static bool removeBook(int bookID){
          return true ;
        }

    }
}

