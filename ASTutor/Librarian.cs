using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTutor
{
    class Librarian : Person
    {
        int employeeID;
        string status;

        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public string Status { get => status; set => status = value; }

        public void AddLibrarian(List<Librarian> lstLibarian)
        {
            Console.WriteLine("Please enter the required person information!!!");
            Console.Write("Employee ID:");
            this.EmployeeID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name:");
            this.NamePerson = Console.ReadLine();
            Console.Write("Phone:");
            this.PhonePerson = Console.ReadLine();
            Console.Write("City:");
            this.CityPerson = Console.ReadLine();
            Console.Write("Status:");
            this.Status = Console.ReadLine();
            lstLibarian.Add(this);
        }

        public void UpdateLibrarian(List<Librarian> lstLibarian)
        {
            Console.WriteLine("Please enter the Employee ID to update");
            Console.Write("Employee ID:");
            int id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < lstLibarian.Count; i++)
            {
                if (lstLibarian[i].EmployeeID == id)
                {
                    Console.WriteLine("Name:" + lstLibarian[i].NamePerson);

                    string name = Console.ReadLine();

                    if (name.Length > 0)
                    {
                        lstLibarian[i].NamePerson = name;
                    }

                    Console.WriteLine("Phone:" + lstLibarian[i].PhonePerson);
                    string phone = Console.ReadLine();

                    if (phone.Length > 0)
                    {
                        lstLibarian[i].PhonePerson = phone;
                    }

                    Console.WriteLine("City:" + lstLibarian[i].CityPerson);
                    string city = Console.ReadLine();

                    if (city.Length > 0)
                    {
                        lstLibarian[i].CityPerson = city;
                    }

                    Console.WriteLine("Status:" + lstLibarian[i].Status);
                    string status = Console.ReadLine();

                    if (status.Length > 0)
                    {
                        lstLibarian[i].Status = status;
                    }
                }
            }
        }

        public void DeleteLibrarian(List<Librarian> lstLibarian)
        {
            Console.WriteLine("Please enter the Employee ID to delete");
            Console.Write("Employee ID:");
            int id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < lstLibarian.Count; i++)
            {
                if (lstLibarian[i].EmployeeID == id)
                {
                    lstLibarian.RemoveAt(i);
                    Console.Write("Delete successfully!!!");
                }
                else
                {
                    Console.Write("Not found!!!");
                }
            }           
            Console.ReadKey();
        }

        public void SearchLibrarian(List<Librarian> lstLibarian)
        {
            Console.WriteLine("Please enter the Employee ID to search");
            Console.Write("Employee ID:");
            int id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < lstLibarian.Count; i++)
            {
                if (lstLibarian[i].EmployeeID == id)
                {
                    Console.WriteLine("Name: " + lstLibarian[i].NamePerson);
                    Console.WriteLine("Phone: " + lstLibarian[i].PhonePerson);
                    Console.WriteLine("City: " + lstLibarian[i].CityPerson);
                    Console.WriteLine("Status:" + lstLibarian[i].Status);
                }
                else
                {
                    Console.Write("Not found!!!");
                }
            }
            Console.ReadKey();
        }

        public void ViewLibrarian(List<Librarian> lstLibarian)
        {
            Console.WriteLine("All Employee in the list");
            for (int i = 0; i < lstLibarian.Count; i++)
            {
                Console.WriteLine("Employee ID: " + lstLibarian[i].EmployeeID);
                Console.WriteLine("Name: " + lstLibarian[i].NamePerson);
                Console.WriteLine("Phone: " + lstLibarian[i].PhonePerson);
                Console.WriteLine("City: " + lstLibarian[i].CityPerson);
                Console.WriteLine("Status: " + lstLibarian[i].Status);
            }
            Console.ReadKey();
        }
    }
}
