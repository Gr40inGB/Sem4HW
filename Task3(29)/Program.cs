// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//using System.Globalization;



void Root()
{
    Console.Clear();
    System.Console.Write("Программа поместит в массив 8 первых целых чисел найденных в введённой строке .\nВведите строку: ");
    string inputString = Console.ReadLine();
    string[] StringNumberArray = GetArrayFirst8Number(inputString);
    PrintArray(StringNumberArray);

}

void PrintArray(string[] ArrayToPrint)
{
    System.Console.Write("[");
    for (int i = 0; i < ArrayToPrint.Length; i++)
    {
        if (ArrayToPrint[i] == null)
        {
            System.Console.Write("0");
        }
        else
        {
            System.Console.Write(ArrayToPrint[i]);
        }
        if (i < ArrayToPrint.Length - 1)
        {
            System.Console.Write(", ");
        }
    }
    System.Console.Write("]");

}


void ErrorText(int countFind)
{
    System.Console.WriteLine($"Количество найденных чисел {countFind + 1}, остальное будет заполнено нулями");
}

string[] GetArrayFirst8Number(string stringToArray)
{
    string[] ArrayFirst8Number = new string[8];
    int countArray = 0;
    string tempNumberString = null;     // для конкатенации найденного числа

    for (int i = 0; i < stringToArray.Length; i++)
    {
        if (countArray < ArrayFirst8Number.Length)
        {
            if (Char.IsNumber(stringToArray[i]))
            {
                tempNumberString += stringToArray[i];
                if (i == stringToArray.Length - 1)   // если мы достигли конца текста и больше не встретим других знаков -
                {                                    // то нужно записать в наш массив текущее число в tempNumberString  - иначе потеряется
                    ArrayFirst8Number[countArray] = tempNumberString;
                }
            }
            else
            {
                if (tempNumberString == null)  // почему-то не работает   if (!(tempNumberString == null))   - поэтому обрабюатываю в else
                {
                }
                else
                {
                    ArrayFirst8Number[countArray] = tempNumberString;
                    tempNumberString = null;
                    countArray++;

                    if (countArray == 8)           // если мы уже нашли достаточно чисел - выходим 
                    {
                        return ArrayFirst8Number;
                    }
                }
            }
        }

        if (i == stringToArray.Length - 1 && countArray < 7)
        {
            ErrorText(countArray);   /// если чисел недостаочно 
        }
    }

    return ArrayFirst8Number;
}

Root();