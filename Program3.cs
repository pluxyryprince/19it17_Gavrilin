using System;

namespace ConsoleApp12
{
    class Program
    {

        static void Main(string[] args)
        {

            {
                Console.WriteLine("Ввведите кол-во элементов в массиве:");
                //задаем массив

                int n = int.Parse(Console.ReadLine());
                int[] a = new int[n];

                //переменная для рандомных чисел 
                var rand = new Random();

                //рандом чисел от 0 до 1000
                for (var i = 0; i < n; i++)
                    a[i] = rand.Next(0, 1000);

                //выводим первоначальный массив
                Console.WriteLine("Превоначальный массив:");
                for (var i = 0; i < a.Length; i++)
                {
                    Console.Write($"[{i}]=");
                    Console.WriteLine(a[i]);
                }
                //делаем сортировку по возрастанию
                Console.WriteLine("Сортировка по возрастанию: ");
                Array.Sort(a);
                for (var i = 0; i < a.Length; i++)
                {
                    Console.Write($"[{i}]=");
                    Console.WriteLine("{0} ", a[i]);
                }

                //сортировка для вывода 1,2,3 места
                int v = a[0];
                int b = a[1];
                int c = a[2];
                for (int i = 3; i < n; i++)
                {
                    if (a[i] >= v || a[i] >= b || a[i] >= c)
                    {
                        if (v <= b && v <= c)
                        {
                            v = a[i];
                        }
                        else
                        {
                            if (b <= c)
                            {
                                b = a[i];
                            }
                            else
                            {
                                c = a[i];
                            }
                        }
                    }
                }
                //выводим в консоли 3 первых места
                Console.Write($"3 первых места: 1-{v} 2-{c} 3-{b} ");
                Console.ReadLine();
            }
        }
    }
}
