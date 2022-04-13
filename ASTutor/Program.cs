using System;
using System.Collections.Generic;

namespace ASTutor
{
    class Program
    {
        static void Main(string[] args)
        {
            iMenu menu = new MainMenu();
            string gettype = "Menu";
            do
            {
                if (gettype == "Menu")
                {
                    menu = new MainMenu();
                }
                if(gettype == "BookMenu")
                {
                    menu = new BookMenu();
                }
                if (gettype == "CategoryMenu")
                {
                    menu = new CategoryMenu();
                }
                if (gettype == "LibrarianMenu")
                {
                    menu = new LibrarianMenu();
                }
                if (gettype == "ReaderMenu")
                {
                    menu = new ReaderMenu();
                }
                if (gettype == "Back")
                {
                    menu = new MainMenu();
                }
                menu.ShowMenu();
                gettype = menu.SelectMenu();

            } while (gettype != "Exit");


            //List<Reader> lstReader = new List<Reader>();

            ////Add * 2
            ////---------------------------
            //Reader rd = new Reader();
            //rd.AddReader(lstReader);

            //Reader rd1 = new Reader();
            //rd1.AddReader(lstReader);

            //foreach (Reader rd3 in lstReader)
            //{
            //    Console.WriteLine("Name: " + rd3.NamePerson);
            //    Console.WriteLine("Phone: " + rd3.PhonePerson);
            //    Console.WriteLine("City: " + rd3.CityPerson);
            //}

            ////Update
            ////---------------------------
            //Reader rd4 = new Reader();

            //rd.UpdateReader(lstReader);

            //foreach (Reader rd5 in lstReader)
            //{
            //    Console.WriteLine("Name: " + rd5.NamePerson);
            //    Console.WriteLine("Phone: " + rd5.PhonePerson);
            //    Console.WriteLine("City: " + rd5.CityPerson);
            //}

            ////Delete
            ////----------------------------
            //Reader rd6 = new Reader();
            //rd6.DeleteReader(lstReader);
            //foreach (Reader rd7 in lstReader)
            //{
            //    Console.WriteLine("Name: " + rd7.NamePerson);
            //    Console.WriteLine("Phone: " + rd7.PhonePerson);
            //    Console.WriteLine("City: " + rd7.CityPerson);
            //}

            ////Search
            ////-----------------------
            //Reader rd8 = new Reader();
            //rd8.SearchReader(lstReader);


            ////View all
            ////-----------------------
            //Reader rd9 = new Reader();
            //foreach (Reader rd10 in lstReader)
            //{
            //    Console.WriteLine("Name: " + rd10.NamePerson);
            //    Console.WriteLine("Phone: " + rd10.PhonePerson);
            //    Console.WriteLine("City: " + rd10.CityPerson);
            //}
        }
    }
}
