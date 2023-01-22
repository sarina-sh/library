namespace LibraryManagement
{
    public class Library
    {
        private List<Member> members = new List<Member>();
        public List<Book> allBooks;

        public Library(List<Book> allBooks, List<Member> members)
        {
            this.allBooks = allBooks;
            this.members = members;
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
        
        public  void registerMember(Member new_member)
        {
            members.Add(new_member);
        }
        
        public void removeMember(int id){
            for (int i = 0; i < members.Count; i++)
            {
                if (members[i].id == id)
                {
                    members.Remove(members[i]);
                }
            }
        }
        
        public  List<Member> getAllMembers(){
            return members ;
        }
    }
}

