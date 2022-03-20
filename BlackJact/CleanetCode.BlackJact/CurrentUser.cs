namespace Cleanetcode.Blackjack
{
    class CurrentUser
    {
        public static string CurrUser = "Unknown";
        public void AddUser(string Name)
        {
            CurrUser = Name;
        }
        
        public string GetCurrentUser()
        {
            return CurrUser;
        }
    }
}