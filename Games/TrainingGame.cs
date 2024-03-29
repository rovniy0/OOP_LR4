﻿using Lab4_oop.DB.Entity;
using Lab4_oop.DB.Services.Base;
using Lab4_oop.Games;


namespace Lab4_oop
{
    public class TrainingGame : Game
    {
        public TrainingGame(GameAccount player1, GameAccount player2, IGameService service, int indicator=2) : base(player1, player2, service, indicator)
        {
            this.player1 = player1;
            this.player2 = player2;
            _service = service;
        }
        public override int getPlayRating(GameAccount player, int player1Number, int player2Number)
        { 
            return 0;
        }
    }
}
