using System;
using System.Collections.Generic;
using System.Text;
using Day5_Hw5.Entities;
using Day5_Hw5.Concrete;

namespace Day5_Hw5.Abstract
{
    interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);


    }
}
