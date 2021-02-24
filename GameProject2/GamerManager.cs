using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2
{
    class GamerManager : IGamerService
    {
        IUserValidationService userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            this.userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı eklendi.");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı güncellendi.");
        }
    }
}
