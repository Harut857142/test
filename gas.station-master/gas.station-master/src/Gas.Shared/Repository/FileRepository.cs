using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Gas.Shared.DbProvider;
using Gas.Shared.Models.Core;
using Gas.Shared.Models.Core.Paging;
using Gas.Shared.Repository.Shared;

namespace Gas.Shared.Repository.File
{
    public class FileRepository
    {
        private readonly Context _context;

        public FileRepository(Context context)
        {
            _context = context;
        }
        
        public Models.Core.File Get(int id)
        {
            return _context.Files.Where(r => (r.ID == id && r.Status)).Select(r => r).FirstOrDefault();
        }

        public PagedResult<Models.Core.File> GetList(FileFilter filter)
        {
            return _context.Files.Where(r => (r.Status))
                .Select(customerInformation => customerInformation).AsQueryable()
                .GetPaged(filter.CurrentPage, filter.PageSize);
        }

        public Models.Core.File Add(Models.Core.File model)
        {
            model.CreationDate = DateTime.Now;
            model.Status = true;
            _context.Files.Add(model);
            Save();
            return model;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public bool Update(Models.Core.File model)
        {

            var item = _context.Files.Where(
                r => r.Status
                     && r.ID == model.ID && r.Status).FirstOrDefault();
            item.Path = model.Path ?? item.Path;
            _context.Files.Update(item);
            _context.SaveChanges();
            return true;
        }

        public void Delete(int id)
        {
            var item = _context.Files.Where(
                r => r.Status
                     && r.ID == id).FirstOrDefault();
            item.Status = false;
            _context.Files.Update(item);
            _context.SaveChanges();
        }
    }
}