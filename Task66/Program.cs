/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int GetNumber(string msg)                                                   // Метод проверки ввода пользователем числа
{
    while (true)
    {
        Console.WriteLine(msg);
        string valueFromConsole = Console.ReadLine();

        if (int.TryParse(valueFromConsole, out int number))
        {
            return number;
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Нужно ввести число.");
        }
    }
}

int SumNumbers(int number1, int number2)                                    // Метод подсчета суммы чисел от M до N
{
    if ((number1 > number2) || (number1 < 0) || (number2 < 0))
        return 0;

    else
        if (number1 == number2)
        return number1;

    else
        return number1 + SumNumbers(number1 + 1, number2);
}

int number1 = GetNumber("Введите первое целое натуральное число M");                                 // Код программы
int number2 = GetNumber("Введите второе целое натуральное число N, больше или равное M");
int SumNumFromMToN = SumNumbers(number1, number2);
Console.WriteLine($"Сумма натуральных чисел от M={number1} до N={number2} равна {SumNumFromMToN}");
