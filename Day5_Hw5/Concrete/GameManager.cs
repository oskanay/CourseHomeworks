using System;
using System.Collections.Generic;
using System.Text;
using Day5_Hw5.Abstract;
using Day5_Hw5.Entities;

namespace Day5_Hw5.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine
         (game.GameCategory + " kategorili " + game.GameName + " isimli oyun " + game.GamePrice + " fiyata kütüphanenize eklenmiştir. ");
        }

        public void Delete(Game game)
        {
            Console.WriteLine
        (game.GameCategory + " kategorili " + game.GameName + " isimli oyun kütüphanenizden silinmiştir.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameCategory + " kategorili " + game.GameName + " isimli oyun güncellenmiştir.");
        }
    }
}
