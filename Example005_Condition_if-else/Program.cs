Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "еркуат")
{
    Console.WriteLine("Ура, это Еркуат");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}