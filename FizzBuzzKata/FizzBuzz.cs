﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        public string GetResult(int number)
        {
            if(number >= 1 && number <= 100)
            {
                if (number % 3 == 0 && number % 5 == 0) return "FizzBuzz";
                            else if (number % 3 == 0) return "Fizz";
                            else if (number % 5 == 0) return "Buzz";
                            else return number.ToString();
            }
            else return string.Empty;
        }
            
    }
}
