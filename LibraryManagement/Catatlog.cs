namespace LibraryManagement
{
    public class Catalog
    {
        public DateTime creationDate ;
        public string bookTitle ;
        public int totalBooks ;
        public string bookAuthor ;
        public string bookSubject ;
        public DateTime bookPublicationDate ;

        public Catalog(
            
            DateTime creationDate ,
            string bookTitle ,
            int totalBooks ,
            string bookAuthor ,
            string bookSubject ,
            DateTime bookPublicationDate 

        )
        {
            this.creationDate = creationDate ;
            this.bookTitle = bookTitle ;
            this.totalBooks = totalBooks ;
            this.bookAuthor = bookAuthor ;
            this.bookSubject = bookSubject ;
            this.bookPublicationDate = bookPublicationDate ;
        }


        public bool updateCatalog() 
        {
            return true ;
        }
    }

}