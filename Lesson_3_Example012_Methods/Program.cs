//========================================== ВИДЫ МЕТОДОВ! =================================================
// ВИД 1. ( методы ничего не возвращают и ничего не принимают)
/*
void Method1() // void метод, Method1 индефикатор
{
    Console.WriteLine("Выводим что укажем");
}
Method1(); // вызываем метод
*/

//ВИД 2. (методы ничего не возвращают, но могут принимать какие нибудь аргументы)
// вариант 1
/*
void Method2(string msg) // void метод, Method2 индефикатор, string msg аргументы
{
    Console.WriteLine(msg); // выводим агрументы (msg)
}
Method2(msg:"Текст сообщения"); // выводим метод и текст агрументы (msg) можно вызывать без msg в скобках
*/
// вариант 2
/*
void Method21(string msg, int count) // пример с двумя агрументами, второй агрумент (int count)
{
    int i = 0;
    while (i < count)
    {
       Console.WriteLine(msg);
       i++; // увелечение счетчика на 1, называют (инкремент), а уменьшение на 1 называют (тэкриментом)
    }
}
//Method21("Текст", 4); // вызываю мотод и хочу, к примеру видеть текст 4 раза 
//Method21(msg:"Новый текст", count: 4); // вызываю метод обращаясь к каждому аргументу 
Method21(count: 4, msg:"Новый текст"); // можно поменчть местами агрументы при вызове метода
*/

// ВИД 3. (методы возвращают что то, но ничего не принимают)
/*
int Method3()
{
    return DateTime.Now.Year; // возвращаем нынешний год
}
int year = Method3(); // вызываем метод
Console.WriteLine(year);
*/

// ВИД 4. (методы которые возвращают и принимают)
// вариант 1 (цикл while)
/*
string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty; // изначально result выходит пустой строкой
    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "Текст "); // создали новыю переменную res для вывода в консоль метода
Console.WriteLine(res);
*/
// вариант 2 (цикл for)
/*
string Method4(int count, string text)
{
    string result = string.Empty; // изначально result выходит пустой строкой
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "Текст "); // создали новыю переменную res для вывода в консоль метода
Console.WriteLine(res);
*/

//======= Задача 1. Вывести таблицу умножения на экран. 
/*
for(int i = 2; i <= 10; i++) // первый цикл с переменной i
{
    for(int j = 2; j <= 10; j++) // второй цикл с переменной j
    {
        Console.WriteLine($"{i} * {j} = {i * j}"); // вывод таблицы на экран 
    }
    Console.WriteLine(); // добавиливывод (искуственно) для разделения строк в таблице
}
*/

//========Задача 2. Дан текст. В тексте нужно  все пробелы заменить черточками, маленькие буквы "к" заменить большими "К", а большие буквы "В" заменить маленькими "в"
/*
string text = "- Я думаю, - сказал князь, улыбнись, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s =  "qwerty" (условная строка со вспомогательным функционалом)
//              012345 (индексы элемента)
// допустим s[3] то под 3 будет r

string Replace(string text, char oldValue, char newValue) // метод назвали Replace, char oldValue (конкретный символ), char newValue (новый конкретный символ)
{
    string result = string.Empty; // изначально result выходит пустой строкой
    int length = text.Length; // что бы узнать длину строки, обращаемся к кол-во символов в тексте
    for(int i =0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}"; // если текст совпал с текущим символом, то в result добовляем новый символ
        else result = result + $"{text[i]}"; // иначе добовляем в result текущий символ, который и был
    }
    return result;
}
string newText = Replace(text, ' ', '|'); // переменная string newText присваиваем Replace(text, указываем что на что меняем ( в данном случае пробелы на черточки))
Console.WriteLine(newText);
Console.WriteLine(); // искувственный пробел
newText = Replace(newText, 'к', 'К' ); // заменяем меленькие буквы к на большие буквы К
Console.WriteLine(newText);
Console.WriteLine(); // искувственный пробел
newText = Replace(newText, 'В', 'в' ); // заменяем большие буквы В на маленькие буквы в
Console.WriteLine(newText);
*/

//============= Задача 3. Упорядочить массив от самого минимального элемента до самого максимального. (метод сортировки минимального и максимального)
// Вариант 1 (выводим от минимального к максимальному элементу)
/*
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PrintArray(int[] array) // вывести данный массив на экран 
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
} 
void SelectionSort(int[] array) // метод который упорядочивает наш массив
{
    for(int i = 0; i < array.Length - 1; i++) // - 1 что бы в нижнем цикле i + 1 стало нужное кол-во элементов
    {
        int minPosition = i; // элемент на который "смотрим" 
        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary =  array[i]; // temporary временный элемент(который нашли)
        array[i] = array[minPosition]; // поменять minPosition с той которую мы нашли
        array[minPosition] = temporary;  // кладем временный элемент
    }
}       
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
*/
// Вариант 2 (выводим от максимального к минимальному элементу)
/*
int[] arr = {1, 5, 4, 2, 3, 7, 6, 1, 1};
void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i ++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
*/