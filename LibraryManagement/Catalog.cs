namespace LibraryManagement
{
    
    public class Catalog
    {
        public DateTime creationDate ;
        public string bookTitle ;
        public string bookAuthor ;
        public string bookSubject ;
        public DateTime bookPublicationDate ;

        public Catalog(
            
            DateTime creationDate ,
            string bookTitle ,
            string bookAuthor ,
            string bookSubject ,
            DateTime bookPublicationDate 

        )
        {
            this.creationDate = creationDate ;
            this.bookTitle = bookTitle ;
            this.bookAuthor = bookAuthor ;
            this.bookSubject = bookSubject ;
            this.bookPublicationDate = bookPublicationDate ;
        }
        
    }

}




