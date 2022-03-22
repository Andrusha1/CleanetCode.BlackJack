namespace Cleanetcode.Blackjack
{
    class CardsEnoughOperation : IOperation 
    {
        DealersOperation dealerop = new DealersOperation();
        public string Name => "Enough";
        public static bool isEnough = false;
        public void Execute()
        {
            isEnough = true;
            dealerop.RunDealer();
        }
        public bool EnoughStatus()
        {
            return isEnough;
        }
        public void Enough()
        {
            
        }
        public void ResetisEnough()
        {
            isEnough=false;
        }
    }
}