Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine(); // считывам данные

if (username.ToLower() == "джо") // перевод в нижний регистр
{
    Console.WriteLine("Ура, это же Джо!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}