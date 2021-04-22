using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRecap
{
    class SalesManager : ISalesService
    {
        public void CampaingSell(Gamer gamer, Game game, Sales sales,Campaing campaing)
        {
            sales.Price = sales.Price * (100 - campaing.CampaingDiscount) / 100;
            Console.WriteLine(sales.salerName + " " + game.GameName + " oyununu " + "%" +
                campaing.CampaingDiscount + " indirim ile " + gamer.FirstName + "'e Sattı.");
        }
        
        public void Sell(Gamer gamer, Game game, Sales sales)
        {
            
            Console.WriteLine(gamer.FirstName + "  " + game.GameName + " Oyununu " + sales.Price + " Tl'ye Satın Aldı");
        }
    }
}
