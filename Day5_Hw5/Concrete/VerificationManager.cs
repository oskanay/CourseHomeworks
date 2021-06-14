using System;
using System.Collections.Generic;
using System.Text;
using Day5_Hw5.Abstract;
using Day5_Hw5.Entities;

namespace Day5_Hw5.Concrete
{
    class VerificationManager : IVerificationService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            if (gamer.NationalityId.Length == 11)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
