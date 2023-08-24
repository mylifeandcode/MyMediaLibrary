using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMediaLibrary.Domain.Media
{
    /// <summary>
    /// The base class for media library entities
    /// </summary>
    public abstract class MediaLibraryEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "";
        public Guid CreatedByUserId { get; set; }
        public Guid CreatedDateTime { get; set; }
        public Guid? ModifiedByUserId { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
    }
}
