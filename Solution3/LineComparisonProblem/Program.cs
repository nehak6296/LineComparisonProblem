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

            double Length1 = Convert.ToDouble((Math.Sqrt(((X2 - X1) * (X2 - X1)) + ((Y2 - Y1) * (Y2 - Y1)))));
                       
            Console.WriteLine("Enter X3 :");
            double X3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter X4 :");
            double X4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Y3 :");
            double Y3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Y4 :");
            double Y4 = Convert.ToDouble(Console.ReadLine());

            double Length2 = Convert.ToDouble((Math.Sqrt(((X4 - X3) * (X4 - X3)) + ((Y4 - Y3) * (Y4 - Y3)))));

            Console.WriteLine("Length of Line1:" + Length2);

            if ((Length1.CompareTo(Length2)).Equals(0))
            {
                Console.WriteLine("Both Lines are equal");
            }
            else
            {
                Console.WriteLine("Lines are not equal");
            }
        }         
    }
}
