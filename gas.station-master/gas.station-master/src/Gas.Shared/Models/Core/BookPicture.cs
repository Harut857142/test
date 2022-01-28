namespace Gas.Shared.Models.Core
{
    public class BookPicture
    {
        public int ID { get; set; }
        public string PictureUrl { get; set; }
        public int? BookID { get; set; }
        public bool IsActive { get; set; }

        public virtual Book Book { get; set; }
    }
}