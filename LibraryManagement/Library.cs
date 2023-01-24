namespace LibraryManagement
{
    public class Library
    {
        
        public List<Member> members;
        public List<Book> allBooks;
        
        public Library(List<Book> allBooks, List<Member> members)
        {
            this.allBooks = allBooks;
            this.members = members;
        }

        public int getAllBooks() {
            Console.Write("All Books Are:");

            for(int i=0; i<allBooks.Count; i++)
              Console.WriteLine($"{i+1} => {allBooks[i]}");

            return allBooks.Count;
        }

        public int getExistingBook()
        {
            Console.Write("All Available Books Are:");

            List<Book> available_books = new List<Book>();
            for(int i=0; i<allBooks.Count; i++)
                if (allBooks[i].status == BookStatus.Available)
                    available_books.Add(allBooks[i]);

            for (int i=0; i<available_books.Count; i++)
                Console.WriteLine($"{i+1} => {available_books[i]}");

            return available_books.Count;
        }

        public void addBook(Book book){
          allBooks.Add(book);

          Console.Write("successfully");
        }

        public bool removeBook(int bookID){
            for(int i=0; i< allBooks.Count; i++)
                if (allBooks[i].bookID == bookID)
                    allBooks.RemoveAt(i);

            Console.Write("successfully");

            return true;
        }

        public List<Book> searchByTitle(string title)
        {
            List<Book> books = new List<Book>();
            for (int i = 0; i < allBooks.Count; i++)
            {
                if (allBooks[i].title == title)
                {
                    books.Add(allBooks[i]);
                }
            }

            return books;
        }

        public List<Book> searchByAuthor(string author)
        {
            List<Book> books = new List<Book>();
            for (int i = 0; i < allBooks.Count; i++)
            {
                if (allBooks[i].author == author)
                {
                    books.Add(allBooks[i]);
                }
            }

            return books;
        }

        public List<Book> searchBySubject(string subject)
        {
            List<Book> books = new List<Book>();
            for (int i = 0; i < allBooks.Count; i++)
            {
                if (allBooks[i].subject == subject)
                {
                    books.Add(allBooks[i]);
                }
            }

            return books;
        }

        public List<Book> searchByPubDate(DateTime pubDate)
        {
            List<Book> Pcatalogs = new List<Book>();
            for (int i = 0; i < allBooks.Count; i++)
            {
                if (allBooks[i].publicationDate == pubDate)
                {
                    Pcatalogs.Add(allBooks[i]);
                }
            }

            return Pcatalogs;
        }

        public List<Member> searchByBookName(string name)
        {
            List<Member> Bmembers = new List<Member>();
            for (int i = 0; i < members.Count; i++)
            {
                for (int j = 0; j < members[i].getReservedBooks().Count; j++)
                {
                    if (members[i].getReservedBooks()[j].title == name)
                    {
                        Bmembers.Add(members[i]);
                    }
                }
            }

            return Bmembers;
        }
        
        public List<Book> searchByMember(int id)
        {
            for (int i = 0; i < members.Count; i++) 
            {
                if (members[i].id == id)
                {
                    return members[i].getReservedBooks();
                }
            }

            return new List<Book>();
        }

        public bool checkActiveCard(int id)
        {
            bool check = false;
            for (int i = 0; i < members.Count; i++) 
            {
                if (members[i].id == id)
                {
                    check = members[i].card.active;
                }
            }

            return check;
        }
        
        public void registerMember(Member new_member)
        {
            members.Add(new_member);
            Console.WriteLine("successfully");

            SMSNotification sms_not = new SMSNotification("Welcome To Library." , 
                new_member.number);
            sms_not.Notify();

            EmailNotification email_not = new EmailNotification("Welcome To Library." , 
                new_member.emailAddress);
            email_not.Notify();
        }
        
        public void removeMember(int id){

            for (int i = 0; i < members.Count; i++)
            {
                if (members[i].id == id)
                {
                    SMSNotification sms_not = new SMSNotification("Expired Your Membership." , 
                        members[i].number);
                    sms_not.Notify();

                    EmailNotification email_not = new EmailNotification("Expired Your Membership." , 
                        members[i].emailAddress);
                    email_not.Notify();

                    members.Remove(members[i]);
                    Console.WriteLine("successfully");
                }
            }
        }
        
        public List<Member> getAllMembers(){
            return members ;
        }

        public bool reserveBook(int bookID , int id, DateTime startDate, DateTime dueDate)
        {
            Book book = null;
            for (int i = 0; i < allBooks.Count; i++)
            {
                if (allBooks[i].bookID == bookID)
                {
                    if (allBooks[i].status == BookStatus.Reserves)
                    {
                        return false;
                    }
                    allBooks[i].status = BookStatus.Reserves;
                    book = allBooks[i];
                }
            }

            Reservation reserve = new Reservation(startDate, dueDate, book);
            
            for (int i = 0; i < members.Count; i++)
            {
                if (members[i].id == id)
                {
                    members[i].reserved.Add(reserve);

                    string title_book = book.title;
                    
                    SMSNotification sms_not = new SMSNotification($"You reserved {title_book}." ,
                        members[i].number);
                    sms_not.Notify();

                    EmailNotification email_not = new EmailNotification($"You reserved {title_book}." ,
                        members[i].emailAddress);
                    email_not.Notify();                  
                }
            }            
            return true;
        }
        
        public void getFine(int bookID , int id)
        {
            for (int i = 0; i < members.Count; i++)
            {
                if (members[i].id == id)
                {
                    for (int j = 0; j < members[i].reserved.Count; j++)
                    {
                        if (members[i].reserved[j].book.bookID == bookID)
                        {
                            if (DateTime.Compare(DateTime.Now, members[i].reserved[j].dueDate) > 0)
                            {
                                Console.WriteLine("you must pay fine.");
                                SMSNotification sms_not = new SMSNotification($"You must pay {members[i].reserved[j].fine}$." , 
                                    members[i].number);
                                sms_not.Notify();

                                EmailNotification email_not = new EmailNotification($"You must pay {members[i].reserved[j].fine}$." ,
                                    members[i].emailAddress);
                                email_not.Notify(); 
                            }
                            
                        }
                    }
                }
            }
        }
        
    }
}

