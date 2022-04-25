using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTutor
{
    class Book : Category
    {
        int bookID;
        string bookName;
        string author;
        Category category = new Category();

        public int BookID { get => bookID; set => bookID = value; }
        public string BookName { get => bookName; set => bookName = value; }
        public string Author { get => author; set => author = value; }

        public void AddBook(List<Book> lstBook)
        {
            Console.WriteLine("Please enter the required book information!!!");
            Console.Write("Book ID:");
            this.BookID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name:");
            this.BookName = Console.ReadLine();
            Console.Write("Author:");
            this.Author = Console.ReadLine();

            lstBook.Add(this);
        }

        public void UpdateBook(List<Book> lstBook)
        {
            Console.WriteLine("Please enter the Book ID to update");           
            Console.Write("Book ID:");
            int id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < lstBook.Count; i++)
            {
                if (lstBook[i].BookID == id)
                {
                    Console.WriteLine("Name:" + lstBook[i].BookName);

                    string name = Console.ReadLine();

                    if (name.Length > 0)
                    {
                        lstBook[i].BookName = name;
                    }

                    Console.WriteLine("Author:" + lstBook[i].Author);
                    string author = Console.ReadLine();
                    if (author.Length > 0)
                    {
                        lstBook[i].Author = author;
                    }
                }
            }
        }

        public void DeleteBook(List<Book> lstBook)
        {
            Console.WriteLine("Please enter the Book ID to detele");
            Console.Write("Book ID:");
            int id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < lstBook.Count; i++)
            {
                if (lstBook[i].BookID == id)
                {
                    lstBook.RemoveAt(i);
                    Console.Write("Delete successfully!!!");
                }
                else
                {
                    Console.Write("Not found!!!");
                }
            }
            
            Console.ReadKey();
        }

        public void SearchBook(List<Book> lstBook)
        {
            Console.WriteLine("Please enter the Book ID to update");
            Console.Write("Book ID:");
            int id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < lstBook.Count; i++)
            {
                if (lstBook[i].BookID == id)
                {
                    Console.WriteLine("Name: " + lstBook[i].BookName);
                    Console.WriteLine("Author: " + lstBook[i].Author);
                }
                else
                {
                    Console.Write("Not found!!!");
                }
            }
            Console.ReadKey();
        }

        public void ViewBook(List<Book> lstBook)
        {
            Console.WriteLine("All books in the list");
            for (int i = 0; i < lstBook.Count; i++)
            {
                Console.WriteLine("Book ID: " + lstBook[i].BookID);
                Console.WriteLine("Name: " + lstBook[i].BookName);
                Console.WriteLine("Author: " + lstBook[i].Author);
            }
            Console.ReadKey();
        }
    }
}
