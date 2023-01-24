namespace LibraryManagement
{
    public class SMSNotification: Notification ,INotification
    {
        public string number;

        public SMSNotification(string content, string number):base(content){
            this.number = number;
        }
        
        public void Notify() {
            Console.WriteLine($"SMS Notification Sended To {number}. ");
            Console.WriteLine($"Content Of SMS: {content}. ");
            Console.WriteLine("------------------------");
        }
    }
}