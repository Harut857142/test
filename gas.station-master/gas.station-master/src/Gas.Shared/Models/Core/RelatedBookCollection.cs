namespace Gas.Shared.Models.Core
{
    public class RelatedBookCollection
    {
        public int ID { get; set; }
        public int? RelatedBookID { get; set; }
        public int? BookID { get; set; }
        public bool IsActive { get; set; }

        public virtual RelatedBook RelatedBook { get; set; }
        public virtual Book Book { get; set; }
    }
}