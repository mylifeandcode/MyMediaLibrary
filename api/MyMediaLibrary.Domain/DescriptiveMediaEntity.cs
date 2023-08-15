namespace MyMediaLibrary.Domain
{
    public abstract class DescriptiveMediaEntity : MediaEntity
    {
        public string Description { get; set; } = "";
    }
}