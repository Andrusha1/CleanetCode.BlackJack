namespace Cleanetcode.Blackjack
{

    public interface IOperation
    {
        string Name { get; }

        void Execute();
    }
}