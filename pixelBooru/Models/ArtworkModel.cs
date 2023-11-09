namespace pixelBooru.Models
{
    public class Artwork
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Tags { get; set; }
        public string ArtDescription { get; set; }
        public int Likes { get; set; }
        public int UID { get; }
        public DateTime DateUploaded { get; set; }
    }
}