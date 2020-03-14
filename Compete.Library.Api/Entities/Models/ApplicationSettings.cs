using Compete.Library.Api.Entities.Models.Interfaces;

namespace Compete.Library.Api.Entities.Models
{
    public class ApplicationSettings : IApplicationSettings
    {
        public string LogPath { get; set; }
    }
}
