namespace Cleanetcode.Blackjack
{
    class RefreshScreenOperation : IOperation
    {
        public string Name => "Refresh screen";
        
        public void Execute()
        {
            Console.Clear();
        }
    }
}