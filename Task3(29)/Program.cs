// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void Root()
{
    Console.Clear();
    System.Console.Write("Программа поместит в массив 8 первых целых чисел найденных в введённой строке .\nВведите строку: ");
    string inputString = Console.ReadLine();
    long[] NumberArray = GetArrayFirst8Number(inputString);
    System.Console.WriteLine(string.Join(", ", NumberArray));

    // System.Console.WriteLine($"Сумма цифр в числе {inputNumber} равна {SummInNumber(inputNumber)}");
}

long[] GetArrayFirst8Number(string stringToArray)
{
    long[] ArrayFirst8Number = new long[8];
    string tempNumberString = "";
    int[] ItIsNumbersIndexArray = null;

    for (int i = 0; i < stringToArray.Length; i++)
    {
        if (Char.IsNumber(stringToArray[i]))
        {
            tempNumberString += stringToArray[i];
        }
        else
        {
            ArrayFirst8Number.Append(Convert.ToInt32(tempNumberString));
            tempNumberString = "";
        }
    }
    return ArrayFirst8Number;
}

Root();