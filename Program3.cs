using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // -Verilmiş yazıda rəqəm olmamasını yoxlayan proqram, əgər rəqəm varsa yenidən yazının daxil edilməsini istəməlidir ta ki rəqəmsiz daxil edilənədək.

            Console.WriteLine("Yazini daxil edin");
            string yazi = Console.ReadLine();
           
            string nums= "1234567890";

            int j = 0;

            int i = 0;

            bool has = false;

            for (j < yazi.Length; j++;)
            {

                if (yazi[j]==nums[i])
                {
                    has = true;
                }

                else
                {
                    for (i < nums.Length; i++;)
                    {
                        if (yazi[j] == nums[i])
                        {
                            has = true;
                        }

                    }

                }


            }

            if (has==false)
            {
                Console.WriteLine("Duzdur");
            }
            else
            {
                Console.WriteLine("Duz Yazi daxil edin!");
            }



        }
    }
}


