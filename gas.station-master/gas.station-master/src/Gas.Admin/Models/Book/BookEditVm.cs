using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace Gas.Admin.Models.Book
{
    public class BookEditVm : BookBaseVm
    {
        public int Id { get; set; }
        public IEnumerable<int> NewCategories { get; set; } = new List<int>();
        public IEnumerable<Shared.Models.Core.Category> AllCategories { get; set; } = new List<Shared.Models.Core.Category>();
        public IEnumerable<int> NewAuthors { get; set; } = new List<int>();
        public IEnumerable<Shared.Models.Core.Author> AllAuthors { get; set; } = new List<Shared.Models.Core.Author>();

        public BookEditVm()
        {
            
        }

        public BookEditVm(Shared.Models.Core.Book item)
        {
            this.Book = item;
        }
        public Shared.Models.Core.Book GetDbModel()
        {
            return new Shared.Models.Core.Book()
            {
                ID = this.Book.ID,
                BookTranslations = this.Book.BookTranslations,
                BookAuthors = this.Book.BookAuthors,
                BookRelateds = this.Book.BookRelateds,
                BookCovers = this.Book.BookCovers,
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