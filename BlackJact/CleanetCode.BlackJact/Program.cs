namespace Cleanetcode.Blackjack
{
    partial class Program
    {
        public static void Main()
        {

            IOperation[] operations = new IOperation[]
            {
                new ShowHand(),
                new OneMore()
            };
            Menu menu = new Menu(operations);
            Application application = new Application(menu);
            application.Run();
        }
    }
}