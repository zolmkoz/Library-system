using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTutor
{
    internal class LibrarianMenu : iMenu
    {
        public static List<Librarian> lstLibrarian = new List<Librarian>();
        public string GetType()
        {
            return "MainMenu";
        }
        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~Librarian~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("* 1. Add Librarian                                  *");
            Console.WriteLine("* 2. Update Librarian                               *");
            Console.WriteLine("* 3. Search Librarian                               *");
            Console.WriteLine("* 4. Delete Librarian                               *");
            Console.WriteLine("* 5. View Librarian                                 *");
            Console.WriteLine("* 6. Back                                           *");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
        public string SelectMenu()
        {
            Console.Write("Select: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Librarian lbrObj = new Librarian();

            if (num == 1)
            {
                lbrObj.AddLibrarian(lstLibrarian);
                return "AddLibrarian";
            }
            else if (num == 2)
            {
                lbrObj.UpdateLibrarian(lstLibrarian);
                return "UpdateLibrarian";
            }
            else if (num == 3)
            {
                lbrObj.SearchLibrarian(lstLibrarian);
                return "SearchLibrarian";
            }
            else if (num == 4)
            {
                lbrObj.DeleteLibrarian(lstLibrarian);
                return "DeleteLibrarian";
            }
            else if (num == 5)
            {
                lbrObj.ViewLibrarian(lstLibrarian);
                return "ViewLibrarian";
            }
            else
            {
                return "Back";
            }
        }
    }
}
