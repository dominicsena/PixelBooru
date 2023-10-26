namespace pixelBooru.Models
{
    public class Artwork
    {
        public int ArtID { get; set; }
        public string ArtworkName { get; set; }
        public string Artist { get; set; }
        public string Tags { get; set; }
        public string ArtworkDescription { get; set; }
        public int Likes { get; set; }
        public int UID { get; }
    }
}