using System.Collections.Generic;

namespace Gas.Shared.Models.Core
{
    public class RelatedBook
    {
        public int ID { get; set; }
        public int? BookID { get; set; }
        public bool IsActive { get; set; }

        public virtual Book Book { get; set; }
    }
}