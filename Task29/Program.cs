
int[] array = new int[8];

void Fullarray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
     while (index < lenght)
     {
        collection[index] = new Random().Next(-10, 10);
        index++;
     }
}

void Printarray(int[] col)
{
    int count = col.Length;
    int pos = 0;
    while (pos < count)
    {
        Console.WriteLine(col[pos]);
        pos++;
    }
}

Fullarray(array);
Printarray(array);

