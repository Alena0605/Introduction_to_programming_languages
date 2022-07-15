Console.Write("Введите ваше имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "алена")
{
    Console.WriteLine("Ура, это же АЛЕНА! :)");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
