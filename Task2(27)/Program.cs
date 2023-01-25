// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

long IntToAbs(long intNumber)
{
    if (intNumber < 0)
    {
        intNumber = intNumber * (-1);
    }
    return intNumber;
}

long SummInNumber(long numb)
{
    long Summ = 0;
    while (numb > 0)
    {
        Summ = Summ + numb % 10;
        numb = numb / 10;
    }
    return Summ;
}

void Root()
{
    Console.Clear();
    System.Console.Write("Программа вычислит сумму цифр в введенном числе.\nВведите число: ");
    long inputNumber = Convert.ToInt64(Console.ReadLine());
    inputNumber = IntToAbs(inputNumber);

    System.Console.WriteLine($"Сумма цифр в числе {inputNumber} равна {SummInNumber(inputNumber)}");
}

Root();