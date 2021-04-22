using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRecap
{
    interface IUserValidationService
    {
        bool Validation(Gamer gamer);
    }
}
