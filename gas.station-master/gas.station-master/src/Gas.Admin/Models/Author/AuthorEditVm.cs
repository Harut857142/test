namespace Gas.Admin.Models.Author
{
    public class AuthorEditVm : AuthorBaseVm
    {
        public int Id { get; set; }

        public AuthorEditVm()
        {
            
        }

        public AuthorEditVm(Shared.Models.Core.Author item)
        {
            this.Author = item;
        }
        public Shared.Models.Core.Author GetDbModel()
        {
            return new Shared.Models.Core.Author()
            {
                ID = this.Author.ID,
                IsActive = this.Author.IsActive,
                DeadYear = this.Author.DeadYear,
                BirthDate = this.Author.BirthDate,
                AuthorTranslations = this.Author.AuthorTranslations
            };
        }
    }
}