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

            #region PhoneBook
            PhoneBook note = new PhoneBook(10);
            note.AddPerson(0, "Samer", 111);
            note.AddPerson(1, "Samir", 222);
            note.AddPerson(2, "Sameh", 333);

            note.SetNumber("Ahmed", 111);
            Console.WriteLine(note.GetPersonNumber("Ahmed"));

            Console.WriteLine(note.ToString());
            #endregion

            #region Class
            Car C1;
            // Declare for reference of type car
            // this ref can refere an object of type car
            // or another type
            // CLR allocate uninitalized bytes stck
            // CLR allocates 0 bytes in heap

            C1 = new Car(77, "BMW", 180);

            C1 = new Car(3333, "KIA");

            Console.WriteLine(C1);
            #endregion

            #region Inheritence - Parent
            Parent p = new Parent(1, 2);
            p.X = 11;
            p.Y = 22;
            Console.WriteLine(p);
            Console.WriteLine(p.product());
            #endregion

            #region Onheritence - Child
            Child c = new Child(1, 2, 3);
            c.X = 12;
            c.Y = 13;
            c.Z = 14;
            Console.WriteLine(c.ToString());

            #endregion
        }
    }
}
