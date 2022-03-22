using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
     public  interface ICampaignService
    {
         void Add(Campaign campaign);
         void Update(Campaign campaign);
         void Delete(Campaign campaign);
    }
}
