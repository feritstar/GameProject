using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            GamerManager gamerManager2 = new GamerManager(new NewUserValidationManager());
            OrderManager orderManager = new OrderManager();
            GameManager gameManager = new GameManager();

            gamerManager.Add(new Gamer 
            { 
                Id = 1, 
                BirthYear = 1985, 
                FirstName = "Ferit", 
                LastName = "Star", 
                IdentityNumber = 12345 
            });

            gamerManager2.Add(new Gamer 
            { 
                Id = 1, 
                BirthYear = 1984, 
                FirstName = "Ferit", 
                LastName = "Star", 
                IdentityNumber = 12345 
            });

            orderManager.Add(new Campaign
            {
                Name = "Big Spring Discount",
                Discount = 20
            });

            gameManager.Add(new Game
            {
                GameId = 1,
                GameName = "Counter Strike Global Offensive"
            });

            Console.WriteLine("Hello World!");
        }
    }
}
