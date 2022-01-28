namespace Gas.Shared.Models.Core
{
    public class CategoryPicture
    {
        public int ID { get; set; }
        public string PictureUrl { get; set; }
        public int? CategoryID { get; set; }
        public bool IsActive { get; set; }

        public virtual Category Category { get; set; }
    }
}