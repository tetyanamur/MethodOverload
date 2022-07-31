using System;

namespace MethodOverload
{
    internal class Program
    { public static int Add(int num1, int num2)

        { return num1 + num2; }

        public static decimal Add(decimal num1, decimal num2)

        { return num1 + num2; }

        public static string Add(int num1, int num2, bool isCorrect)
        { 
            var sum = num1 + num2;

            if (isCorrect == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isCorrect == true && sum == 1)
            {
                return $"{sum} dollars";
            }
            else if (isCorrect == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else 
	        {
            return sum.ToString();
	         }
               }

                static void Main(string[] args)
                {
                var x = 32;
                var y = 75;
         var answer = Add(x, y);
           var c = 5.8m;
            var d = 7.9m;
            var decimalAnswer = Add(c, d);
            var thirdAnswer = Add(0, 0, true);
            Console.WriteLine($"int add: {answer} decimal add: {decimalAnswer}");
            Console.WriteLine(thirdAnswer);
        }
    }
}
