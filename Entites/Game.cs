using GameDemo.Abstract;

namespace GameDemo.Entities
{
    public class Game : IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public double UnitPrice { get; set; }
        public string GameVersion { get; set; }
    }
}