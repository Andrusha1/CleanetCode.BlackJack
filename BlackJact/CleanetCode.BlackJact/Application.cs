namespace Cleanetcode.Blackjack
{
    class Application
    {
        CardGenerator generate = new CardGenerator();
        List<string> cards = new List<string>();
        string card = generate.GetCard(); //как это правильно реализовать

    }
}