using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j < 7; j++)
                {
                    int a = i + j;
                    if (a == 6)
                    {
                        Console.WriteLine("첫번째 주사위 : {0}, 두번째 주사위 : {1}", i, j);
                    }

                }

            }
        }
    }
}
