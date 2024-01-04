using Lab4_oop.DB.Entity;
using Lab4_oop.DB.Services.Base;

namespace Lab4_oop.UI
{
    public class ChooseGameTypeController : IUserInterface
    {
        IGameService _gameService;
        IGameAccountService _accountService;
        GameAccount _player1;
        GameAccount _player2;

        public ChooseGameTypeController(IGameService gameService, IGameAccountService accountService)
        {
            _gameService = gameService;
            _accountService = accountService;
        }
        public void Action()
        {
            _player1 = _accountService.GetById(_accountService.GetAll().Count - 2);
            _player2 = _accountService.GetById(_accountService.GetAll().Count - 1);

            Console.WriteLine("Оберіть тип гри: \n | 1. Standard game | 2. Training game | 3. AllRating game:");

            int temp = Convert.ToInt32(Console.ReadLine());
            GameFactory gameFactory = new GameFactory();

            switch (temp)
            {
                case 1:
                    _gameService.Create(gameFactory.CreateGame(_player1, _player2, _gameService));
                    break;

                case 2:
                    _gameService.Create(gameFactory.CreateTrainingGame(_player1, _player2, _gameService));
                    break;

                case 3:
                    _gameService.Create(gameFactory.CreateAllinGame(_player1, _player2, _gameService));
                    break;

                default:
                    Console.WriteLine("\nВведене значення є некоректним");
                    Action();
                    break;
            }
        }

    }
}
