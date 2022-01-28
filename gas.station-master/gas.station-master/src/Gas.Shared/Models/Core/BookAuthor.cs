namespace Gas.Shared.Models.Core
{
    public class BookAuthor
    {
        public int ID { get; set; }
        public int? BookID { get; set; }
        public int? AuthorID { get; set; }
        public string Role { get; set; }
        public bool IsActive { get; set; }
        public virtual Book Book { get; set; }
        public virtual Author Author { get; set; }
    }
}