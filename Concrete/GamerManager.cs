using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + gamer.LastName+" Registration Successful.");
            }
            else
            {
                Console.WriteLine("Validation is Failed!, Registration is UnSuccessful. ");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Registration Deleted.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Registration Updated.");
        }
    }
}
