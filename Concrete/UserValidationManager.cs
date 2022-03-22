using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.BirthYear== 1985 &&
                gamer.FirstName=="Bahadır" &&
                gamer.LastName=="Celik"&&
                gamer.IdentityNumber==123456)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}
