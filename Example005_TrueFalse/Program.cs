Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "зайка")
{
    Console.WriteLine("Ура, это же ЗАЙКА!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
