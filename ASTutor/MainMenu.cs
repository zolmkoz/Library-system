using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTutor
{
    internal class MainMenu : iMenu
    {
        public string GetType()
        {
            return "MainMenu";
        }
        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~Menu~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("* 1. Book Menu                                      *");
            Console.WriteLine("* 2. Category Menu                                  *");
            Console.WriteLine("* 3. Librarian Menu                                 *");
            Console.WriteLine("* 4. Reader Menu                                    *");
            Console.WriteLine("* 5. Exit                                           *");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
        public string SelectMenu()
        {
            Console.Write("Select: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
            {
                return "BookMenu";
            } 
            else if (num == 2)
            {
                return "CategoryMenu";
            }
            else if (num == 3)
            {
                return "LibrarianMenu";
            }
            else if (num == 4)
            {
                return "ReaderMenu";
            }
            else
            {
                return "Exit";
            }
        }
    }
}
