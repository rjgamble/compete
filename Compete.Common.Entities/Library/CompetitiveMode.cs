using System.Collections.Generic;

namespace Compete.Common.Entities.Library
{
    public class CompetitiveMode : BaseEntity
    {
        public int MaxPlayersPerTeam { get; set; } = 1;
        public Genre Genre { get; set; }
        public IEnumerable<Platform> Platform { get; set; }
        public bool IsCrossPlatform { get; set; }
    }
}