namespace Gas.Shared.Models.Core
{
    public class BookRelated
    {
        public int ID { get; set; }
        public int? BookID { get; set; }
        public string Role { get; set; }
        public bool IsActive { get; set; }
        public virtual Book Book { get; set; }
    }
}