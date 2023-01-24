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
                Console.WriteLine("please enter the memberId");
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
                        Console.WriteLine($"member by id : {library.members[i].id} -> " +
                                          $"your card is {library.members[i].card.active}");
                    }
                }
            }

            if (Action == "add book")
            {
                Console.WriteLine("please enter the id");
                int id = Int32.Parse(Console.ReadLine());
                Console.WriteLine("please enter the title");
                string title = Console.ReadLine();
                Console.WriteLine("please enter the subject");
                string subject = Console.ReadLine();
                Console.WriteLine("please enter the author");
                string author = Console.ReadLine();
                Console.WriteLine("please enter the publisher");
                string publisher = Console.ReadLine();
                Console.WriteLine("please enter the language");
                string language = Console.ReadLine();
                Console.WriteLine("please enter the numOfPage");
                int numOfPage = Int32.Parse(Console.ReadLine());
                Console.WriteLine("please enter the count");
                int count = Int32.Parse(Console.ReadLine());
                Console.WriteLine("please enter the barcode");
                string barcode = Console.ReadLine();
                Console.WriteLine("please enter the isRefrence");
                bool isRefrence = bool.Parse(Console.ReadLine());
                Console.WriteLine("please enter the price");
                int price = Int32.Parse(Console.ReadLine());
                Console.WriteLine("please enter the due publicationDate");
                DateTime publicationDate = DateTime.Parse(Console.ReadLine());
                BookStatus status = BookStatus.Available;
                Book book = new Book(id, title, subject, author, publisher, language, numOfPage,
                    count, barcode, isRefrence, price, publicationDate, status);
                library.addBook(book);
            }
            
            if (Action == "remove book")
            {
                Console.WriteLine("please enter the id");
                int id = Int32.Parse(Console.ReadLine());
                library.removeBook(id);
            }

            if (Action == "get all books")
            {
                library.getAllBooks();
            }

            if (Action == "get existing books")
            {
                library.getExistingBook();
            }

            if (Action == "calculate fine")
            {
                Console.WriteLine("please enter the memberId");
                int memberId = Int32.Parse(Console.ReadLine());
                Console.WriteLine("please enter the bookId");
                int bookId = Int32.Parse(Console.ReadLine());
                library.getFine(bookId, memberId);
            }

        }
        
        static void Main(string[] args)
        {
            
            Librarian librarian = new Librarian("user" ,"Female", 22 ,233 ,
                "user@gmail.com" , "99999999999" );

            Book book_1 = new Book(1, "Atomic Habits 1", "Self-help" , "James Clear", 
                "Avery", "ENG", 320, 5, "1hVh5DjiLr", false, 
                14.11, new DateTime(2015, 12, 25), BookStatus.Available);
            
            Book book_2 = new Book(2, "Atomic Habits 2", "Self-help" , "James Clear", 
                "Avery", "ENG", 320, 5, "1hVh5DjiLr", false, 
                14.11, new DateTime(2015, 12, 25), BookStatus.Available);
            
            Book book_3 = new Book(3, "Atomic Habits 3", "Self-help" , "James Clear", 
                "Avery", "ENG", 320, 5, "1hVh5DjiLr", false, 
                14.11, new DateTime(2015, 12, 25), BookStatus.Available);
            
            Book book_4 = new Book(4, "Atomic Habits 4", "Self-help" , "James Clear", 
                "Avery", "ENG", 320, 5, "1hVh5DjiLr", false, 
                14.11, new DateTime(2015, 12, 25), BookStatus.Available);

            Member member_1 = new Member("member1", "female", 22, 1, "family@gmail.com", "0234567899");
            
            Member member_2 = new Member("member2", "male", 22, 2, "family@gmail.com", "0234678999");
            
            Member member_3 = new Member("member3", "female", 22, 3, "family@gmail.com", "02345603452");
            

            List<Book> allBooks = new List<Book>();
            List<Member> allMembers = new List<Member>();
            Library library = new Library(allBooks, allMembers);  
            
            
            allMembers.Add(member_1);
            allMembers.Add(member_2);
            allMembers.Add(member_3);
            
            allBooks.Add(book_1);
            allBooks.Add(book_2);
            allBooks.Add(book_3);
            allBooks.Add(book_4);

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