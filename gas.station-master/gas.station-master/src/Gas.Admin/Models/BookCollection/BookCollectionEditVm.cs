using System.Collections.Generic;

namespace Gas.Admin.Models.BookCollection
{
    public class BookCollectionEditVm : BookCollectionBaseVm
    {
        public int Id { get; set; }
        public IEnumerable<int> NewBooks { get; set; } = new List<int>();
        public IEnumerable<Shared.Models.Core.Book> AllBooks { get; set; } = new List<Shared.Models.Core.Book>();

        public BookCollectionEditVm()
        {
            
        }

        public BookCollectionEditVm(Shared.Models.Core.BookCollection item)
        {
            this.BookCollection = item;
        }
        public Shared.Models.Core.BookCollection GetDbModel()
        {
            return new Shared.Models.Core.BookCollection()
            {
                ID = this.BookCollection.ID,
                Title = this.BookCollection.Title,
                IsActive = this.BookCollection.IsActive,
                IsPublicationType = this.BookCollection.IsPublicationType,
            };
        }
    }
}