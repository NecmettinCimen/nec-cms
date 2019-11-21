namespace NecCms.Database
{
    public abstract class Etkinlikler : BaseEntity
    {
        public int IcerikId { get; set; }
        public Icerik.Icerikler Icerik { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}