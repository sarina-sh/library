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
            return books;
        }
    }
}

