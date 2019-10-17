using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start");
            for (int i = 0; i < 10; i++)
            {
                int randomNum = random.Next(6) + 1;
                
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("end");
            Console.ReadKey();
        }
    }
}


