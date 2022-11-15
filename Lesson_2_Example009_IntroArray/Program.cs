// Задача поиск max из 9 чисел (массивы)

int Max(int arg1, int arg2, int arg3) // переменная Max (агрументы arg1, arg2, arg3)
{
    int result = arg1; // переменная result
    if(arg2 > result) result = arg2; // условие
    if(arg3 > result) result = arg3;
    return result; // возвращать result
} 
  //            0   1   2   3   4   5   6   7   8  индекс элементов массива
int[] array = {11, 211, 31, 41, 15, 61, 17, 18, 19};
int result = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));
Console.WriteLine(result);

// array[0] = 11; // как обратиться к массиву и записать в него значение
// Console.WriteLine(array[8]); // как обраться к массиву и получить значение [в скобкам ставим  нужный индекс элемента массива]