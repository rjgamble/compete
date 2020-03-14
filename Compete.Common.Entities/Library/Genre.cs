namespace Compete.Common.Entities.Library
{
    public class Genre : BaseEntity
    {
        public string Abbreviation { get; set; }
        public Genre SubGenre { get; set; }
    }
}