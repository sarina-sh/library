namespace LibraryManagement
{
    public class Notification
    {
        public int notificationID ;
        public DateTime createDate ;
        public string content ;

        public Notification(string content)
        {
            this.content = content;
        }
    }
}