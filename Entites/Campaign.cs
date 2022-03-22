using GameDemo.Abstract;
using System;

namespace GameDemo.Entities
{
    public class Campaign : IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }

        public int DiscountPercent { get; set; }
        public DateTime CampaignTime { get; set; }
    }
}