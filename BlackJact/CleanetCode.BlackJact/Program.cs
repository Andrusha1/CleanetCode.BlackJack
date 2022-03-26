namespace Cleanetcode.Blackjack
{
    partial class Program
    {
        public static void Main()
        {

            IOperation[] operations = new IOperation[]
            {
                new LoginOperation(),
                new OneMoreOperation(),
                new CardsEnoughOperation(),
                new RefreshScreenOperation()
            };
            Menu menu = new Menu(operations);
            Application application = new Application(menu);
            application.Run();
        }
    }
}