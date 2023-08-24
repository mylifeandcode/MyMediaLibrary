using MyMediaLibrary.Domain;

namespace MyMediaLibrary.API.Models
{
    public class MediaDTO : DescriptiveMediaEntity
    {
        public Guid MediaTypeId { get; set; }
        public Guid FormatId { get; set; }
        public Guid CategoryId { get; set; }
        public Guid? SubCategoryId { get; set; }
        public IEnumerable<Guid> GenreIds { get; set; }
        public Guid LocationId { get; set; }
        public IEnumerable<Guid>? TagIds { get; set; }
    }
}
