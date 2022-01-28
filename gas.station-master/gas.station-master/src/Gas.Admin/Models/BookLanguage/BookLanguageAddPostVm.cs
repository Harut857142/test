namespace Gas.Admin.Models.BookLanguage
{
    public class BookLanguageAddPostVm : BookLanguageBaseVm
    {
        public BookLanguageAddPostVm()
        {
            
        }
        public BookLanguageAddPostVm(Shared.Models.Core.BookLanguage item)
        {
            this.BookLanguage = item;
        }
        public Shared.Models.Core.BookLanguage GetDbModel()
        {
            return new Shared.Models.Core.BookLanguage()
            {
                BookLanguageTranslations = this.BookLanguage.BookLanguageTranslations,
                IsActive = this.BookLanguage.IsActive,
            };
        }
    }
}