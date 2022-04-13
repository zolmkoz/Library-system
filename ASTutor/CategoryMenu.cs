using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTutor
{
    internal class CategoryMenu : iMenu
    {
        public static List<Category> lstCategory = new List<Category>();
        public string GetType()
        {
            return "MainMenu";
        }
        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~Category~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("* 1. Add Category                                   *");
            Console.WriteLine("* 2. Update Category                                *");
            Console.WriteLine("* 3. Search Category                                *");
            Console.WriteLine("* 4. Delete Category                                *");
            Console.WriteLine("* 5. View Category                                  *");
            Console.WriteLine("* 6. Back                                           *");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
        public string SelectMenu()
        {
            Console.Write("Select: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Category cateObj = new Category();

            if (num == 1)
            {
                cateObj.AddCategory(lstCategory);
                return "AddCategory";
            }
            else if (num == 2)
            {
                cateObj.UpdateCategory(lstCategory);
                return "UpdateCategory";
            }
            else if (num == 3)
            {
                cateObj.SearchCategory(lstCategory);
                return "SearchCategory";
            }
            else if (num == 4)
            {
                cateObj.DeleteCategory(lstCategory);
                return "DeleteCategory";
            }
            else if (num == 5)
            {
                cateObj.ViewCategory(lstCategory);
                return "ViewCategory";
            }
            else
            {
                return "Back";
            }
        }
    }
}
