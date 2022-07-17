//void - создание метода, который по умолчанию ничего не возвращает
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 644);
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
    int position = -1;

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

// new int - создай новый массив с десятью элементами
int[] array = new int[548];

FillArray(array);
PrintArray(array);
//делаем пустую строчку, чтобы быть уверенным, что инфа не является дальше частью вывода массива
Console.WriteLine();

int pos = IndexOf(array, 34);
Console.WriteLine(pos);
