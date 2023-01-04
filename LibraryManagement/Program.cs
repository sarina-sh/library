using System;
namespace LibraryManagement
{
    class Program
    {
        static void Main(string[] args)
        { 
            
            DateTime now = DateTime.Now;
            Fine f = new Fine(now) ;
            Librarian librarian = new Librarian("user" ,"Female", 22 ,2  ,
            "123" ,"librarian" , "Active" , "user@gmail.com" , "99999999999" );
            Member member = new Member("Fatima" ,"Female", 23 ,1  ,
            "123" ,"Member" , "Active" , "fatima@gmail.com" , "99999999999" ) ;
            Reservation reservation = new Reservation(now , 5) ;
            BookManager bookManager = new BookManager(); 

            System.Console.WriteLine( member.getReservedBooks() ); 
            System.Console.WriteLine( f.getFine(1,1) );
            System.Console.WriteLine( librarian.registerMember(member) );
            System.Console.WriteLine( librarian.removeMember(1));
            System.Console.WriteLine( librarian.getAllMembers());
            System.Console.WriteLine( reservation.getStatus() );
            System.Console.WriteLine( reservation.getReturnDate() );
            System.Console.WriteLine( reservation.reserveBook(1,1) );
            
            System.Console.WriteLine( librarian.searchByMember(4));
            System.Console.WriteLine( librarian.searchByBookName("book"));
            
       }
    }
}