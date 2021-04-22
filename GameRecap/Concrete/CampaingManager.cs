using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRecap
{
    class CampaingManager : ICampaingservice
    {
        public void Add(Campaing campaing)
        {
            Console.WriteLine(campaing.CampaingName + "  " + campaing.CampaingDiscount + "Eklendi");
        }

        public void Delete(Campaing campaing)
        {
            Console.WriteLine(campaing.CampaingName + "  " + campaing.CampaingDiscount + "Silindi");

        }

        public void Update(Campaing campaing)
        {
            Console.WriteLine(campaing.CampaingName + "  " + campaing.CampaingDiscount + "Güncellendi");

        }
    }
}
