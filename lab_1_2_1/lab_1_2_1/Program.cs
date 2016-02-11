using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_2_1
{
    public interface ILibraryUser
    {
        void AddBook(string addBookName);
        void RemoveBook(string removeBookName);
        void BookInfo(int addBookName);
        int BookCount();
    }


    public class LibraryUser : ILibraryUser
    {
        private List<string> __booklist = new List<string>();
        private int books_cnt;

        //private fields
        private string __FirstName;
        private string __LastName;
        private int __Id;
        private int __BookLimit;

        // read only properties
        public int BookLimit { get { return __BookLimit; } }
        public string FirstName { get { return __FirstName; } }
        public string LastName { get { return __LastName; } }
        public int Id { get { return __Id; } }
        //get set phone number
        public int Phone { get ;  set ; }

        //default constructor
        public LibraryUser()
        {
            __FirstName = "No Name";
            __LastName = "X";
            __Id = 000000;
            Phone = 00000000;
            __BookLimit = 0;
        }

       // parameter constuctor
        public LibraryUser(string fName_, string lName_, int id_, int phone_, int booklimit_)
        {
            __FirstName = fName_;
            __LastName = lName_;
            __Id = id_;
            Phone = phone_;
            __BookLimit = booklimit_;
        }

        //indexer BookList for array _booklist
        public string this[int BookList]
        {
            get
            {
                string temp;
                if (BookList >= 0 && BookList <= books_cnt - 1)
                { temp = __booklist[BookList]; }
                else 
                { temp = ""; }
                return (temp);
            }
            set
            {
                if (BookList >= 0 && BookList <= BookList - 1)
                {
                    __booklist[BookList] = value;
                }
            }
        }


        public void AddBook(string addBookName)
        {
            __booklist.Add(addBookName);
        }

        public void RemoveBook(string removeBookName)
        {
            for (int i = 0; i < __booklist.Count; i++)
            {
                if(__booklist.Remove(removeBookName))
                    Console.WriteLine("Book removed");
                else
                    Console.WriteLine("Nosuch book here");
            }
        }

        public void BookInfo(int numOfBook)
        {
            if (numOfBook >= 0 && numOfBook <= __booklist.Count)
                Console.WriteLine("The name of book is {0}", __booklist[numOfBook]);
            else
                Console.WriteLine("Out of range bro! Out of range.... :'(");
        }

        public int BookCount()
        {
            return __booklist.Count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //sreating 2 users by deafault and parameter constructors
            LibraryUser user1 = new LibraryUser();
            LibraryUser user2 = new LibraryUser("Sergey", "Galushko", 230, 063123456, 5);

            //show user info
            Console.WriteLine("Name: {0} \nsurname: {1} \nID: {2}", user1.FirstName, user1.LastName, user1.Id);

            //add a couple of books
            user1.AddBook("War and peace");
            user1.AddBook("Nyan cat tales");

            //show how many books user have
            Console.WriteLine("you have {0} books", user1.BookCount());

            //remove book by the name
            user1.RemoveBook("War and peace");

            //show how many books user have after removing
            Console.WriteLine("after removing you have {0} books", user1.BookCount());

            //show books info
            user1.BookInfo(0);
            user1.BookInfo(2); //special error that must tell to user that his input is out of range


            //new user which  created by parameter constructor
            Console.WriteLine("\nuser2");
            Console.WriteLine("Name: {0} \nsurname: {1} \nID: {2}", user2.FirstName, user2.LastName, user2.Id);
            user2.AddBook("Brave new World");
            user2.AddBook("Chronicles Tahalacy");
            user2.AddBook("1984");

            Console.WriteLine("you have {0} books", user2.BookCount());

            user2.RemoveBook("1984");

            Console.WriteLine("after removing you have {0} book", user2.BookCount());

            user2.BookInfo(0);
            user2.BookInfo(1);


            Console.ReadKey();
        }
    }
}


