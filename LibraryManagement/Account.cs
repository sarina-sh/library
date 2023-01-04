namespace LibraryManagement
{
  public enum AccountStatus
  {
    Active ,
    CLosed
  }

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
    public AccountStatus accountStatus ;
    public string emailAddress ;
    public string number ;

    public Account(string name ,
                    string gender ,
                    int age ,
                    int id ,
                    string password ,
                    Role role ,
                    AccountStatus accountStatus ,
                    string emailAddress ,
                    string number)
    {
      this.name = name ;
      this.gender = gender ;
      this.age = age ;
      this.id = id ;
      this.password = password ;
      this.role = role ;
      this.accountStatus = accountStatus ;
      this.emailAddress = emailAddress ;
      this.number = number ;

    }

    public static bool resetPassword(string new_password) 
    {
        return true ;
    }

    public List<Catalog> searchByTitle(string title)
    {
      List<Catalog> Tcatalogs = new List<Catalog>();
      return Tcatalogs;
    }

    public List<Catalog> searchByAuthor(string author)
    {
      List<Catalog> Acatalogs = new List<Catalog>();
      return Acatalogs;
    }

    public List<Catalog> searchBySubject(string subject)
    {
      List<Catalog> Scatalogs = new List<Catalog>();
      return Scatalogs;
    }

    public List<Catalog> searchByPubDate(DateTime pubDate)
    {
      List<Catalog> Pcatalogs = new List<Catalog>();
      return Pcatalogs;
    }
  }


  public  bool resetPassword(string new_password) 
    {
      return true ;
    }
  
  public List<Catalog> searchByTitle(string title)
  {
    List<Catalog> Tcatalogs = new List<Catalog>();
    return Tcatalogs;
  }

  public List<Catalog> searchByAuthor(string author)
  {
    List<Catalog> Acatalogs = new List<Catalog>();
    return Acatalogs;
  }

  public List<Catalog> searchBySubject(string subject)
  {
    List<Catalog> Scatalogs = new List<Catalog>();
    return Scatalogs;
  }

  public List<Catalog> searchByPubDate(DateTime pubDate)
  {
    List<Catalog> Pcatalogs = new List<Catalog>();
    return Pcatalogs;
  }
}

}