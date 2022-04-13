using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTutor
{
    internal class BookMenu : iMenu
    {
        public static List<Book> lstBook = new List<Book>();
        public string GetType()
        {
            return "MainMenu";
        }
        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~Book~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("* 1. Add Book                                       *");
            Console.WriteLine("* 2. Update Book                                    *");
            Console.WriteLine("* 3. Search Book                                    *");
            Console.WriteLine("* 4. Delete Book                                    *");
            Console.WriteLine("* 5. View Book                                      *");
            Console.WriteLine("* 6. Back                                           *");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
        public string SelectMenu()
        {
            Console.Write("Select: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Book bookObj = new Book();

            if (num == 1)
            {
                bookObj.AddBook(lstBook);
                return "AddBook";
            }
            else if (num == 2)
            {
                bookObj.UpdateBook(lstBook);
                return "UpdateBook";
            }
            else if (num == 3)
            {
                bookObj.SearchBook(lstBook);
                return "SearchBook";
            }
            else if (num == 4)
            {
                bookObj.DeleteBook(lstBook);
                return "DeleteBook";
            }
            else if (num == 5)
            {
                bookObj.ViewBook(lstBook);
                return "ViewBook";
            }
            else
            {
                return "Back";
            }
        }
    }
}
