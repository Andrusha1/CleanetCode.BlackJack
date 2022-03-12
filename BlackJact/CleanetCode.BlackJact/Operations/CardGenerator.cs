namespace Cleanetcode.Blackjack
{
    internal class CardGenerator : IOperation
    {
        public string Name => "Card generator";

        public void Execute()
        {

        }
        public string GetCard()
        {
            Random random = new Random();
            char[] numBase = { '2', '3', '4', '5', '6', '7', '8', '9', '1', 'J', 'Q', 'K', 'A' };
            char[] numMast = { '♥', '♦', '♣', '♠' };
            char CardNum = (char)random.Next();
            char CardMast = (char)random.Next();
            string card = ($"{numBase[CardNum]}{numMast[CardMast]}");
            return card;
        }
    }
}