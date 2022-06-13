/* 
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 0, n = 0 -> A(m,n) = 1
m = 0, n = 1 -> A(m,n) = 2
m = 3, n = 5 -> A(m,n) = 253
m = 3, n = 8 -> A(m,n) = 2045
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

int AckermanFunction(int m, int n)                                          // Метод расчета функции Аккермана
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AckermanFunction(m - 1, 1);
    if (m > 0 && n > 0) return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
    return AckermanFunction(m, n);
}

int number1 = GetNumber("Введите первый аргумент функции Аккермана m");                                 // Код программы
int number2 = GetNumber("Введите второй аргумент функции Аккермана n");
int ResultAckermanFunction = AckermanFunction(number1,number2);
Console.WriteLine($"Результат фунции Аккермана A({number1},{number2}) = {ResultAckermanFunction}");