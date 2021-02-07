using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameSellManager : IGameManager
    {


        public void Sell(Game game, Gamer gamer)
        {
            Console.WriteLine(game.GameName + " " + "selled to" + " " + gamer.FirstName + " " + gamer.LastName);
        }

    }    

}
