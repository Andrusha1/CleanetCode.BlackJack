namespace Cleanetcode.Blackjack
{
    partial class Program
    {
        public static void Main()
        {

            IOperation[] operations = new IOperation[]
            {
                new LoginOperation(),
                new ShowHandOperation(),
                new OneMoreOperation(),
                new CardsEnoughOperation()
            };
            Menu menu = new Menu(operations);
            Application application = new Application(menu);
            application.Run();
        }
    }
}