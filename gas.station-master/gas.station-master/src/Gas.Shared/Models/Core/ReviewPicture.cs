using System.Collections.Generic;

namespace Gas.Shared.Models.Core
{
    public class ReviewPicture
    {
        public int ID { get; set; }
        public string PictureUrl { get; set; }
        public int? ReviewID { get; set; }
        public bool IsActive { get; set; }

        public virtual Review Review { get; set; }
    }
}