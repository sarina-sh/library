using System;
using Xunit;
using LibraryManagement;

namespace LibraryManagementTests{
    public class NotificationTest
    {
        [Fact]
        public void SMS_Notif(){
            SMSNotification sms_notif = new SMSNotification("You reserved this book." , "123456789");
            Assert.Equal(sms_notif.number,"123456789");
        }
    }
}
