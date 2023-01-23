using System;
namespace LibraryManagement
{
    class Program
    {
        static void MemberCli(Member member, Library library)
        {
            Console.WriteLine("welcome :)");
            Console.WriteLine("please enter the action..");
            string Action = Console.ReadLine();
            
            if (Action == "search book by title")
            {
                Console.WriteLine("please enter the title");
                string title = Console.ReadLine();
                library.searchByTitle(title);
            }
            
            if (Action == "search book by author")
            {
                Console.WriteLine("please enter the author");
                string author = Console.ReadLine();
                library.searchByAuthor(author);
            }
            
            if (Action == "search book by subject")
            {
                Console.WriteLine("please enter the subject");
                string subject = Console.ReadLine();
                library.searchBySubject(subject);
            }          
            
            if (Action == "search book by pubDate")
            {
                Console.WriteLine("please enter the pubDate");
                DateTime pubDate = DateTime.Parse(Console.ReadLine());
                library.searchByPubDate(pubDate);
            }

            if (Action == "add reservation")
            {
                Console.WriteLine("please enter the start date");
                DateTime startDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("please enter the due date");
                DateTime dueDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("please enter the bookId");
                int bookId = Int32.Parse(Console.ReadLine());
                for (int i = 0; i < library.allBooks.Count; i++)
                {
                    if (library.allBooks[i].bookID == bookId)
                    {
                        if (library.allBooks[i].status == BookStatus.Reserves)
                        {
                            Console.WriteLine("this book is reserved");
                        }
                        else
                        {
                            Reservation reserve = new Reservation(startDate, dueDate, library.allBooks[i]);
                            member.AddReservation(reserve);
                        }
                    }
                }
            }

            if (Action == "reserve book")
            {
                Console.WriteLine("please enter the start date");
                DateTime startDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("please enter the due date");
                DateTime dueDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("please enter the id : ");
                int memberId = Int32.Parse(Console.ReadLine());
                Console.WriteLine("please enter the bookId");
                int bookId = Int32.Parse(Console.ReadLine());
                library.reserveBook(bookId, memberId, startDate, dueDate);
            }

        }

        static void LibrarianCli(Librarian librarian, Library library)
        {
            Console.WriteLine("please enter the action..");
            string Action = Console.ReadLine();
            
            if (Action == "register member")
            {
                Console.WriteLine("please enter the name : ");
                string name = Console.ReadLine();
                Console.WriteLine("please enter the gender : ");
                string gender = Console.ReadLine();                        
                Console.WriteLine("please enter the age : ");
                int age = Int32.Parse(Console.ReadLine());
                Console.WriteLine("please enter the id : ");
                int id = Int32.Parse(Console.ReadLine());
                Console.WriteLine("please enter the emailAddress : ");
                string emailAddress = Console.ReadLine();
                Console.WriteLine("please enter the number : ");
                string number = Console.ReadLine();
                Member member = new Member(name, gender, age, id, emailAddress, number);
                library.registerMember(member);
            }

            if (Action == "remove member")
            {
                Console.WriteLine("please enter the id : ");
                int id = Int32.Parse(Console.ReadLine());
                library.removeMember(id);
            }

            if (Action == "get all members")
            {
                List<Member> allmembers = library.getAllMembers();
                for (int i = 0; i < allmembers.Count; i++)
                {
                    Console.WriteLine(allmembers[i].id);
                }
            }

            if (Action == "check active card")
            {
                Console.WriteLine("please enter the id : ");
                int id = Int32.Parse(Console.ReadLine());
                library.checkActiveCard(id);
            }
            
            if (Action == "search member by bookName")
            {
                Console.WriteLine("please enter the pubDate");
                string bookName = Console.ReadLine();
                library.searchByBookName(bookName);
            }
            
            if (Action == "search book by memberId")
            {
                Console.WriteLine("please enter the pubDate");
                int memberId = Int32.Parse(Console.ReadLine());
                library.searchByMember(memberId);
            }

            if (Action == "set InActive")
            {
                Console.WriteLine("please enter the id : ");
                int memberId = Int32.Parse(Console.ReadLine());
                for (int i = 0; i < library.members.Count; i++)
                {
                    if (library.members[i].id == memberId)
                    {
                        library.members[i].card.setInActive();
                    }
                }
            }
        }
        
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Fine f = new Fine(now) ;
    
            Librarian librarian = new Librarian("user" ,"Female", 22 ,2 ,
                "user@gmail.com" , "99999999999" );

            List<Book> allBooks = new List<Book>();
            List<Member> allMembers = new List<Member>();
            Library library = new Library(allBooks, allMembers);

            while (true)
            {
                Console.WriteLine("your action : ");
                string Action = Console.ReadLine();
                if (Action == "Login")
                {
                    Console.WriteLine("please enter the ID : ");
                    int Id = Int32.Parse(Console.ReadLine());
                    if (Id == librarian.id)
                    {
                        LibrarianCli(librarian, library);
                    }
                    else
                    {
                        for (int i = 0; i < library.members.Count; i++)
                        {
                            if (library.members[i].id == Id)
                            {
                                MemberCli(library.members[i], library);
                            }
                            else
                            {
                                Console.WriteLine("This person is not registered!");
                            }
                        }
                    }
                }
                else if (Action == "quit")
                {
                    Console.WriteLine("power off!");
                    return;
                }
            }
        }
    }
}