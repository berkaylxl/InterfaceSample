using System;

namespace GamerSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer_Manager gamer_Manager = new Gamer_Manager(new UserValidationManager());
            gamer_Manager.Add(new Gamer {
                BirthYear = 2000,
                FirstName = "Berkay",
                LastName = "Sakar", 
                IdenityNumber= 12453256412 
            });


           
        }
    }
}
