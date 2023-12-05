using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenKata
{
    public class OddEven
    {
        public string GetResult(int number)
        { 
            string result = string.Empty;
            if (number >= 1 && number <= 100) 
            {
                if (number % 2 == 0) 
                {
                    result = result + "Even ";
                }
                else
                {
                    result = result + "Odd ";
                }
                
            } 
            else result = result + string.Empty;

            return result;
        }

        public bool IsPrime(int number)
        {
            
            if (number <= 1) return false;

            if (number == 2) return true;            

            if (number % 2 == 0) return false;
            
            
            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {                
                if (number % i == 0) return false;
            } 
            
            return true;
        }

        public bool IsComposite(int number)
        {
            if (number <= 1) return false;

            return !IsPrime(number);
        }
    }
}
