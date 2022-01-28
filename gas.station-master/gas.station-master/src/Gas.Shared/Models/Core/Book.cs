using System;
using System.Collections.Generic;

namespace Gas.Shared.Models.Core
{
    public class Book
    {
        public int ID { get; set; }
        public string Isbn { get; set; }
        public int? Year { get; set; }
        public int? ReYear { get; set; }
        public string Language { get; set; }
        public string CoverPictureUrl { get; set; }
        public string PublicationType { get; set; }
        public string Size { get; set; }
        public int? Weight { get; set; }
        public int? PagesCount { get; set; }
        public int? Price { get; set; }
        public int? BookLanguageID { get; set; }
        public bool IsVat { get; set; }
        public string CoverPhoto { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Status { get; set; } = true;

        public virtual BookLanguage BookLanguage { get; set; }
        public virtual List<BookAuthor> BookAuthors { get; set; } = new List<BookAuthor>();
        public virtual List<BookPicture> BookPictures { get; set; } = new List<BookPicture>();
        public virtual List<BookArticle> BookArticles { get; set; } = new List<BookArticle>();
        public virtual List<BookReview> BookReviews { get; set; } = new List<BookReview>();
        public virtual List<BookCover> BookCovers { get; set; } = new List<BookCover>();
        public virtual List<BookTranslation> BookTranslations { get; set; } = new List<BookTranslation>();
        public virtual List<BookRelated> BookRelateds { get; set; } = new List<BookRelated>();
        public virtual List<BookCollectionItem> BookCollectionItems { get; set; } = new List<BookCollectionItem>();
        public virtual List<BookCategory> BookCategories { get; set; } = new List<BookCategory>();
    }
}