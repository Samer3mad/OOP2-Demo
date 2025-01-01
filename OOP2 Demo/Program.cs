using OOP2_Demo.Encapsulation;
using System.Net.NetworkInformation;

namespace OOP2_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Struct
            Point P1;
            //Decleration


            P1 = new Point(1, 2);
            P1.y = 2;
            Console.WriteLine(P1.x);
            Console.WriteLine(P1.y);

            Console.WriteLine(P1.ToString()); // Namespace.datatype name 
            #endregion

            #region Encapsulation
            Employee employee = new Employee(7, "Samer Emad", 7000);
            employee.SetId(1); //Set ID
            employee.Name = "Samer Zaki";
            Console.WriteLine(employee.Name);
            Console.WriteLine(employee.GetId()); // get Id

            Console.WriteLine(employee);
            #endregion

            PhoneBook note = new PhoneBook(10);
            note.AddPerson(0, "Samer", 111);
            note.AddPerson(1, "Samir", 222);
            note.AddPerson(2, "Sameh", 333);

            note.SetNumber("Ahmed", 111);
            Console.WriteLine(note.GetPersonNumber("Ahmed"));

            Console.WriteLine(note.ToString());
        }
    }
}
