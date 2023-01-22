namespace LibraryManagement
{
  public enum Role
  {
    Member ,
    Librarian
  };

  public class Account
  {
    public string name ;
    public string gender ;
    public int age ;
    public int id ;
    public DateTime dueDate ;
    public string password ;
    public Role role ;
    public string emailAddress ;
    public string number ;

    public Account(string name ,
                    string gender ,
                    int age ,
                    int id ,
                    string password ,
                    Role role ,
                    string emailAddress ,
                    string number)
    {
      this.name = name ;
      this.gender = gender ;
      this.age = age ;
      this.id = id ;
      this.password = password ;
      this.role = role ;
      this.emailAddress = emailAddress ;
      this.number = number ;

    }

    public static bool resetPassword(string new_password) 
    {
        return true ;
    }
    
}


}