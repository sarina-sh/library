namespace LibraryManagement
{
    class Book
    {
        private int bookID ;
        private string titile ;
        private string subject ;
        private string author ;
        private string publisher ;
        private string language ;
        private int numOfPages ;

        public Book(int bookID, string titile, string subject, string author, string publisher, string language, int numOfPages)
        {
            bookID = this.bookID;
            titile = this.titile;
            subject = this.subject;
            author = this.author;
            publisher = this.publisher;
            language = this.language;
            numOfPages = this.numOfPages;
        }

        public static list<string> getInfo(titile){
            return null;
        }
    }
}