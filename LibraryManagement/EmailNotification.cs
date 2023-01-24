namespace LibraryManagement
{
    public class EmailNotification: Notification ,INotification
    {
        public string emailAddress;

        public EmailNotification(string content, string emailAddress):base(content){
            this.emailAddress = emailAddress;
        }

        public void Notify() {
            Console.WriteLine($"Email Notification Sended To {emailAddress}. ");
            Console.WriteLine($"Content Of Email: {content}. ");
            Console.WriteLine("-----------------------");
        }
    }
}