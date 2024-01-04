using Lab4_oop.DB.Services.Base;
using System;

namespace Lab4_oop.UI
{
    public class StartOptionsController : IUserInterface
    {
        ChooseGameTypeController gameUI;
        ChoosePlayerAccountController playerUI;
        PlayGameController playGameUI;
        ShowPlayersUI showPlayersUI;
        StartGameController startGameUI;
        IGameAccountService _accountService;
        IGameService _gameService;
        public StartOptionsController(IGameAccountService accountService, IGameService gameService) 
        {
            _accountService= accountService;
            _gameService= gameService;
            gameUI = new ChooseGameTypeController(_gameService, _accountService);
            playerUI = new ChoosePlayerAccountController(_accountService);
            playGameUI = new PlayGameController(_accountService, _gameService);
            showPlayersUI = new ShowPlayersUI(_accountService);
            startGameUI = new StartGameController(_accountService, _gameService);
        }
        public void Action()
        {
            Console.WriteLine("1. Почати гру");
            Console.WriteLine("2. Список гравців");
            Console.WriteLine("3. Інфо гравця (id)\n");

            int response = Convert.ToInt32(Console.ReadLine());

            if (response == 1)
            {
                playerUI.Action();
                playerUI.Action();
                gameUI.Action();
                startGameUI.Action();
                playGameUI.Action();
            }
            else if (response == 2)
            {
                showPlayersUI.Action();
            }
            else if (response == 3)
            {
                Console.Write("ID: ");
                int id = Convert.ToInt32(Console.ReadLine());
                var showPlayerByIdUI = new ShowPlayerByIDController(_accountService, id);
                showPlayerByIdUI.Action();
            }
            else
            {
                Console.WriteLine("\nВведене некоректне значення!");
                Action();
            }

            Action();
        }
    }
}
