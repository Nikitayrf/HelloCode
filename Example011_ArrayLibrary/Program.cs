// Имеется одномерный массив array из n элементов, требуется найти элемент массива, равный find

// 1. Установить счетчик index в позицию 0
// 2. Если array [index] = find, алгоритм завершит работу успешно.
// 3. Увеличить index на 1
// 4. Если index < n, то перейти к шагу 2. В противном случае алгоритм завершит работу безуспешно.

void FillArray(int[] collection) // Метод создания массива из 10-ти случайных чисел
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) // Метод печати массива
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) // Метод (не Void) поиска 1 -го заданного значения индекса в массиве 
{
    int count =collection.Length;
    int index = 0;
    int position = -1; // -1 значит, что такого элемента в массиве нет
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int [] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4); // Создание переменной использующей метод IndexOf поиска в массиве значения 4 - find
Console.WriteLine(pos);