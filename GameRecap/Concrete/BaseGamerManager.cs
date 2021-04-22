using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRecap
{
    abstract class BaseGamerManager : IGamerService
    {
        public virtual void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " Eklendi");
        }

        public virtual void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " Silindi");
        }

        public virtual void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " Güncellendi");
        }
    }
}
