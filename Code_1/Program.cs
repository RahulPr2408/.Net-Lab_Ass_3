using System;

namespace Code_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerator; 
            int denominator;

            Console.Write("Please enter the numerator : ");
            numerator = int.Parse(Console.ReadLine());

            Console.Write("Please enter the denominato : ");
            denominator = int.Parse(Console.ReadLine());

            int quotient = numerator / denominator;
            int remainder = numerator % denominator;

            Console.WriteLine($"Integer division result = {quotient} with a remainder = {remainder}");

            double fraction_quotient = Math.Round((double)numerator/denominator);

            Console.WriteLine($"Floating point division result : {fraction_quotient}");

            Console.WriteLine($"The result of mixed fraction : {quotient} {remainder}/{denominator}");


        }
    }
}
