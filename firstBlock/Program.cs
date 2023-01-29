const int SIZE = 6;

string[] arr = fillArray();
Console.WriteLine(string.Join(", ", arr));
string[] resultArray = arrayCheck(arr);
Console.WriteLine(string.Join(", ", resultArray));

string[] fillArray()
{   
    string[] array = new string[SIZE];

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива");
        array[i] = Console.ReadLine();
    }

    return array;
}


string[] arrayCheck(string[] array)
{
    int j = 0;
    string[] resultArray = new string[SIZE];
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resultArray[j] = array[i];
            j++;
        }
    }

    Array.Resize(ref resultArray, j);

    return resultArray;
}