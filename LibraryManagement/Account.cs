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
    public string password ;

    public Account(string name ,
                    string gender ,
                    int age ,
                    int id ,
                    string emailAddress ,
                    string number , string password )
    {
      this.name = name ;
      this.gender = gender ;
      this.age = age ;
      this.id = id ;
      this.emailAddress = emailAddress ;
      this.number = number ;
      this.password =   password  ;

    }

    public static bool resetPassword(string current_password ,string new_password  ) 
    {
        if (current_password == this.password )
        {
          this.password = new_password ;
        }
        Console.WriteLine($"");
          
          return true ;
    }   
}
}