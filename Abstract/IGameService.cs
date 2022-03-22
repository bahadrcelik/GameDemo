using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    public interface IGameService
    {
         void Add(Game game);
         void Delete(Game game);
         void Update(Game game, string version);
    }
}
