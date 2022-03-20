using Cleanetcode.Blackjack;

class CardsStorage
{
    public static List<string> cards = new List<string>();
    public static List<string> userCards = new List<string>();
    public void AddCard(string card)
    {
        cards.Add(card);
    }

    public void UserCardAdd(string card)
    {
        userCards.Add(card);
    }

    public bool isContain(string card)
    {
        if (cards.Contains(card))
        {
            return true;
        }
        return false;
    }


    public void ShowCards()
    {
        for (int i = 0; i < userCards.Count; i++)
        {
            Console.Write($"{cards[i]} " );
        }
    }

    public void DropCards()
    {
        userCards.Clear();
        cards.Clear();
    }
}