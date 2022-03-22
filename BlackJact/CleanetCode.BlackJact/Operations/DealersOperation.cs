namespace Cleanetcode.Blackjack
{
    class DealersOperation : IOperation
    {
        public string Name => "Dealer's operations";
        public static List<string> DealerHand = new List<string>();
        public static int DScore = 0;
        CardsStorage cardst = new CardsStorage();
        public void Execute()
        {

        }
        public void RunDealer()
        {
            {
                while (DScore <= ScoreCountOperation.Score)
                {
                    string card = CardGeneratorOperation.GetCard();
                    if (cardst.isContain(card))
                    {
                        CardGeneratorOperation.GetCard();
                    }
                    else
                    {
                        DScoreUpdate(card);
                        cardst.AddCard(card);
                        DealerHand.Add(card);
                    }
                }
            }
        }
        public void DScoreUpdate(string card)
        {
            string cardNum = card.Substring(0, card.Length - 1);
            if (int.TryParse(cardNum, out int cardNumInt))
            {
                DScore += cardNumInt;
            }
            else if (cardNum == "J")
            {
                DScore += 10;
            }
            else if (cardNum == "Q")
            {
                DScore += 10;
            }
            else if (cardNum == "K")
            {
                DScore += 10;
            }
            else if (cardNum == "A")
            {
                if (DScore >= 11)
                {
                    DScore += 1;
                }
                else
                {
                    DScore += 11;
                }
            }
        }
        public string ShowDScore()
        {
            return DScore.ToString();
        }

        
        public void DropDealerHand()
        {
            DealerHand.Clear();
        }

        public void DResetScore()
        {
            DScore = 0;
        }
    }
}