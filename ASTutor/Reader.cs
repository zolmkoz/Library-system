using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTutor
{
    class Reader : Person
    {
        int readerID;

        public int ReaderID { get => readerID; set => readerID = value; }

        public void AddReader(List<Reader> lstReader)
        {
            Console.WriteLine("Please enter the required person information!!!");
            Console.Write("Reader ID:");
            this.ReaderID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name:");
            this.NamePerson = Console.ReadLine();
            Console.Write("Phone:");
            this.PhonePerson = Console.ReadLine();
            Console.Write("City:");
            this.CityPerson = Console.ReadLine();
            lstReader.Add(this);
        }

        public void UpdateReader(List<Reader> lstReader)
        {
            Console.WriteLine("Please enter the Reader ID to update");
            Console.Write("Reader ID:");
            int id = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i < lstReader.Count; i++)
            {
                if (lstReader[i].ReaderID == id)
                {
                    Console.WriteLine("Name:"+ lstReader[i].NamePerson);

                    string name = Console.ReadLine();

                    if (name.Length > 0)
                    {
                        lstReader[i].NamePerson = name;
                    }

                    Console.WriteLine("Phone:" + lstReader[i].PhonePerson);
                    string phone = Console.ReadLine();
                    if(phone.Length > 0)
                    {
                        lstReader[i].PhonePerson = phone;
                    }    

                    Console.WriteLine("City:" + lstReader[i].CityPerson);

                    string city = Console.ReadLine();

                    if (city.Length > 0)
                    {
                        lstReader[i].CityPerson = city;
                    }
                }
            }
        }

        public void DeleteReader(List<Reader> lstReader)
        {
            Console.WriteLine("Please enter the Reader ID to delete");
            Console.Write("Reader ID:");
            int id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < lstReader.Count; i++)
            {
                if (lstReader[i].ReaderID == id)
                {
                    lstReader.RemoveAt(i);
                    Console.Write("Delete successfully!!!");
                }
                else
                {
                    Console.Write("Not found!!!");
                }
            }           
            Console.ReadKey();
        }

        public void SearchReader(List<Reader> lstReader)
        {
            Console.WriteLine("Please enter the Reader ID to search");
            Console.Write("Reader ID:");
            int id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < lstReader.Count; i++)
            {
                if (lstReader[i].ReaderID == id)
                {
                    Console.WriteLine("Name: " + lstReader[i].NamePerson);
                    Console.WriteLine("Phone: " + lstReader[i].PhonePerson);
                    Console.WriteLine("City: " + lstReader[i].CityPerson);
                }
                else
                {
                    Console.Write("Not found!!!");
                }
            }
            Console.ReadKey();
        }

        public void ViewReader(List<Reader> lstReader)
        {
            Console.WriteLine("All Readers in the list");
            for (int i = 0; i < lstReader.Count; i++)
            {
                Console.WriteLine("Reader ID: " + lstReader[i].ReaderID);
                Console.WriteLine("Name: " + lstReader[i].NamePerson);
                Console.WriteLine("Phone: " + lstReader[i].PhonePerson);
                Console.WriteLine("City: " + lstReader[i].CityPerson);
            }
            Console.ReadKey();
        }
    }
}
