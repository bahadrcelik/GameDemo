using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName +" "+gamer.LastName + " "+"Oyuncu EKlendi");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " " + "Oyuncu Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " " + "Oyuncu Bilgileri Güncellendi");    
        }
    }
}
