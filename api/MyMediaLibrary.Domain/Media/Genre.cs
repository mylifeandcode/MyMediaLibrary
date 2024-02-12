using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMediaLibrary.Domain.Media
{
    public class Genre : MediaLibraryEntity
    {
        /// <summary>
        /// If a genre is specific to one or more categories, they are associated here.
        /// If a genre applies to all categories, the list is empty.
        /// </summary>
        /// <example>
        /// Sci-Fi, Rock, Documentary
        /// </example>
        public IReadOnlyList<Category> Categories { get; set; } = new List<Category>();
    }
}
