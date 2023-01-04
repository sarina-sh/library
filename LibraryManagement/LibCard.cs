namespace LibraryManagement
{
    public class LibCard
    {
        public int cardID ;
        public string name ;
        public DateTime publishDate ;
        // public bool active;

        public LibCard(int cardID, string name, DateTime publishDate)
        {
            this.cardID = cardID;
            this.name = name;
            this.publishDate = publishDate;
            // this.active = active;
        }

        public static bool CheckActive(int cardID){
            Console.Write("This cars is active.");
            return true;
        }
    }
}