using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaignManager
    {
        void Add(Campaign campaign, Game game);
        void Update(Campaign campaign, Game game);
        void Delete(Campaign campaign, Game game);

    }
}
