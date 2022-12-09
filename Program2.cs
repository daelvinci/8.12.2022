using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Verilmiş ayın ədədinə görə hansı fəsil olduğunu tapan proqram

            Console.WriteLine("Eded daxil edin!");
            var nstr = Console.ReadLine();
            var n = Convert.ToInt32(nstr);


            if (n > 0 && n <= 2 || n == 12)
            {
                Console.WriteLine("Qis fesli");
            }
            
            else if(n>=3 && n<=5)
            {
                Console.WriteLine("Yaz fesli");
            }
            else if (n >= 6 && n <= 8)
            {
                Console.WriteLine("Yay fesli");
            }
            else
            { 
                Console.WriteLine("Payiz fesli");
            }
        }
    }
}
