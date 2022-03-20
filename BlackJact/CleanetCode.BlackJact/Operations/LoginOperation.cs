namespace Cleanetcode.Blackjack;
class LoginOperation : IOperation //Операция авторизации
{
    public string Name => "Login";

    public void Execute()
    {
        Console.WriteLine("Enter your name: ");
        string Name = Console.ReadLine();
        if (String.IsNullOrWhiteSpace(Name))
        {
            Console.WriteLine("Name incorrect, try again.");
        }
        else
        {
            CurrentUser curUsr = new CurrentUser();
            curUsr.AddUser(Name);
            Console.WriteLine("Login succesful!");
        }

    }
}
