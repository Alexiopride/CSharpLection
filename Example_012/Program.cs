// Виды методов
// ______________________________________________
// Вид1. (ничего не принимает и не возвращает)
// void Method1()
// {
//     Console.WriteLine("Автор ...");
// }
// Method1();
// ________________________________________________
// Вид 2.
// void Method2(string msg)
// {
//     Console.WriteLine("msg");

// }
// Method2("Текст сообщения");

// ---------------
// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine("msg");
//         i++;
//     }
// }
// Method21(msg: "Текст сообщения", count: 4);
// ____________________________________________________
// Вид 3 (Если метод что то возвращает то мы должны указать
//  тип данных которые мы ожидаем, аргументы он не принимает).

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);
// _______________________________________________________

// // Вид 4.(Методы которые что то принимают и что то возвращают).
// string Method4(int count, string c)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result +c;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "asdfgh");
// Console.WriteLine(res);

// _____________________________________________________

// string Method4(int count, string c)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + c;
//     }
//     return result;
// }

// string res = Method4(10, "asdfgh");
// Console.WriteLine(res);
// 

// ___________________________________________________________

// Цикл в цикле на примере таблицы умножения
// for (int i = 2; i < 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i * j}");
//     }
//     Console.WriteLine();
// }


// _________________________________________________________________

// string text = "Я думаю, сказал князь, улыбаясь, что, ежели бы вас "
//                 + "послали вместо нашего милого Винценгероде.";

// // string s = "qwerty"
//          //    012345
// //    s[3] 

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);

// _______________________________________________________________________

// string text = "Я думаю, сказал князь, улыбаясь, что, ежели бы вас "
//                 + "послали вместо нашего милого Винценгероде.";

// // string s = "qwerty"
//          //    012345
// //    s[3] 

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }
// string newText = Replace(text, ' ', '|');

// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);

// _________________________________________________________________

// Сортировка массива.

int[] arr = {1, 5, 4, 3, 2, 6, 7};

void PrintArray(int[] array)
{
    int count = array.Length;
    
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}


void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++ )
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);