namespace Gas.Admin.Models.Author
{
    public class AuthorAddPostVm : AuthorBaseVm
    {
        public AuthorAddPostVm()
        {
            
        }
        public AuthorAddPostVm(Shared.Models.Core.Author item)
        {
            this.Author = item;
        }
        public Shared.Models.Core.Author GetDbModel()
        {
            return new Shared.Models.Core.Author()
            {
                IsActive = this.Author.IsActive,
                DeadYear = this.Author.DeadYear,
                BirthDate = this.Author.BirthDate,
                AuthorTranslations = this.Author.AuthorTranslations
            };
        }
    }
}