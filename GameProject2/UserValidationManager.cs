using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName == "Melike" && gamer.LastName=="Akgül" && gamer.NationalityId == 12345 && gamer.BirthYear == 1999 )
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
