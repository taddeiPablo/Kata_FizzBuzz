using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Kata_FizzBuzz_Project_Library;
using System.Collections.Generic;

namespace Kata_FizzBuzz_ProjectTest
{
    [TestClass]
    public class FizzBuzzTest
    {
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

    }
}
