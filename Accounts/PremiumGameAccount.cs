using Lab4_oop.DB.Entity;
using Lab4_oop.DB.Services.Base;

namespace Lab4_oop.Accounts
{
    public class PremiumGameAccount : GameAccount
    {
        IGameAccountService _service;
        public PremiumGameAccount(IGameAccountService service, int ID, int gamesCount = 0, int indicator = 1)
            : base(service, ID, gamesCount, indicator)
        {
            _service = service;
            Id = ID;
        }

        public override int CalculateRatingChange(int ratingChange, int player1Number, int player2Number)
        {

            if (player1Number > player2Number)
            {
                return ratingChange + ratingChange / 2;
            }
            if (player2Number > player1Number)
            {
                return ratingChange / 2;
            }
            return 0;
        }
    }
}
