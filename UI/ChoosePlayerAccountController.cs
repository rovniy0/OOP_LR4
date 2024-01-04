using Lab4_oop.DB.Entity.GameAccounts;
using Lab4_oop.DB.Services;
using Lab4_oop.Accounts;
using Lab4_oop.DB.Entity;
using Lab4_oop.DB.Services.Base;

namespace Lab4_oop.UI
{
    public class ChoosePlayerAccountController : IUserInterface
    {
        IGameAccountService _accountService;
        public ChoosePlayerAccountController(IGameAccountService accountService)
        {
            _accountService = accountService;
        }
        public void Action()
        {
            Console.WriteLine("Оберіть аккаунт: \n | 1. StandardGameAccount | 2. PremiumGameAccount | 3. ProGameAccount |:");
            int temp = Convert.ToInt32(Console.ReadLine());
            var id = _accountService.GetAll().Count();

            switch (temp)
            {
                case 1:
                    var standardGameAccount = new GameAccount(_accountService, id);
                    _accountService.Create(standardGameAccount);
                    break;

                case 2:
                    var bonusGameAccount = new PremiumGameAccount(_accountService, id);
                    _accountService.Create(bonusGameAccount);
                    break;

                case 3:
                    var streakGameAccount = new ProGameAccount(_accountService, id);
                    _accountService.Create(streakGameAccount);
                    break;

                default:
                    Console.WriteLine("\nВведене значення є некоректним");
                    Action();
                    break;
            }
        }

    }
}
