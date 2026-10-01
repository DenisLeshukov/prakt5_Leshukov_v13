using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt5_Leshukov
{
    internal class Program
    {
        static void Main (string [ ] args)
        {
           
            Console.WriteLine("Введите число: ");
            if(!int.TryParse(Console.ReadLine(),out int num)){
                Console.WriteLine("Некорректный ввод");
                return;
            }
            bool evenNum = true;
            int sum = 0;
            while (!IsPalindrom(num))
            {
                if (evenNum)
                {
                    sum = SumDigit(num, true);
                    Console.WriteLine($"Сумма четных чисел {sum} от числа {num}");
                }
                else if (!evenNum)
                {
                    sum = SumDigit(num, false);
                    Console.WriteLine($"Сумма нечетных чисел {sum} от числа {num}");
                }
                num += sum;
                evenNum = !evenNum;
                Console.WriteLine($"Получено число {num}" );
                
            }
            Console.ReadKey();
        }

        static int SumDigit (int num, bool evenNumbers)
        {
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                bool isEven = false;
                if (digit % 2 == 0)
                {
                    isEven = true;
                }
                if (evenNumbers && isEven)
                {
                    sum += digit;
                }
                else if (!evenNumbers && !isEven)
                {
                    sum += digit;
                }
                num = num / 10;
            }
            return sum;
        }

        static bool IsPalindrom (int num)
        {
            int revers = 0;
            int orig = num;
            while(num > 0)
            {
                int digit = num % 10;
                revers = revers * 10 + digit;
                num = num / 10;
            }
            if (revers == orig)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        

        
    }
}
