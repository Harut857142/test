namespace Gas.Shared.Models.Core
{
    public class BookReview
    {
        public int ID { get; set; }
        public int? BookID { get; set; }
        public int? ReviewID { get; set; }
        public string Language { get; set; }
        public bool IsActive { get; set; }

        public virtual Book Book { get; set; }
        public virtual Review Review { get; set; }
    }
}