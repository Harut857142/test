namespace Gas.Shared.Models.Core
{
    public class BookCover
    {
        public int ID { get; set; }
        public int? BookID { get; set; }
        public int? CoverID { get; set; }
        public string Isbn { get; set; }
        public bool IsActive { get; set; }

        public virtual Book Book { get; set; }
        public virtual Cover Cover { get; set; }
    }
}