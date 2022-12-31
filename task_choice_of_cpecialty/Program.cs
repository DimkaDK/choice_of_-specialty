// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам.
// Первоначальный алгоритм можно ввести с клавиатуры, либо ввести на старте алгоритма. 


Console.Clear();

int EnterNumber(string message)                                                             // Метод получения числа от пользователя из консоли
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

string EnterString(string message)                                                          // Метод получения строки от пользователя из консоли
{
    Console.Write(message);
    string str = Console.ReadLine();
    return str;
}

string[] FillingArrayByConsole(string[] array)                                                // Метод заполнения массива вручную с консоли
{
   
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = EnterString($"Задайте значение {i}-го элемента массива:  ");
    }
    return array;
}

void CreateArrayWithElementsLessThanX(string[] array, int x)                     // Метод формирование массива из элементов размером менее Х символов и вывод результата в консоль
{
    int size = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= x) size++;
    }

    string[] endArray = new string[size];
    int counter = 0;

    if (size != 0)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= x)
            { 
                endArray[counter] = array[i];
                counter++;
            }
           
        } 
    }
    else Console.WriteLine($"В массиве нет элеиентов менее {x} символов");

    Console.WriteLine($"В массиве есть следующие элементы менее {x} символов: [{string.Join("; ", endArray)}]");
}

// Получить от пользователя размер массива

int index = EnterNumber("Задайте размер массива:  ");

// Создать массив и заполнить его

string[] startArray = new string[index];
startArray = FillingArrayByConsole(startArray);

// Формирование массива из элементов размером менее 3 символов и вывод результата в консоль

int size = 3;
CreateArrayWithElementsLessThanX(startArray, size);