// See https://aka.ms/new-console-template for more information
Console.WriteLine("первое задание");
int firstNumber = 9;
int secondNumber = 12;
Console.WriteLine( $"первое и второе число изначально {firstNumber}  и  {secondNumber}");
Console.WriteLine("поменяем числа местами");
firstNumber =firstNumber +secondNumber;
secondNumber = firstNumber - secondNumber;
firstNumber =  firstNumber-secondNumber;
Console.WriteLine($"первое и второе число после перестановки {firstNumber}  и  {secondNumber}");
Console.WriteLine("второе задание, сравнение чисел");
for (int i = 0; i < 100; i++)
{
    Console.WriteLine("введите первое число");
    int firstValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите второе число");
    int secondValue = Convert.ToInt32(Console.ReadLine());
    if (firstValue < secondValue)
    {
        Console.WriteLine("первое число меньше второго");
    }
    else if (firstValue > secondValue)
    {
        Console.WriteLine("первое число больше чем второго");

    }
    else
    {
        Console.WriteLine("числа равны");
    }
}