using GameRecap.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRecap
{
    class Sales: IEntity
    {
        public int SalesId { get; set; }
        public string salerName { get; set; }
        public decimal Price { get; set; }

    }
}
