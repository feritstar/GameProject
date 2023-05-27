using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IGameService
    {
        public void Add(Game game);
        public void Delete(Game game);
        public void Update(Game game);
    }
}
