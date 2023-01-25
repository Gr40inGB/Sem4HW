// Урок 4. Функции
// Задача 25: Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Нельзя использовать библиотеку Math!
// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
Console.Clear();

double AtoPowB(double numA, int numB)
{
    double rezult = 1;
    for (int i = 0; i < numB; i++)
    {
        rezult *= numA;
    }
    return rezult;
}

int IntToAbs(int intNumber)
{
    if (intNumber < 0)
    {
        intNumber = intNumber * (-1);
        System.Console.WriteLine("Число B было приведено к натуральному");
    }
    return intNumber;
}

void Root()
{
    System.Console.Write("Требуется ввести последовательно два числа A и B. Программа возведёт первое число в натуральную степень второго.\nВведите первое число A (целое): ");
    double numberA = Convert.ToSingle(Console.ReadLine());
    System.Console.Write("Введите второе число B (натуральное): ");
    int numberB = Convert.ToInt32(Console.ReadLine());
    numberB = IntToAbs(numberB);

    System.Console.WriteLine($"A({numberA}) в степени B({numberB}) = {AtoPowB(numberA, numberB)}");
}

Root();