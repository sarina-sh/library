namespace LibraryManagement
{
    public class Account
  {
    public string name ;
    public string gender ;
    public int age ;
    public int id ;
    public DateTime dueDate ;
    public string emailAddress ;
    public string number ;

    public Account(string name ,
                    string gender ,
                    int age ,
                    int id ,
                    string emailAddress ,
                    string number)
    {
      this.name = name ;
      this.gender = gender ;
      this.age = age ;
      this.id = id ;
      this.emailAddress = emailAddress ;
      this.number = number ;

    }
    
}


}