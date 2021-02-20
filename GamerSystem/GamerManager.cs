using System;
using System.Collections.Generic;
using System.Text;

namespace GamerSystem
{
    class Gamer_Manager : IGamerService
    {
        IUserValidation _userValidation;

        public Gamer_Manager(IUserValidation userValidation)
        {
            _userValidation = userValidation;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidation.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt olundu");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız,kayıt olunamadı");
            }
          
        }

        public void Delete(Gamer gamer)
        {
            throw new NotImplementedException("Kayıt Silindi");
        }

        public void Update(Gamer gamer)
        {
            throw new NotImplementedException("Kayıt Güncellendi");
        }
    }
}
