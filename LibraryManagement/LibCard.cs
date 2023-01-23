namespace LibraryManagement
{
    public class LibCard
    {
        public int cardID ;
        public string name ;
        public DateTime publishDate ;
        public bool active;

        public LibCard(int cardID, string name, DateTime publishDate, bool active)
        {
            this.cardID = cardID;
            this.name = name;
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