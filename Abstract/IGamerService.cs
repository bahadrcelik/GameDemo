using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameDemo.Entities;

namespace GameDemo.Abstract
{
    public interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);

        void Delete(Gamer gamer);

    }
}
