﻿using Lab4_oop.DB.Entity;

namespace Lab4_oop.DB.Services.Base
{
    public interface IGameAccountService
    {
        public void Create(GameAccount entity);
        public List<GameAccount> GetAll();
        public GameAccount GetById(int id);
        public void Update(GameAccount entity);
        public void Delete(GameAccount entity);
        public List<GameResult> GetHistory(GameAccount entity);
        public void AddGameResult(GameResult gameResult, GameAccount entity);
    }
}
