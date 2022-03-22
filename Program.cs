using GameDemo.Abstract;
using GameDemo.Concrete;
using GameDemo.Entities;
using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            Gamer gamer = new Gamer();
            gamer.FirstName = "Bahadır";
            gamer.Id = 1;
            gamer.BirthYear = 2002;
            gamer.LastName = "Celik";
            gamer.IdentityNumber = 12345;

            IGameService gameService = new GameManager();
            ICampaignService campaignService = new CampaignManager();
            IOrderService orderService = new OrderManager();

            gamerManager.Add(gamer);

            Console.WriteLine("-------------");



            Game game = new Game
            {
                
                GameName = "CS-GO",
                Id = 1,
                UnitPrice = 250,
                GameVersion = "1.0.1"
            };
            Campaign campaign = new Campaign
            {
                Id = 1,
                CampaignName = "Yaz indirimleri",
                DiscountPercent = 25
            };



            gameService.Add(game);
            gameService.Update(game, "1.3.5");
            gameService.Delete(game);


            Console.WriteLine("--------------------");

            campaignService.Add(campaign);
            campaignService.Update(campaign);
            campaignService.Delete(campaign);

            Console.WriteLine("---------------------");


            orderService.Sale(game);
            orderService.CampaignSale(game, gamer, campaign);
            orderService.cancelSale(game,gamer);
           
                
            
        }
    }
}
