using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRecap
{
    interface ISalesService
    {
        void Sell(Gamer gamer, Game game, Sales sales);
        void CampaingSell(Gamer gamer, Game game, Sales sales, Campaing campaing);

    }
}
