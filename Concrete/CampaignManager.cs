using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete

{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " + " Kampanyası Basladı !");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+ " " + "Kampanyası Bitmistir");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+ " " + "Kampanyası Guncellendi");
        }
    }
}
