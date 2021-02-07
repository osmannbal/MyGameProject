using GameProject;
using System;

namespace MyGameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer() { FirstName = "Osman", LastName = "Bal" };
            Campaign campaign = new Campaign() { CampaignName = "February campaign", DiscountRate = 30 };
            Game game = new Game() { GameName = "Counter Strike Go", GamePrice = 40 };


            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                DateOfBirth = 2000,
                FirstName = "Osman",
                LastName = "Bal",
                NationalityId = 12354562251
            });
            gamerManager.Delete(new Gamer
            {
                Id = 1,
                DateOfBirth = 2000,
                FirstName = "Osman",
                LastName = "Bal",
                NationalityId = 12354562251
            });
            gamerManager.Update(new Gamer
            {
                Id = 1,
                DateOfBirth = 2000,
                FirstName = "Burak",
                LastName = "Uçan",
                NationalityId = 12354562251
            });




            GameSellManager gameSellManager = new GameSellManager();
            gameSellManager.Sell(game, gamer);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign, game);
        }
    }
}
