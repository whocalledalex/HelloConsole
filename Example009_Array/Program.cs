int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//              0  1  2  3  4  5    6    7   8 
int[] array = { 1, 2, 4, 5, 8, 42, 366, 34, 23};

// int a1 = 5;
// int b1 = 4;
// int c1 = 87;

// int a2 = 66;
// int b2 = 43;
// int c2 = 666;

// int a3 = 9;
// int b3 = 52;
// int c3 = 3;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);

int result = Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8])
);

Console.WriteLine(result);
