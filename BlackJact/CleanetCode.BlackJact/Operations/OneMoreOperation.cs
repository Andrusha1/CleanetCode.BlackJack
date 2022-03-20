namespace Cleanetcode.Blackjack
{
    class OneMoreOperation : IOperation
    {
        public string Name => "One more card";
        public void Execute()
        {
            CardsStorage cardst = new CardsStorage();
            ScoreCountOperation score = new ScoreCountOperation();
            string card;
            card = CardGeneratorOperation.GetCard();
            if (cardst.isContain(card))
            {
                card = CardGeneratorOperation.GetCard();
            }
            else
            {
                score.ScoreUpdate(card);
                cardst.AddCard(card);
                Console.WriteLine(card);
            }
        }
    }
}