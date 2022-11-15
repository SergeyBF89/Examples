// Задача поиск max из 9 чисел

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
int a1 = 151515;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 2311;
int c2 = 33112;
int a3 = 13;
int b3 = 23;
int c3 = 313;

// Вариант решения 1 (с помощью метода)

/*
int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);
*/

// Вариант решения 2 (с помощью метода)

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
Console.WriteLine(max);
