// See https://aka.ms/new-console-template for more information
int firstNumber = 9;
int secondNumber = 12;
Console.WriteLine( $"первое и второе число изначально {firstNumber}  и  {secondNumber}");
Console.WriteLine("поменяем числа местами");
firstNumber =firstNumber +secondNumber;
secondNumber = firstNumber - secondNumber;
firstNumber =  firstNumber-secondNumber;
Console.Write($"первое и второе число после перестановки {firstNumber}  и  {secondNumber}");
