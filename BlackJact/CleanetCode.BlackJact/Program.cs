namespace Cleanetcode.Blackjack
{
    class Program
    {
        public static void Main()
        {

            IOperation[] operations = new IOperation[]
            {
                new CardGenerator(),
                new CardDraw()
            };

        }
    }
}