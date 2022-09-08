// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(1, 10);
//         index++;
//     }

// }

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
// }

// int[] array = new int[10];

// FillArray(array);
// PrintArray(array);

// _________________________________________________

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }

}

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
// }

int IndexOf(int[] collection, int find)
{


    int count = collection.Length;
    int index = 0;
    int position = -1;
    
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// Вывод массива в консоль списком используя цикл(функция, метод PrintArray)

var str = string.Join(" ", array);
Console.WriteLine(str);
// Вывод массива в консоль в одну строку без цикла (без скобок и запятых).

// Console.WriteLine("[{0}]", string.Join(", ", array));
// Вывод массива в консоль в одну строку без цикла (с квадратными скобками и запятыми).

int pos = IndexOf(array, 4);
Console.WriteLine(pos);