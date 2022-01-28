using System.Collections.Generic;

namespace Gas.Admin.Models.BookLanguage
{
    public class BookLanguageEditVm : BookLanguageBaseVm
    {
        public int Id { get; set; }
        public IEnumerable<Shared.Models.Core.BookLanguage> BookLanguages { get; set; } = new List<Shared.Models.Core.BookLanguage>();

        public BookLanguageEditVm()
        {
            
        }

        public BookLanguageEditVm(Shared.Models.Core.BookLanguage item)
        {
            this.BookLanguage = item;
        }
        public Shared.Models.Core.BookLanguage GetDbModel()
        {
            return new Shared.Models.Core.BookLanguage()
            {
                ID = this.BookLanguage.ID,
                BookLanguageTranslations = this.BookLanguage.BookLanguageTranslations,
                IsActive = this.BookLanguage.IsActive,
            };
        }
    }
}