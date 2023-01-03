namespace LibraryManagement
{
    public class SMSNotification: Notification ,INotification
    {
        public string number;

        public SMSNotification(string content, string number):base(content){
            this.number = number;
        }
        
        public void Notify() {
            // input = Member member
            // sms.send(member.phoneNumber, this.content)
        }
    }
}