using System;
using System.Collections.Generic;

namespace Gas.Shared.Models.Core
{
    public class BookCollection
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public bool IsPublicationType { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Status { get; set; } = true;

        public virtual List<BookCollectionItem> BookCollectionItems { get; set; } = new List<BookCollectionItem>();
    }
}