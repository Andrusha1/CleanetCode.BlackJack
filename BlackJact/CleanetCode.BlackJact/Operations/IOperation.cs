namespace Cleanetcode.Blackjack
{

    public interface IOperation
    {
        public string Name { get; }

        public void Execute();
    }
}