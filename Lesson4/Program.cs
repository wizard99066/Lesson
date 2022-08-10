namespace Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("введите количество элементов в массиве");
            int elementsCount=int.Parse(Console.ReadLine());
            int[] mas = new int[elementsCount];
            Console.WriteLine("вывод массива");
            for (int i=0; i < elementsCount; i++)
            {
                mas[i] = new Random().Next(-100,100) ;
                Console.Write(mas[i]+"\t");
            }
            Console.WriteLine();
            
            int sumOfElements = 0;
            for (int i=0; i < mas.Length; i++)
            {
                 sumOfElements += mas[i] ;
            }
            
            var arithmeticMean = sumOfElements * 1.0 / mas.Length;
           Console.WriteLine($"среднее арифметическое всех элементов {arithmeticMean}");
            Console.WriteLine($"общая сумма элементов в массиве {sumOfElements}");
            for (int j = 0; j < mas.Length-1; j++)
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
            Console.WriteLine($"наименьший элемент в массиве {mas[mas.Length-1]}");
            Console.WriteLine("сортировка массива от большего к меньшему значению");
            for(int i = 0;i < mas.Length;i++)
                { Console.Write(mas[i]+"\t");

            }
        }

    }
}