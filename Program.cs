using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ededi daxil edin!");
            string numstr = Console.ReadLine();
            int num = Convert.ToInt32(numstr);
            int a;
            int sum = 0;

            for(int i=0; i<numstr.Length; i++)
            {
                if(num>0)
                {
                a = num % 10;
                num = (num - a) / 10;
                sum += a;
                }

               
            }

            Console.WriteLine(sum);

        }
    }
}
