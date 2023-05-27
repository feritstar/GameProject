using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " is Added.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " is Deleted.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " is Updated.");
        }
    }
}
