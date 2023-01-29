string[] arr = fillArray(4);
Console.WriteLine(string.Join(", ", arr));

string[] fillArray(int size)
{   
    string[] array = new string[size];

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива");
        array[i] = Console.ReadLine();
    }

    return array;
}
