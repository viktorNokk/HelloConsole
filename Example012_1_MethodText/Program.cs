// ======== Работа с текстом

// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "C" заменить маленькими "c".

string text = " - Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы красноречивы. Вы дадите мне чаю?";

// пояснение
// string s = "qwerty"
//             0123
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty; // инициализируем пустую строку

    int length = text.Length; // определякм длину строк 
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result; 
}

string newText = Replace(text, ' ', '|'); 
Console.WriteLine(newText);

Console.WriteLine();
newText = Replace(text, 'к', 'К'); 
Console.WriteLine(newText);
