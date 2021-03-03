using System;

namespace LineComparisonProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter X1 :");
            double X1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter X2 :");
            double X2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Y1 :");
            double Y1 = Convert.ToDouble(Console.ReadLine());
                       
            Console.WriteLine("Enter Y2 :");
            double Y2 = Convert.ToDouble(Console.ReadLine());

            double Length = Convert.ToDouble((Math.Sqrt(((X2 - X1) * (X2 - X1)) + ((Y2 - Y1) * (Y2 - Y1)))));
             
            Console.WriteLine("Length of Line:" + Length);
        }                       
    }
}
