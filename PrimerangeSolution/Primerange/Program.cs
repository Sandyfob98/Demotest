using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primerange
{
    class Program
    {
        int num1, num2,flag;

        Program()
        {
            Console.WriteLine("Enter the range");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            for (int i = num1; i < num2; i++)
            {
                if (i == 0 || i == 1)
                    continue;

                flag = 1;

                for (int j = 2; j <= i/2; j++)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }

                }

                if(flag==1)
                    Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            new Program();
            Console.ReadKey();
        }
    }
}
