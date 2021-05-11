using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamer
{
    class UserValidationManager : IUseerValidation
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.DogumYili == 1990 && gamer.FirstName == "Nil" && gamer.Id == 1 && gamer.IdentityNumber==12345 && gamer.LastName=="Nadirler" )
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
