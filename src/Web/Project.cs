namespace Web
{
    public class Project
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public List<string> Tags { get; set; } = new List<string>();

        public List<string> Thumbnails { get; set; } = new List<string>();

        public string? Teaser { get; set; }
    }
}