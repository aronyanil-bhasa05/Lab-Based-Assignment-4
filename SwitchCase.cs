using System;

namespace LabBasedAssignment4
{
    internal class SwitchCase
    {
        static void Main()
        {
            Console.Write("Enter Day Number ? ");
            int ch=Convert.ToInt32(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    Console.WriteLine("MONDAY");
                    break;
                case 2:
                    Console.WriteLine("TUESDAY");
                    break;
                case 3:
                    Console.WriteLine("WEDNESDAY");
                    break;
                case 4:
                    Console.WriteLine("THURSDAY");
                    break;
                case 5:
                    Console.WriteLine("FRIDAY");
                    break;
                case 6:
                    Console.WriteLine("SATURDAY");
                    break;
                case 7:
                    Console.WriteLine("SUNDAY");
                    break;               
                default: 
                    Console.WriteLine("ERROR");
                    break;
            }
            Console.ReadLine();
        }
    }
}
