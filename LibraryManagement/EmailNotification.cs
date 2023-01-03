namespace LibraryManagement
{
    public class EmailNotification: Notification ,INotification
    {

        public EmailNotification(string content):base(content){

        }

        public void Notify() {
            // input = Member member
            // email.send(member.email, this.content)
        }
    }
}