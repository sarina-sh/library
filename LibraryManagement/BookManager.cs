namespace LibraryManagement
{
    public class BookManager
    {
        public static BookManager instance;

        public List<Book> books = new List<Book>();

        BookManager getInstance() {
            if (instance == null) { 
                instance = BookManager();
            }
            return instance;
        }

        public List<Book> getBooks() {
            return books;
        }

        public static List<Book> getExistingBook()
        {
          List<Book> books = new List<Book>();
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

