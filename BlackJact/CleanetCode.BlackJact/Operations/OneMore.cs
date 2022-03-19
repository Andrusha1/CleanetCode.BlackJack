namespace Cleanetcode.Blackjack
{
    class OneMore : IOperation
    {
        public string Name => "One more card";
        public void Execute()
        {
            CardsStorage cardst = new CardsStorage();
            string card;
            card = CardGenerator.GetCard();
            if (cardst.isContain(card))
            {
                card = CardGenerator.GetCard();
            }
            else
            {
                cardst.AddCard(card);
                Console.WriteLine(card);
            }
        }
    }
}