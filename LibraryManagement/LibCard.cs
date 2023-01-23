namespace LibraryManagement
{
    public class LibCard
    {
        public int cardID ;
        public DateTime publishDate ;
        public bool active = true;

        public LibCard(int cardID, DateTime publishDate, bool active)
        {
            this.cardID = cardID;
            this.publishDate = publishDate;
            this.active = active;
        }

        public void setInActive()
        {
            active = false;
        }
    
        public void setActive()
        {
            active = true;
        }

    }
}