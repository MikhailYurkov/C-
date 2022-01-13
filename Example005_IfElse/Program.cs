Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "фруктовая")
{
    Console.WriteLine("Привет Мила!");
}
else
{
    Console.Write("Привет Юзер ");
    Console.WriteLine(username);
}