namespace LibraryManagement
{
    public enum BookStatus
    {
      Available ,
      Reserves , 
      Lost,
    };

    public class Book
    {
        public int bookID ;
        public string title ;
        public string subject ;
        public string author ;
        public string publisher ;
        public string language ;
        public int numOfPages ;
        public int count ;

        public string barcode ;
        public bool isRefrence ;
        public double price ;
        public DateTime publicationDate ;
        public BookStatus status ;
        public DateTime borrowedTime ;
        public Catalog catalog ;

        public Book(int bookID, string title, string subject, string author,
                    string publisher, string language, int numOfPages, int count,
                    string barcode, bool isRefrence, double price, DateTime publicationDate,
                    BookStatus status, DateTime borrowedTime)
        {
            this.bookID = bookID;
            this.title = title;
            this.subject = subject;
            this.author = author;
            this.publisher = publisher;
            this.language = language;
            this.numOfPages = numOfPages;
            this.count = count;

            this.barcode = barcode;
            this.isRefrence = isRefrence;
            this.price = price;
            this.publicationDate = publicationDate;
            this.status = status;
            this.borrowedTime = borrowedTime;
            this.catalog = catalog;
        }

    }
}