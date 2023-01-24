using System;
using Xunit;
using LibraryManagement;

namespace LibraryManagementTests{
    public class LibraryTest
    {
        [Fact]
        public void Test1(){
            Book book_1 = new Book(1, "Atomic Habits", "Self-help" , "James Clear", "Avery", "ENG", 320, 5, "1hVh5DjiLr", false, 14.11, new DateTime(2015, 12, 25), BookStatus.Available, new DateTime(2023, 1, 23));
            Book book_2 = new Book(2, "Atomic Habits", "Self-help" , "James Clear", "Avery", "ENG", 320, 4, "3hVh5DkdLr", false, 14.11, new DateTime(2015, 12, 25), BookStatus.Available, new DateTime(2023, 1, 14));
            Book book_3 = new Book(3, "Atomic Habits", "Self-help" , "James Clear", "Avery", "ENG", 320, 2, "3hVh5DkdLr", false, 14.11, new DateTime(2015, 12, 25), BookStatus.Available, new DateTime(2023, 1, 22));
            Book book_4 = new Book(4, "Atomic Habits", "Self-help" , "James Clear", "Avery", "PER", 320, 1, "2LVh5DjiLr", false, 14.11, new DateTime(2015, 12, 25), BookStatus.Reserves, new DateTime(2023, 1, 23));
            
            Book book_5 = new Book(5, "Open Mind", "Self-help" , "Dawna Markova", "Conari Press", "ENG", 224, 3, "2LVh28jiLr", false, 49.98, new DateTime(1996, 11, 1), BookStatus.Available, new DateTime(2023, 1, 24));

            List<Book> allBooks = new List<Book>();
            List<Member> members = new List<Member>();

            Library lib = new Library(allBooks, members);
            lib.addBook(book_1);
            lib.addBook(book_2);
            lib.addBook(book_3);
            lib.addBook(book_4);
            lib.addBook(book_5);

            // // Test Class: Book
            Assert.Equal(allBooks[0].author,"James Clear");
            Assert.Equal(allBooks[1].title,"Atomic Habits");
            Assert.Equal(allBooks[2].status,BookStatus.Available);

            // Test addBook()
            Assert.Equal(lib.allBooks.Count,5);

            // Test getBooks()
            Assert.Equal(lib.getBooks(),5);

            // Test getExistingBook()
            Assert.Equal(lib.getExistingBook(),4);

            // Test removeBook()
            Assert.Equal(lib.removeBook(3),true);
            Assert.Equal(lib.getBooks(),4);
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
        }
    }
}
