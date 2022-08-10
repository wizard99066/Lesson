namespace Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("введите количество элементов в массиве");
            int elementsCount = int.Parse(Console.ReadLine());
            int[] mas = new int[elementsCount];
            Console.WriteLine("вывод массива");
            for (int i = 0; i < elementsCount; i++)
            {
                mas[i] = new Random().Next(-100, 100);
                Console.Write(mas[i] + "\t");
            }
            Console.WriteLine();

            int sumOfElements = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                sumOfElements += mas[i];
            }

            var arithmeticMean = sumOfElements * 1.0 / mas.Length;
            Console.WriteLine($"среднее арифметическое всех элементов {arithmeticMean}");
            Console.WriteLine($"общая сумма элементов в массиве {sumOfElements}");
            for (int j = 0; j < mas.Length - 1; j++)
            {
                for (int i = 0; i < mas.Length - 1; i++)
                {
                    if (mas[i] < mas[i + 1])
                    {
                        int smallerElement = mas[i];
                        mas[i] = mas[i + 1];
                        mas[i + 1] = smallerElement;
                    }
                }
            }
            Console.WriteLine($"наибольшее значение в массиве {mas[0]}");
            Console.WriteLine($"наименьший элемент в массиве {mas[^1]}");
            Console.WriteLine("сортировка массива от большего к меньшему значению");
            for (int i = 0; i < mas.Length; i++)
            { Console.Write(mas[i] + "\t");

            }
            Console.WriteLine();
            Console.WriteLine("задание 2, сортировка матрицы");
            Console.WriteLine("введите кол-во строк");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("введите кол-во столбцов");
            int second = int.Parse(Console.ReadLine());
            int[,] array = new int[first, second];
            Console.WriteLine("вывод двумерного массива");
            for (int i = 0; i < first; i++)
            {
                for (int k = 0; k < second; k++)
                {
                    array[i, k] = new Random().Next(0, 9);
                    Console.Write(array[i, k] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("cортировка элементов матрицы по убыванию");
            for (int i = 0; i < first; i++)
            {
                for (int k = 0; k < second - 1; k++)
                {
                    for (int j = 0; j < second - 1; j++)
                    {
                        if (array[i, j] < array[i, j + 1])
                        {
                            int smallerElement2 = array[i, j];
                            array[i, j] = array[i, j + 1];
                            array[i, j + 1] = smallerElement2;
                        }
                    }
                }
            }
            for (int i = 0; i < first; i++)
            {
                for (int j = 0; j < second; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < first; i++)
            {

                Console.WriteLine($"наибольший элемент строки  номер {i} значение  {array[i, 0]}");

            }

            Console.WriteLine();
            for (int i = 0; i < first; i++)
            {
                Console.WriteLine($"наименьший элемент строки номер {i} значение {array[i,second-1]} ");
            }
















        } 

    }
}