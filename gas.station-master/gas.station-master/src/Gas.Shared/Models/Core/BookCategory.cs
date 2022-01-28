namespace Gas.Shared.Models.Core
{
    public class BookCategory
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public int BookID { get; set; }

        public virtual Category Category { get; set; }
        public virtual Book Book { get; set; }
    }
}