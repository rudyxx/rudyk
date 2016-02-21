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
        //RV: It is not recommended to use double underscore (__) at the beginning of the identifier. Some reserved keywords has this notation and your identifiers may interfere with them 
        int curBookIt = 0;
        private const int bufferSize = 5;
        private string[] __booklist = new string[bufferSize];
        private int books_cnt = 10;

        //private fields
        private string __FirstName;
        private string __LastName;
        private int __Id;
        private int __BookLimit;

        // read only properties
        //RV: You can use automatic properties with private setters. E.g. public int BookLimit { get; private set;}
        public int BookLimit { get { return __BookLimit; } }
        public string FirstName { get { return __FirstName; } }
        public string LastName { get { return __LastName; } }
        public int Id { get { return __Id; } }
        //get set phone number
        public int Phone { get ;  set ; }

        //default constructor                     
        public LibraryUser()
        {
            //RV: Do we need all these initialization? What are they for? This contructor can be left empty.
            __FirstName = "No Name";
            __LastName = "X";
            __Id = 000000;
            Phone = 00000000;//RV: 00000000 == 0
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
                if (BookList >= 0 && BookList <= books_cnt - 1) //RV:  BookList <= books_cnt - 1 <=> BookList < books_cnt
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
            if (__booklist.Length <= curBookIt)
            {
                //RV: This can be accomplished with less lines of code
                //RV: string[] tempArray = new string[__booklist.Length + bufferSize];
                //RV: for (int i = 0; i < __booklist.Length; i++)
                //RV: {
                //RV:   tempArray[i] = __booklist[i];
                //RV: }
                //RV: __booklist = tempArray;

                //create temp array where we will store our booklist array
                string[]temAr = new string[__booklist.Length];
                //save booklist to temporary aray
                temAr = __booklist;
                //delete booklist info
                __booklist = null; //RV: No need to assign null
                //recreate booklist array with highter capacity
                __booklist = new string[temAr.Length + bufferSize];
                //comeback all books from temp array in extended booklist
                for (int i = 0; i < temAr.Length; i++)
                {
                    __booklist[i] = temAr[i];
                }
                //delete temp array
                temAr = null;
            }
            __booklist[curBookIt++] = addBookName;
            Console.WriteLine("{0} added", addBookName);
        }

        //show all books my own method.
        public void ShowBooks()
        {
            for (int i = 0; i < __booklist.Length; i++)
            {
                if (__booklist[i] != null)  
                    Console.WriteLine(__booklist[i]);
            }
        }

        public void RemoveBook(string removeBookName)
        {
            for (int i = 0; i < __booklist.Length; i++)
            {
                if (__booklist[i] == removeBookName)
                {
                    string tempBookName = __booklist[i];
                    for (int j = i; j < __booklist.Length-1; j++ )
                    {
                        __booklist[j] = __booklist[j + 1];

                    }
                    Console.WriteLine("{0} removed", tempBookName);
                    curBookIt--;
                        break;
                }
                else if (i >= __booklist.Length-1)
                    Console.WriteLine("Nosuch book here");
            }
        }

        public void BookInfo(int numOfBook)
        {
            if (numOfBook >= 0 && numOfBook <= __booklist.Length)
                Console.WriteLine("The name of book is {0}", __booklist[numOfBook]);
            else
                Console.WriteLine("Out of range bro! Out of range.... :'(");
        }

        public int BookCount()
        {
            //RV: You store the book quantity in curBookIt variable, right? Why don't you just return its value?
            int result = 0;
            while (__booklist[result] != null)
            { result++; }
            return result;
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
            user1.AddBook("THE GRAPES OF WRATH");
            user1.AddBook("BATTLEFIELD EARTH");
            user1.AddBook("THE LORD OF THE RINGS");
            user1.AddBook("War and peace");
            user1.AddBook("Nyan cat tales");
            user1.AddBook("UNDER THE VOLCANO");
            user1.AddBook("ATLAS SHRUGGED");
            user1.AddBook("THE FOUNTAINHEAD");
            user1.AddBook("ULYSSES");
            user1.AddBook("THE GREAT GATSBY");
            user1.AddBook("A PORTRAIT OF THE ARTIST AS A YOUNG MAN");
            user1.AddBook("LOLITA");
            user1.AddBook("BRAVE NEW WORLD");
            user1.AddBook("THE SOUND AND THE FURY");

            //user1.ShowBooks();
            //show how many books user have
            Console.WriteLine("you have {0} books", user1.BookCount());

            //remove book by the name
            user1.RemoveBook("War and peace");
            user1.RemoveBook("THE SOUND AND THE FURY");
            user1.RemoveBook("CATCH-22");
            user1.RemoveBook("DARKNESS AT NOON");
            user1.RemoveBook("SONS AND LOVERSe");
            user1.RemoveBook("THE GRAPES OF WRATH");
            user1.RemoveBook("UNDER THE VOLCANO");
            user1.RemoveBook("ATLAS SHRUGGED");
            user1.RemoveBook("THE FOUNTAINHEAD");
            user1.RemoveBook("BATTLEFIELD EARTH");
            user1.RemoveBook("THE LORD OF THE RINGS");
            user1.RemoveBook("TO KILL A MOCKINGBIRD");

            //add a couple of books again
            user1.AddBook("CATCH-22");
            user1.AddBook("DARKNESS AT NOON");
            user1.AddBook("SONS AND LOVERSe");
            user1.AddBook("TO KILL A MOCKINGBIRD");



            //user1.ShowBooks();
            //show how many books user have after removing
            Console.WriteLine("after removing you have {0} books", user1.BookCount());

            //show books info
            user1.BookInfo(0);
            user1.BookInfo(2000); //special "out of range" error 


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


