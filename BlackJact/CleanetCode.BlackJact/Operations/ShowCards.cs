namespace Cleanetcode.Blackjack
{
    class ShowHand : IOperation
    {
        public string Name => "Show hand";
        
        public void Execute()
        {
            CardsStorage cardst = new CardsStorage();
            Console.WriteLine($"Your hand: ");
            cardst.ShowCards();
        }
    }
}