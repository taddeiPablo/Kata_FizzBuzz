# Kata-FizzBuzz

## Desafio realizado Equipo 16 (Taddei, Zambrano) 

 ### Instructions
Write a program that displays the numbers from 1 to 100, substituting the multiples of 3 for the word “fizz”, the multiples of 5 for “buzz”, and the multiples of both, that is, the multiples of 3 and 5 ( or 15), for the word “fizzbuzz”.

### Examples
```
FizzBuzz(3) ➞ "Fizz"
FizzBuzz(5) ➞ "Buzz"
FizzBuzz(15) ➞ "FizzBuzz"
FizzBuzz(4) ➞ "4"
```
### Solution Code  
```cs
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
```
### Test
```cs
 /**
   * requerimientos a testear
   * 1 - si un numero N es divisible por 3 mostrara Fizz.
   * 2 - si un numero N es divisible por 5 mostrara Buzz.
   * 3 - si un numero N es divisible por 3 y 5 mostrara FizzBuzz.
   * 4 - si un numero N no es divisible ni por 3 o 5 mostrara el numero.
  */
	[TestMethod]
        public void Valores_no_divisibles_por_3_Test()
        {
            List<String> ResultList = FizzBuzz.GetResultList();
            
            Assert.AreEqual("Fizz", ResultList[2]);
            Assert.AreEqual("Buzz", ResultList[4]);
            Assert.AreEqual("FizzBuzz", ResultList[14]);
        }
```
### App Console
```cs

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

```
