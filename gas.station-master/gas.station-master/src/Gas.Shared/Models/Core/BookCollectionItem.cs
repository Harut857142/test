namespace Gas.Shared.Models.Core
{
    public class BookCollectionItem
    {
        public int ID { get; set; }
        public int? BookID { get; set; }
        public int? BookCollectionID { get; set; }
        public bool IsActive { get; set; }

        public virtual Book Book { get; set; }
        public virtual BookCollection BookCollection { get; set; }
    }
}