void FillArray(int[] collection)

{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //если элемента нет, возвращаем -1

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

int[] array = new int[10]; //определили массив из 10 элементов

FillArray(array); //вызвали метод FillArray, который заполнил массив
array[4]=4; //исскуственно заполнили значения.
array[6]=4; //исскуственно заполнили значения.
PrintArray(array); //показываем наш массив (распечатали)
Console.WriteLine();

int pos = IndexOf(array, 444); //было 4, потом попробовали 444 показывает 0.
Console.WriteLine(pos);