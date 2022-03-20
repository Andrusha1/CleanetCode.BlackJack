namespace Cleanetcode.Blackjack;

class ScoreCountOperation : IOperation
{
    public string Name => "Show current score";

    public static int Score = 0;

    public void Execute()
    {

    }
    public int GetScore()
    {
        return Score;
    }

    public void ResetScore()
    {
        Score = 0;
    }

    public void ScoreUpdate(string card)
    {
        string cardNum = card.Substring(0, card.Length - 1);
        if (int.TryParse(cardNum, out int cardNumInt))
        {
            Score += cardNumInt;
        }
        else  if(cardNum == "J")
        {
            Score += 10;
        }
        else if (cardNum == "Q")
        {
            Score += 10;
        }
        else if (cardNum == "K")
        {
            Score += 10;
        }
        else if (cardNum == "A")
        {
            if(Score >= 11)
            {
                Score += 1;
            }
            else
            {
                Score += 11;
            }
        }
    }
}