using System;
using System.Collections.Generic;
using System.Text;
using Day5_Hw5.Concrete;
using Day5_Hw5.Entities;

namespace Day5_Hw5.Abstract
{
    interface IVerificationService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
