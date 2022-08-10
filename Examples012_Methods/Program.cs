// Вид 1 - ничего не принимает ничего не возвращает

void Method1()
{
    Console.WriteLine("Автор.....");
}
//Вызов метода 1
//Method1();

//Вид 2 - что-то принимает ничего не возвращает 

void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Some text");
//или так:
//Method2(msg: "Some text");

void Method21(string msg, int count) // чтобы показывать на экране определенное кол-во сообщений msg
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++; 
    }
}
//Method21("Text", 4);
//именованные аргументы запись
//Method21(msg: "Text", count: 4);

//Вид 3 - ничего не принимает что-то возвращает

int Method3()
{
    return DateTime.Now.Year; 
}
int year = Method3(); //переменная в которую кладем выполнения метода
//Console.WriteLine(year);


//Вид 4 - что-то принимает что-то возвращает (пример с циклом while)

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty; // изначально пустая строка

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "qwerty");
// Console.WriteLine(res);

//Вид 4 - что-то принимает что-то возвращает (пример с циклом for)

string Method4(int count, string text)
{
    string result = String.Empty; // изначально пустая строка
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "qwerty");
//Console.WriteLine(res);

// пример вывода таблици умножения на экран (цикл в цикле)

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine(); // искуственный разрыв для наглядности 
// }

