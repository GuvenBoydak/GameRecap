using GameRecap.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRecap
{
    class Campaing: IEntity
    {
        public string CampaingName { get; set; }
        public int CampaingDiscount { get; set; }
    }
}
