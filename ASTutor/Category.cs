using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTutor
{
    class Category
    {

        int categoryID;
        string categoryName;
        List<Book> Books = new List<Book>();

        public int CategoryID { get => categoryID; set => categoryID = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }

        public void AddCategory(List<Category> lstCategory)
        {
            Console.WriteLine("Please enter the required category information!!!");
            Console.Write("Category ID:");
            this.CategoryID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name:");
            this.CategoryName = Console.ReadLine();

            lstCategory.Add(this);
        }

        public void UpdateCategory(List<Category> lstCategory)
        {
            Console.WriteLine("Please enter the Category ID to update");
            Console.Write("Category ID:");
            int id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < lstCategory.Count; i++)
            {
                if (lstCategory[i].CategoryID == id)
                {
                    Console.WriteLine("Name:" + lstCategory[i].CategoryName);

                    string name = Console.ReadLine();

                    if (name.Length > 0)
                    {
                        lstCategory[i].CategoryName = name;
                    }
                }
            }
        }

        public void DeleteCategory(List<Category> lstCategory)
        {
            Console.WriteLine("Please enter the Category ID to delete");
            Console.Write("Category ID:");
            int id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < lstCategory.Count; i++)
            {
                if (lstCategory[i].CategoryID == id)
                {
                    lstCategory.RemoveAt(i);
                    Console.Write("Delete successfully!!!");
                }
                else
                {
                    Console.Write("Not found!!!");
                }
            }            
            Console.ReadKey();
        }

        public void SearchCategory(List<Category> lstCategory)
        {
            Console.WriteLine("Please enter the Category ID to search");
            Console.Write("Category ID:");
            int id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < lstCategory.Count; i++)
            {
                if (lstCategory[i].CategoryID == id)
                {
                    Console.WriteLine("Name: " + lstCategory[i].CategoryName);
                }
                else
                {
                    Console.Write("Not found!!!");
                }
            }
            Console.ReadKey();
        }

        public void ViewCategory(List<Category> lstCategory)
        {
            Console.WriteLine("All categories in the list");
            for (int i = 0; i < lstCategory.Count; i++)
            {
                Console.WriteLine("Category ID: " + lstCategory[i].CategoryID);
                Console.WriteLine("Name: " + lstCategory[i].CategoryName);
            }
            Console.ReadKey();
        }
    }
}
