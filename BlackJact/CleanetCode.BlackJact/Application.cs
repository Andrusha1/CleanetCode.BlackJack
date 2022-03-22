namespace Cleanetcode.Blackjack
{
    class Application
    {
        private readonly Menu _menu;
        public Application(Menu menu)
        {
            _menu = menu;
        }

        public void Run()
        {
            bool isQuit = false;
            while (!isQuit)
            {
                List<string> operationNames = new List<string>();
                ScoreCountOperation score = new ScoreCountOperation();
                CardsStorage cardst = new CardsStorage();
                DealersOperation dealer = new DealersOperation();
                CardsEnoughOperation cardsEnough = new CardsEnoughOperation();
                EndingGameOperation EndGame = new EndingGameOperation();


                Console.WriteLine($"Current User: {CurrentUser.CurrUser}");
                Console.WriteLine();
                if (score.GetScore() > 21)
                {
                    Console.WriteLine($"Overdraw! Your cards:");
                    cardst.ShowCards();
                    cardst.DropCards();
                    score.ResetScore();
                    Console.WriteLine("\n");
                }
                Console.WriteLine($"Dealer score: {dealer.ShowDScore()}");
                Console.Write("Dealer's Hand: ");
                if (cardsEnough.EnoughStatus() == false)
                    Console.WriteLine("** **");
                else
                {
                    string Dhand = "";
                    foreach (string x in DealersOperation.DealerHand)
                    {
                        Dhand += x;
                    }
                    Console.WriteLine($"{Dhand}");
                    dealer.DropDealerHand();
                }
                Console.WriteLine();
                Console.WriteLine($"Score: {score.GetScore().ToString()}");
                Console.WriteLine($"Your hand: ");
                cardst.ShowCards();
                Console.WriteLine();
                if (CardsEnoughOperation.isEnough == true)
                {
                    Console.WriteLine();
                    EndGame.Execute();
                    cardsEnough.ResetisEnough();
                    score.ResetScore();
                    dealer.DResetScore();
                    cardst.DropCards();
                    dealer.DropDealerHand();
                }
                else
                {

                }
                Console.WriteLine();
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine();
                }
                operationNames.Add("q - close program");
                operationNames.AddRange(_menu.GetOperationNames());

                Console.WriteLine(String.Join("\n", operationNames));
                Console.WriteLine("Enter operation number: ");

                string? userInput = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(userInput) && userInput.Trim().ToLower() == "q")
                {
                    isQuit = true;
                }
                else
                {
                    bool isNumber = int.TryParse(userInput, out int operationNumber);
                    if (isNumber)
                    {
                        _menu.Enter(operationNumber);
                    }
                }
                Console.Clear();
            }
        }
    }
}