﻿using GameRecap.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRecap
{
    class Game: IEntity
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        
    }
}
