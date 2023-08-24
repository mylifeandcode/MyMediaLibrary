namespace MyMediaLibrary.Domain.Media
{
    public abstract class DescriptiveMediaEntity : MediaLibraryEntity
    {
        public string Description { get; set; } = "";
    }
}