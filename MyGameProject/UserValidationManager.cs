using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {

        public bool Validate(Gamer gamer)
        {
            if (gamer.Id==1 && gamer.DateOfBirth==2000 && gamer.FirstName=="Osman" && gamer.LastName=="Bal" && gamer.NationalityId==12354562251)
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
