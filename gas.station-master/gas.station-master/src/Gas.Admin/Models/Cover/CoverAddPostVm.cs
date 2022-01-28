namespace Gas.Admin.Models.Cover
{
    public class CoverAddPostVm : CoverBaseVm
    {
        public CoverAddPostVm()
        {
            
        }
        public CoverAddPostVm(Shared.Models.Core.Cover item)
        {
            this.Cover = item;
        }
        public Shared.Models.Core.Cover GetDbModel()
        {
            return new Shared.Models.Core.Cover()
            {
                CoverTranslations = this.Cover.CoverTranslations,
                IsActive = this.Cover.IsActive,
            };
        }
    }
}