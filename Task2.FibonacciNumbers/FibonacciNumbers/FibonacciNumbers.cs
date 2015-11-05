using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    public static class FibonacciNumbers
    {
        public static int SumFibonacciNumbers(int quantityNumbers)
        {
            if (quantityNumbers == 0)
                return 0;

            int sum = 0;
            IEnumerator<int> sequence = SequenceFibonacciNumbers(quantityNumbers);
            bool next = sequence.MoveNext();
            while (next)
            {
                sum += sequence.Current;
                next = sequence.MoveNext();
            }

            return sum;
        }

        private static IEnumerator<int> SequenceFibonacciNumbers(int number)
        {
            int number1 = 0;
            int number2 = 1;
            yield return number1;
            yield return number2;
            for (int i = 2; i < number; i++)
            {
                int temp = number2;
                yield return number2 += number1;
                number1 = temp;
            }
        }
    }
}
