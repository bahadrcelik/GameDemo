using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    public interface IOrderService
    {
        
            public void Sale(Game game);
            public void CampaignSale(Game game, Gamer gamer, Campaign campaign);
            public void cancelSale(Game game, Gamer gamer);
      
    }
}
