﻿using Lab4_oop.Games;


namespace Lab4_oop.DB.Services.Base
{
    public interface IGameService
    {
        public void Create(Game entity);
        public List<Game> GetAll();
        public Game GetById(int Id);
        public void Update(Game entity);
        public void Delete(Game entity);
    }
}
