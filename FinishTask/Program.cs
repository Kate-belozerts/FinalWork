// string[] secondVersion = new string[] { "one", "two", "three", "12" }; //Если хотите взять готовый

Console.Clear();

string[] CreateArray()
{
    Console.WriteLine($"Хотите указать размер массива? (Y - Да / Другая клавиша - Нет)");
    string answer = Console.ReadLine()!.ToLower();

    int size = default;

    if (answer == "y")
    {
        Console.WriteLine($"Введите количество элементов: ");
        size = Convert.ToInt32(Console.ReadLine());
    }
    else
    {
        size = 5;
    }

    string[] arr = new string[size];

    Console.WriteLine($"Введите элемент: ");

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Console.ReadLine()!;
    }
    return arr;
}

void PrintArray(string[] arr)
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i],5}     ");
    }
    Console.ResetColor();
    Console.WriteLine();
    Console.WriteLine();
}

string[] CorrectArray(string[] arr)
{
    string[] newArr = new string[arr.Length];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArr[j] = arr[i];
            j++;
        }
    }
    return newArr;
}


string[] array = CreateArray();
PrintArray(array);
string[] result = CorrectArray(array);
PrintArray(result);

