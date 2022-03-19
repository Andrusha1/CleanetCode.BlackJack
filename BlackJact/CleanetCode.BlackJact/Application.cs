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
            }
        }
    }
}