using System.Collections.Generic;

namespace Gas.Admin.Models.Cover
{
    public class CoverEditVm : CoverBaseVm
    {
        public int Id { get; set; }
        public IEnumerable<Shared.Models.Core.Cover> Covers { get; set; } = new List<Shared.Models.Core.Cover>();

        public CoverEditVm()
        {
            
        }

        public CoverEditVm(Shared.Models.Core.Cover item)
        {
            this.Cover = item;
        }
        public Shared.Models.Core.Cover GetDbModel()
        {
            return new Shared.Models.Core.Cover()
            {
                ID = this.Cover.ID,
                CoverTranslations = this.Cover.CoverTranslations,
                IsActive = this.Cover.IsActive,
            };
        }
    }
}