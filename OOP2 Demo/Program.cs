using System.Net.NetworkInformation;

namespace OOP2_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point P1;
            //Decleration


            P1 = new Point(1, 2);
            P1.y = 2;
            Console.WriteLine(P1.x);
            Console.WriteLine(P1.y);

            Console.WriteLine(P1.ToString()); // Namespace.datatype name
        }
    }
}
