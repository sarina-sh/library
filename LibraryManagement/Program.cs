using System;
namespace LibraryManagement
{
    class Program
    {
        static void MemberCli(Member member)
        {
            
        }

        static void LibrarianCli(Librarian librarian)
        {
            
        }
        
        static void Main(string[] args)
        {
            
            DateTime now = DateTime.Now;
            Fine f = new Fine(now) ;

            Librarian librarian = new Librarian("user" ,"Female", 22 ,2  ,
            "123"  , "user@gmail.com" , "99999999999" );

            while (true)
            {
                Console.WriteLine("your action : ");
                string Action = Console.ReadLine();
                if (Action == "Login")
                {
                    int Id = Int32.Parse(Console.ReadLine());
                    if (Id == librarian.id)
                    {
                        LibrarianCli(librarian);
                    }
                    else
                    {
                        Console.WriteLine("welcome :)");
                        Console.WriteLine("please enter your name : ");
                        string name = Console.ReadLine();
                        Console.WriteLine("please enter your gender : ");
                        string gender = Console.ReadLine();                        
                        Console.WriteLine("please enter your age : ");
                        int age = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("please enter your id : ");
                        int id = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("please enter your password : ");
                        string password = Console.ReadLine();
                        Console.WriteLine("please enter your emailAddress : ");
                        string emailAddress = Console.ReadLine();
                        Console.WriteLine("please enter your number : ");
                        string number = Console.ReadLine();
                        
                        Member member = new Member(name, gender, age, id, password, emailAddress, number);
                        MemberCli(member);

                    }
                }
                else if (Action == "Logout")
                {
                    Console.WriteLine("you are logged out..");
                }
            }
            
        }
    }
}