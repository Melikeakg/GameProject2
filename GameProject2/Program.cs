using System;

namespace GameProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer 
            {
                FirstName = "Melike",
                LastName = "Akgül",
                BirthYear = 1999,
                NationalityId = 12345
            };

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer);
        }
    }
}
