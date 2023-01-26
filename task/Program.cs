string[] array1 = {"54555", "Hello", "YeS", "No", "1"};
Console.WriteLine($"[{string.Join(", ", array1)}]");

string[] array2 = new string[array1.Length];


int count = 0;
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length <= 3)
    {
        array2[count] = array1[i];
        count++;
    }  
}

Console.Write($"{string.Join(" ", array2)}");