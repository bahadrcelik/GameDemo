using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameDemo.Concrete
{
    public class OrderManager : IOrderService
    {
       
        public void cancelSale(Game game, Gamer gamer)
        {
            Console.WriteLine(game.GameName + " Siparis Ettiginiz Oyun Iptal Edilmistir " +"/"+ " Oyuncu : " + gamer.FirstName.ToUpper()+ " "+gamer.LastName.ToUpper());
        }

        public void Sale(Game game)
        {
            Console.WriteLine(game.GameName + " Siparis Edildi. " + " " +"Oyunun Fiyatı : " +" "+ game.UnitPrice +" - "+ " Siparisiniz İcin Tesekkür Ederiz  ");
        }

        public void CampaignSale(Game game, Gamer gamer, Campaign campaign)
        {
            
            game.UnitPrice = game.UnitPrice - (game.UnitPrice * campaign.DiscountPercent / 100);
            Console.WriteLine(game.GameName + " "+"Kampanyalı Oyun Siparis Edildi. " + "Oyunun  Indirimli Fiyatı :  "+game.UnitPrice +"- "+
                                "Tesekkür Ederiz  " + " /"+ " Oyuncu : "+gamer.FirstName.ToUpper()+" "+gamer.LastName.ToUpper());
        }
    }
}
