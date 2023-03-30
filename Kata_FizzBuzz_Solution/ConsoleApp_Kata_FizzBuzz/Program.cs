using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kata_FizzBuzz_Project_Library;

namespace ConsoleApp_Kata_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista tipo FizzBuzz");
            List<string> resultList = FizzBuzz.GetResultList();
            Console.WriteLine("valores : ");
            foreach (string number in resultList)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
