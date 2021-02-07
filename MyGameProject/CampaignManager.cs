using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignManager
    {
        public void Add(Campaign campaign, Game game)
        {
            Console.WriteLine(campaign.CampaignName + " " + "added to" + " " + game.GameName);
        }

        public void Delete(Campaign campaign, Game game)
        {
            Console.WriteLine(campaign.CampaignName + " " + "deleted to" + " " + game.GameName);
        }

        public void Update(Campaign campaign, Game game)
        {
            Console.WriteLine(campaign.CampaignName + " " + "updated" + " " + game.GameName);
        }
    }
}
