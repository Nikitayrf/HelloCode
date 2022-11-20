// Вид 1. Метод ничего не принимает и не возвращает.
void Method1()
{
    Console.WriteLine("Автор ...");
}
// Method1();

// Вид 2. Метод ничего не возвращает, но может приминать аргументы.
void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(msg);
    }

}

// Method21(msg: "текст", count: 4);
// Method21(count: 4, msg: "новый текст");

// Вид 3. Методы которые что-то возвращают, но ничего не принимают.

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
// Console.WriteLine(year);

// Вид 4. Методы которые что-то принимают и что-то возвращают.
// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "z");
// Console.WriteLine(res);

// for (int i = 2; i <= 10; i++) // Метод выводит таблицу умножения
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

// === Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточкаии,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие пруссного короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

//  string s = "qwerty"
//              012
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(newText, 'с', 'С');
// Console.WriteLine(newText);
// Console.WriteLine();

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array) // Метод сортировки массива "заменой" от меньшего к большему
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

void SelectionSortMaxMin(int[] array) // Метод сортировки массива "заменой" от большего к меньшему
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);

SelectionSortMaxMin(arr);
PrintArray(arr);

