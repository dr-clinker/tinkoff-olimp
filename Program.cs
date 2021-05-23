using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for(int i=1; i<1000001; i++)
            {
                for(int j=1; j<i; j++)
                {
                    if(Math.Pow(j, 2) % (i - j) == 0)
                    {
                       if(Math.Pow(j,2)/(i-j) ==i || Math.Pow(j, 2) / (i - j) == j)
                        {
                            Console.WriteLine(i + " - " + j);
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine("all");
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
