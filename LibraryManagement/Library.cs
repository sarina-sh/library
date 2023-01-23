namespace LibraryManagement
{
    public class Library
    {
        public static Library instance = new Library();

        public List<Member> members;
        public List<Book> allBooks;

        Library getInstance() {
            if (instance == null) { 
                instance = new Library();
            }
            return instance;
        }

        public Library(List<Book> allBooks, List<Member> members)
        {
            this.allBooks = allBooks;
            this.members = members;
        }

        public void getBooks() {
            Console.Write("All Books Are:");

            for(int i=0; i<allBooks.count; i++)
              Console.WriteLine($"{i+1} => {allBooks[i]}");
        }

        public void getExistingBook()
        {
          Console.Write("All Available Books Are:");

          for(int i=0; i<allBooks.count; i++)
            if (allBooks[i].status == BookStatus.Available)
              Console.WriteLine($"{i+1} => {allBooks[i]}");
        }

        public static bool addBook(Book book){
          allBooks.Add(book)

          Console.Write("successfully")
          return true ;
        }

        public static bool removeBook(int bookID){
          for(int i=0; i<allBooks.count; i++)
            if (allBooks[i].bookID == bookID)
              allBooks.RemoveAt(i)

          Console.Write("successfully")
          return true ;
        }

        public List<Catalog> searchByTitle(string title)
        {
            List<Catalog> Tcatalogs = new List<Catalog>();
            for (int i = 0; i < allBooks.Count; i++)
            {
                if (allBooks[i].title == title)
                {
                    Tcatalogs.Add(allBooks[i].catalog);
                }
            }

            return Tcatalogs;
        }

        public List<Catalog> searchByAuthor(string author)
        {
            List<Catalog> Acatalogs = new List<Catalog>();
            for (int i = 0; i < allBooks.Count; i++)
            {
                if (allBooks[i].author == author)
                {
                    Acatalogs.Add(allBooks[i].catalog);
                }
            }

            return Acatalogs;
        }

        public List<Catalog> searchBySubject(string subject)
        {
            List<Catalog> Scatalogs = new List<Catalog>();
            for (int i = 0; i < allBooks.Count; i++)
            {
                if (allBooks[i].subject == subject)
                {
                    Scatalogs.Add(allBooks[i].catalog);
                }
            }

            return Scatalogs;
        }

        public List<Catalog> searchByPubDate(DateTime pubDate)
        {
            List<Catalog> Pcatalogs = new List<Catalog>();
            for (int i = 0; i < allBooks.Count; i++)
            {
                if (allBooks[i].publicationDate == pubDate)
                {
                    Pcatalogs.Add(allBooks[i].catalog);
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

            SMSNotification sms_not = new SMSNotification("Welcome To Library." , new_member.number);
            sms_not.Notify();

            EmailNotification email_not = new EmailNotification("Welcome To Library." , new_member.emailAddress);
            email_not.Notify();
        }
        
        public void removeMember(int id){
            for (int i = 0; i < members.Count; i++)
            {
                if (members[i].id == id)
                {
                    members.Remove(members[i]);
                    member = members[i]
                }
            }

            SMSNotification sms_not = new SMSNotification("Expired Your Membership." , member.number);
            sms_not.Notify();

            EmailNotification email_not = new EmailNotification("Expired Your Membership." , member.emailAddress);
            email_not.Notify();
        }
        
        public  List<Member> getAllMembers(){
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
                    member = members[i]
                }
            }

            title_book = book.title
            SMSNotification sms_not = new SMSNotification($"You reserved {title_book}." , member.number);
            sms_not.Notify();

            EmailNotification email_not = new EmailNotification($"You reserved {title_book}." , member.emailAddress);
            email_not.Notify();

            return true;
        }
        
    }
}

