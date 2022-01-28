namespace Gas.Shared.Models.Core
{
    public class AuthorPicture
    {
        public int ID { get; set; }
        public string PictureUrl { get; set; }
        public int? AuthorID { get; set; }
        public bool IsActive { get; set; }

        public virtual Author Author { get; set; }
    }
}