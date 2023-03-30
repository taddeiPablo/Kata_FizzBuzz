using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_FizzBuzz_Project_Library
{
    public class FizzBuzz
    {
       static List<string> List = new List<string>();

        public static List<String> GetResultList()
        {
            int number = 0;
            for (int index = 0; index < 100; index++)
            {
                number = index + 1;
                if ((number % 3 == 0 && number % 5 == 0))
                {
                    List.Add("FizzBuzz");
                } else if (number % 3 == 0)
                {
                    List.Add("Fizz");
                } else if (number % 5 == 0)
                {
                    List.Add("Buzz");
                } else 
                {
                    List.Add(Convert.ToString(number));
                }
            }
            return List;
        }
    }
}
