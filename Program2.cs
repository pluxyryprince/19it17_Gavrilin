using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Swap (ref int e1, ref int e2)
           { 
            var temp = e1;
            e1 = e2;
            e2=temp;
            }
    static int[] BubbleSort(int [] massiv)
        {
            var len = massiv.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - 1; j++)
                {
                    if (massiv[j] > massiv[j + 1])
                    { Swap (ref massiv[j], ref massiv[j + 1]); }
                }
            }
            return massiv;
        }
        static void Main(string[] args)
        {
            //вводим кол-во элементов массива
            Random rnd = new Random();
            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int[] massiv = new int[n];
            //заполняем массив случайными числами от нуля до 4000
            for (int i = 0; i < n; i++)
            {
                massiv[i] = rnd.Next(0, 4000);
                Console.WriteLine(massiv[i]);
            }
            //ищем максимальное значение из массива
            int max = massiv[0];
            Console.WriteLine("Maximum: ");
            for (int i = 0; i < massiv.Length; i++)
            {
                if (massiv[i] > max)
                { max = massiv[i]; }
            }
            Console.WriteLine(max);
            Console.WriteLine();
            //меняем первый элемент массива на максимальный 
            Console.WriteLine("Change max element of array on 1 position: ");
            max = 0;
            int first = massiv[0];
            for (int i = 0; i < n; i++)
            {
                if (max < massiv[i])
                { max = massiv[i]; }
            }
            first = max;
            Console.WriteLine(first);
            Console.WriteLine();

            //расставляем элементы массива по возрастанию 
            var parts = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < parts.Length; i++)
            { massiv[i] = Convert.ToInt32(parts[i]); }
            Console.WriteLine("Отсортированный массив: {0}", string.Join(", ", BubbleSort(massiv)));
            Console.ReadLine();
         }  
    }   
}
