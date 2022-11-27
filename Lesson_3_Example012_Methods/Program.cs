// ВИДЫ МЕТОДОВ!
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

