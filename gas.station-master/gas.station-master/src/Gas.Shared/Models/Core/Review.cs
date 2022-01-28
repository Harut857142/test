using System;
using System.Collections.Generic;

namespace Gas.Shared.Models.Core
{
    public class Review
    {
        public int ID { get; set; }
        public string CoverImage { get; set; }
        public string Language { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Status { get; set; } = true;

        public virtual List<BookReview> BookReviews { get; set; } = new List<BookReview>();

        public virtual List<ReviewTranslation> ReviewTranslations { get; set; } = new List<ReviewTranslation>();
        public virtual List<ReviewPicture> ReviewPictures { get; set; } = new List<ReviewPicture>();
    }
}