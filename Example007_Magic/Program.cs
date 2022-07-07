Console.Clear(); // программа будет выполняться в чистой консоле 
//Console.SetCursorPosition(10, 4); // аргументы это отступ от левого края и от верхнего края
//Console.WriteLine("+");

// определим вершины треугольника
int xa = 40, ya = 1,
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb; // пусть случайная точка и в нее кладем xa, xb

int count = 0; //счетчик

while(count < 10000)
{
    int what = new Random().Next(0, 3); // определяем случайное число [0,3) 0 1 2
    if(what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if(what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if(what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++; // тоже самое что count = count + 1 или count += 1
}

