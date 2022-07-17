int[] array = { 1, 6, 23, 65, 21, 124, 4, 2345, 2358, 2235 };

int n = array.Length;
int find = 2235;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
    Console.WriteLine(index);
    break;
    }

    //index = index + 1;
    index++;
    
}
