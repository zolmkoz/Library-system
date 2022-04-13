using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTutor
{
    internal class ReaderMenu : iMenu
    {
        public static List<Reader> lstReader = new List<Reader>();
        public string GetType()
        {
            return "MainMenu";
        }
        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~Reader~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("* 1. Add Reader                                     *");
            Console.WriteLine("* 2. Update Reader                                  *");
            Console.WriteLine("* 3. Search Reader                                  *");
            Console.WriteLine("* 4. Delete Reader                                  *");
            Console.WriteLine("* 5. View Reader                                    *");
            Console.WriteLine("* 6. Back                                           *");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
        public string SelectMenu()
        {
            Console.Write("Select: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Reader rdObj = new Reader();

            if (num == 1)
            {
                rdObj.AddReader(lstReader);
                return "AddReader";
            }
            else if (num == 2)
            {
                rdObj.UpdateReader(lstReader);
                return "UpdateReader";
            }
            else if (num == 3)
            {
                rdObj.SearchReader(lstReader);
                return "SearchReader";
            }
            else if (num == 4)
            {
                rdObj.DeleteReader(lstReader);
                return "DeleteReader";
            }
            else if (num == 5)
            {
                rdObj.ViewReader(lstReader);
                return "ViewReader";
            }
            else
            {
                return "Back";
            }
        }
    }
}
