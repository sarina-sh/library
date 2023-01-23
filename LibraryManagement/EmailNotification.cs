namespace LibraryManagement
{
    public class EmailNotification: Notification ,INotification
    {
        public string emailAddress;

        public EmailNotification(string content, string emailAddress):base(content){
            this.emailAddress = emailAddress;
        }

        public void Notify() {
            // input = Member member
            // email.send(member.email, this.content)
            Console.Write($"Email Notification Sended To {emailAddress}.");
            Console.Write($"Content Of Email: {content}");
        }
    }
}