using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMediaLibrary.Domain.Media
{
    /// <summary>
    /// A single piece of Media.
    /// It can be a TV series, a movie, an album of music, etc.
    /// The format, genres, etc, are determined by the properties.
    /// </summary>
    /// <example>
    /// The Blu-ray of Avengers: Endgame
    /// </example>
    public class Media : DescriptiveMediaEntity
    {
        public MediaType MediaType { get; set; }
        public Format Format { get; set; }
        public Category Category { get; set; }
        public Category? SubCategory { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public Location Location { get; set; }
        public IEnumerable<Tag>? Tags { get; set; }
        public Guid UserId { get; set; }
    }
}
