using System;
using Xunit;
using LibraryManagement;

namespace LibraryManagementTests{
    public class LibraryTest
    {
        [Fact]
        public void Test1(){

            Book book_1 = new Book(1, "Atomic Habits", "Self-help" , "James Clear", "Avery", "ENG", 320, 5, "1hVh5DjiLr", false, 14.11, new DateTime(2015, 12, 25), BookStatus.Available);
            Book book_2 = new Book(2, "Atomic Habits", "Self-help" , "James Clear", "Avery", "ENG", 320, 4, "3hVh5DkdLr", false, 14.11, new DateTime(2015, 12, 25), BookStatus.Available);
            Book book_3 = new Book(3, "Atomic Habits", "Self-help" , "James Clear", "Avery", "ENG", 320, 2, "3hVh5DkdLr", false, 14.11, new DateTime(2015, 12, 25), BookStatus.Available);
            Book book_4 = new Book(4, "Atomic Habits", "Self-help" , "James Clear", "Avery", "PER", 320, 1, "2LVh5DjiLr", false, 14.11, new DateTime(2015, 12, 25), BookStatus.Reserves);
            
            Book book_5 = new Book(5, "Open Mind", "Self-help" , "Dawna Markova", "Conari Press", "ENG", 224, 3, "2LVh28jiLr", false, 49.98, new DateTime(1996, 11, 1), BookStatus.Available);

            List<Book> allBooks = new List<Book>();
            List<Member> members = new List<Member>();

            Library lib = new Library(allBooks, members);
            lib.addBook(book_1);
            lib.addBook(book_2);
            lib.addBook(book_3);
            lib.addBook(book_4);
            lib.addBook(book_5);

            // Test Class: Book
            Assert.Equal(allBooks[0].author,"James Clear");
            Assert.Equal(allBooks[1].title,"Atomic Habits");
            Assert.Equal(allBooks[2].status,BookStatus.Available);

            // Test addBook()
            Assert.Equal(lib.allBooks.Count,5);

            // Test getBooks()
            Assert.Equal(lib.getAllBooks(),5);

            // Test getExistingBook()
            Assert.Equal(lib.getExistingBook(),4);

            // Test removeBook()
            Assert.Equal(lib.removeBook(3),true);
            Assert.Equal(lib.getAllBooks(),4);
            Assert.Equal(lib.getExistingBook(),3);

            // Test searchByTitle
            List<Book> resultSearchTitle = lib.searchByTitle("Atomic Habits");

            List<Book> resultAnswerTitle = new List<Book>();
            resultAnswerTitle.Add(book_1);
            resultAnswerTitle.Add(book_2);
            resultAnswerTitle.Add(book_4);

            Assert.Equal(resultSearchTitle ,resultAnswerTitle);
            Assert.Equal(resultSearchTitle.Count,3);

            // Test searchByAuthor
            List<Book> resultSearchAuthor = lib.searchByAuthor("Dawna Markova");

            List<Book> resultAnswerAuthor = new List<Book>();
            resultAnswerAuthor.Add(book_5);

            Assert.Equal(resultSearchAuthor ,resultAnswerAuthor);
            Assert.Equal(resultSearchAuthor.Count,1);

            // Test searchBySubject
            List<Book> resultSearchSubject = lib.searchBySubject("Self-help");

            Assert.Equal(resultSearchSubject ,lib.allBooks);
            Assert.Equal(resultSearchSubject.Count,4);

            // Test searchByPubDate
            List<Book> resultSearchPubDate = lib.searchByPubDate(new DateTime(2015, 12, 25));

            List<Book> resultAnswerPubDate = new List<Book>();
            resultAnswerPubDate.Add(book_1);
            resultAnswerPubDate.Add(book_2);
            resultAnswerPubDate.Add(book_4);

            Assert.Equal(resultSearchPubDate ,resultAnswerPubDate);
            Assert.Equal(resultSearchPubDate.Count,3);

            Librarian librarian = new Librarian("user" ,"Female", 22 ,2 ,"user@gmail.com" , "99999999999", "123" );
            Member member_1 = new Member("member1", "female", 22, 1, "family@gmail.com", "0234567899" , "123");
            Member member_2 = new Member("member2", "male", 22, 2, "family@gmail.com", "0234678999","232");
            Member member_3 = new Member("member3", "female", 22, 3, "family@gmail.com", "02345603452","435");
        
            lib.registerMember(member_1);
            lib.registerMember(member_2);
            lib.registerMember(member_3);


            //Test class member
            Assert.Equal(members[0].name ,"member1");
            Assert.Equal(members[0].gender ,"female");
            Assert.Equal(members[0].age ,22);
            Assert.Equal(members[1].id ,2);
            Assert.Equal(members[1].emailAddress ,"family@gmail.com");
            Assert.Equal(members[2].number ,"02345603452");
            Assert.Equal(members[2].password ,"435");

            // Test registerMember()
            Assert.Equal(lib.members.Count,3);

            //remove member()
            lib.removeMember(1) ;
            Assert.Equal(lib.members[1].id , 3);
            Assert.Equal(lib.members.Count , 2);
            Assert.Equal(lib.getAllMembers() , lib.members);


            //getAllMembers()
            Assert.Equal(lib.getAllMembers() , lib.members);

            //reserve book()
            DateTime n = DateTime.Now ;
            lib.reserveBook( 1, 1, n , n ) ;
            Assert.Equal(member_1.reserved.Count , 0 ) ;

        }
    }
}
