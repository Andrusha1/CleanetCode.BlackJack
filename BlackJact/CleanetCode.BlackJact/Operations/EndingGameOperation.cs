namespace Cleanetcode.Blackjack
{
    class EndingGameOperation : IOperation //Операции раздачи первых двух карт
    {
        public string Name => "Count end scores and return results";
        public void Execute()
        {
            if(DealersOperation.DScore > ScoreCountOperation.Score && DealersOperation.DScore <= 21)
            {
                Console.WriteLine("Dealer Wins!");
            }
            else if(DealersOperation.DScore > 21)
            {
                Console.WriteLine("Dealer overdraw. You win!");
            }
            else if(DealersOperation.DScore < ScoreCountOperation.Score && ScoreCountOperation.Score <= 21)
            {
                Console.WriteLine("You win!");
            }
            else if(DealersOperation.DScore == ScoreCountOperation.Score)
            {
                Console.WriteLine("Tie!");
            }
        }
    }
}