using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRecap
{
    class GamerManager : BaseGamerManager
    {
        private IUserValidationService _userValidationService;

        public  GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public override void Add(Gamer gamer)
        {
            if (_userValidationService.Validation(gamer))
            {
                base.Add(gamer);
            }
            else
            {
                throw new Exception("Not a vilid Person" + gamer.FirstName);
            }
        }

        public override void Delete(Gamer gamer)
        {
            base.Delete(gamer);
        }

        public override void Update(Gamer gamer)
        {
            base.Update(gamer);
        }

    }
}
