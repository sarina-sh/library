namespace LibraryManagement
{
    private enum BookStatus
    {
      Available ,
      Reserves , 
      Lost,
    };

    class bookItem: Book
    {
        private string barcode ;
        private bool isRefrence ;
        private double price ;
        private DateTime publicationDate ;
        private BookStatus status ;
        private DateTime borrowed ;

        public bookItem(string barcode, bool isRefrence, double price, DateTime publicationDate, BookStatus status, DateTime borrowed)
        {
            barcode = this.barcode;
            isRefrence = this.isRefrence;
            price = this.price;
            publicationDate = this.publicationDate;
            status = this.status;
            borrowed = this.borrowed;
        }
    }
}