using Lab4_oop.DB.Entity;
using Lab4_oop.DB.Services.Base;

namespace Lab4_oop.UI
{
    public class ShowPlayerByIDController : IUserInterface
    {
        IGameAccountService _accountService;
        int _id;
        public ShowPlayerByIDController(IGameAccountService accountService, int id)
        {
            _accountService = accountService;
            _id = id;
        }

        public void Action()
        {
            GameAccount acc = _accountService.GetById(_id);
            Console.WriteLine(acc.GetStats()); 
        }
    }
}
