int[] array = new int[10]; // определил массив из 10 элементов
// заполнение массива
void FillArray(int[] collection) // метод void который указыает, что фактически ничего не возвращает, он просто производит некоторые действия.
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++; // index = index + 1
    }
}
// печать массива
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++; // position = position + 1
    }
}
int IndexOf(int[] collection, int find) // решение предыдущей задачи с Example010
{
    int count = collection.Length;
    int index = 0;
    int position = 0; // int position = -1; (когда ищем элемент которго нет)
    while(index < count)
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
FillArray(array); // заполнил массив
array[4] = 4; // добавил принудительно значений в массив [4] позиция элемента, 4 значение
array[6] = 4;
PrintArray(array); // распечатал массив
Console.WriteLine();
int pos = IndexOf(array, 4); // например ищем 444 (элемент которого нет)
Console.WriteLine(pos);