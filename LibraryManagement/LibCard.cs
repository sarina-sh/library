namespace LibraryManagement
{
    public class LibCard
    {
        public int cardID ;
        public string name ;
        public DateTime publishDate ;
        public bool active;

        public LibCard(int cardID, string name, bool active)
        {
            this.cardID = cardID;
            this.name = name;
            this.active = active;
        }

        public static bool CheckActive(int cardID){
            
        }
    }
}