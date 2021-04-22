using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRecap
{
    class UserValidationManager : IUserValidationService
    {  

        public bool Validation(Gamer gamer)
        {
            return true;
        }
    }
}
