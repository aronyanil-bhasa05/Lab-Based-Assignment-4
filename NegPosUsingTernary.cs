using System;

namespace LabBasedAssignment4
{
    internal class NegPosUsingTernary
    {
        static void Main()
        {
            Console.Write("ENTER NUMBER ? ");
            int n=Convert.ToInt32(Console.ReadLine());
            string result = n > 0 ? "Positive" : "Negative";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
