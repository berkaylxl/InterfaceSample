using System;
using System.Collections.Generic;
using System.Text;

namespace GamerSystem
{
    class UserValidationManager : IUserValidation
    {
        public bool Validate(Gamer gamer)
        {
            //Kimlik doğrulama Simülasyonu 
            if (gamer.BirthYear==2000 && gamer.FirstName=="Berkay"&&gamer.LastName=="Sakar"&&gamer.IdenityNumber==12453256412)
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
