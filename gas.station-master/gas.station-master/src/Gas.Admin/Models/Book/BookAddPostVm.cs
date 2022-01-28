using System.Collections.Generic;

namespace Gas.Admin.Models.Book
{
    public class BookAddPostVm : BookBaseVm
    {
        public IEnumerable<int> NewCategories { get; set; } = new List<int>();
        public IEnumerable<Shared.Models.Core.Category> AllCategories { get; set; } = new List<Shared.Models.Core.Category>();
        public IEnumerable<int> NewAuthors { get; set; } = new List<int>();
        public IEnumerable<Shared.Models.Core.Author> AllAuthors { get; set; } = new List<Shared.Models.Core.Author>();
        
        public BookAddPostVm()
        {
            
        }
        public BookAddPostVm(Shared.Models.Core.Book item)
        {
            this.Book = item;
        }
        public Shared.Models.Core.Book GetDbModel()
        {
            return new Shared.Models.Core.Book()
            {
                BookTranslations = this.Book.BookTranslations,
                BookAuthors = this.Book.BookAuthors,
                BookCovers = this.Book.BookCovers,
                BookRelateds = this.Book.BookRelateds,
                IsActive = this.Book.IsActive,
                BookLanguageID = this.Book.BookLanguageID,
                PublicationType = this.Book.PublicationType,
                IsVat = this.Book.IsVat,
                Isbn = this.Book.Isbn,
                Year = this.Book.Year,
                ReYear = this.Book.ReYear,
                Language = this.Book.Language,
                CoverPictureUrl = this.Book.CoverPictureUrl,
                Size = this.Book.Size,
                Weight = this.Book.Weight,
                PagesCount = this.Book.PagesCount,
                Price = this.Book.Price,
            };
        }
    }
}