using System;

namespace LabBasedAssignment4
{
    internal class Gradation
    {
        static void Main()
        {
            Console.Write("ENTER PERCENTAGE ? ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 100 && n > 70)
                Console.WriteLine("GRADE-A");
            else
            if (n > 60)
                Console.WriteLine("GRADE-B");
            else
            if (n > 50)
                Console.WriteLine("GRADE-C");
            else
            if (n > 40)
                Console.WriteLine("GRADE-D");
            else
                Console.WriteLine("FAIL");
            Console.ReadLine();
        }
    }
}
