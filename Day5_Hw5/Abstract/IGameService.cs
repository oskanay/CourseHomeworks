using System;
using System.Collections.Generic;
using System.Text;
using Day5_Hw5.Entities;

namespace Day5_Hw5.Abstract
{
    interface IGameService
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}
