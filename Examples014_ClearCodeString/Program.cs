//РЕКУРСИЯ
// 1 Собрать строку с числами от a до b, a<=b

// Стандартный подход 
string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i <=b; i++)
    {
        result += $"{i}";    
    }
    return result;
}

// Рекурсивный подход
string NumbersRec(int a, int b)
{
    if(a<=b) return $"{a}" + NumbersRec(a + 1, b);
    else return string.Empty;
}

Console.WriteLine(NumbersFor(1, 10));
Console.WriteLine(NumbersRec(1, 10));

// 2 Сумма чисел от 1 до n

// Стандартный подход 
int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}

// Рекурсивный подход
int SumRec(int n)
{
    if(n == 0) return 0;
    else return n + SumRec(n - 1);
}

Console.WriteLine(SumFor(10));
Console.WriteLine(SumRec(10));

// 3 Факториал числа
int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}
int FactorialRec(int n)
{
    if (n == 1) return 1;
    else return n * FactorialRec(n-1);
}
Console.WriteLine(FactorialFor(10));
Console.WriteLine(FactorialRec(10));

// 4 Вычислить a в степени n
int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}

int PowerRec(int a, int n)
{
    //return n == 0 ? 1 : PowerRec(a, n - 1) * a;
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}
Console.WriteLine(PowerFor(10,2));
Console.WriteLine(PowerRec(10,2));

// 5 Перебор слов
int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}
FindWords("аисв", new char[5]);


 