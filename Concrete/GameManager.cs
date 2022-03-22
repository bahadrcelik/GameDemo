using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine( game.GameName + " "+"Oyun Sisteme Eklendi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " " + "Oyun Sistemden Silindi.");
        }

        public void Update(Game game, string version)
        {
            Console.WriteLine(game.GameName + " " + "Oyun Guncellendi");
        }
    }
}
