using System;
using System.Collections.Generic;
using System.Text;
using Day5_Hw5.Entities;

namespace Day5_Hw5.Abstract
{
    interface ISaleServer
    {
        void Sale(Gamer gamer, Game game,Campaign campaign);
    }
}
