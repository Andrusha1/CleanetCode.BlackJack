namespace Cleanetcode.Blackjack
{
    internal class CardGeneratorOperation : IOperation //генератор рандомных карт
    {
        public string Name => "Card generator";

        public void Execute()
        {

        }

        public static string GetCard()
        {
            Random random = new Random();
            string[] numBase = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            char[] numMast = { '♥', '♦', '♣', '♠' };
            char CardNum = (char)random.Next(0, 12);
            char CardMast = (char)random.Next(0, 3);
            string card = ($"{numBase[CardNum]}{numMast[CardMast]}");
            return card;
        }
    }
}