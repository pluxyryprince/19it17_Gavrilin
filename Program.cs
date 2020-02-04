using System;

namespace ConsoleApp10
{
    class Program
    {   //Задание: R максимально, R кратно 14, R произведение 2х различных элементов последовательности. Если такого числа нет вывести -1.

        static void Main(string[] args)
        {
            Random rand = new Random(); //переменная для случайных чисел
            int[] mas = new int[1000]; //массив на 1000 элементов
            for (int i = 0; i < 1000; i++)
            {
                mas[i] = rand.Next(0, 10000);
                Console.WriteLine(mas[i]);
            }
            int R = mas[0];

               Console.WriteLine("Максимальное число: ");

                 for (int i = 0; i < mas.Length; i++)
                        { if (mas[i] > R)
                              { R = mas[i]; }   }
                
          
              Console.WriteLine(R);

                 Console.WriteLine("Вывод чисел после проверки условия: ");

                int a = mas[new Random().Next(0, mas.Length)];
                int b = mas[new Random().Next(0, mas.Length)];

            int c = a * b;
            if ((R % 14 == 0) && (R == c && (a - b <= 8 || b - a <= 8)))

                  { Console.WriteLine(R);  }
         

                    else
                          { Console.WriteLine("-1");  }
                           
        }
    }
}
