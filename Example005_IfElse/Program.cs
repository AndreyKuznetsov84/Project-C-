Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "валя")
{
    Console.WriteLine("Ура, это же Валя");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}