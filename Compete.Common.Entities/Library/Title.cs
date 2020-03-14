using System.Collections.Generic;

namespace Compete.Common.Entities.Library
{
    public class Title : BaseEntity
    {
        public Author Author { get; set; }
        public string Version { get; set; }
        public Genre Genre { get; set; }
        public IEnumerable<CompetitiveMode> CompetitiveModes { get; set; } = new List<CompetitiveMode>();
    }
}