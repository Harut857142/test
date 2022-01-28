using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Gas.Shared.Models.Core;
using Gas.Shared.Repository.File;
using File = System.IO.File;

namespace Gas.Shared.Services
{
    public class FileDownloadResult
    {
        public FileStream fileStream { get; set; }
        public string Type { get; set; }
    }
    public class FileService
    {
        private readonly FileServiceOptions _options;
        private readonly FileRepository _fileRepository;

        public FileService(FileServiceOptions options,
            FileRepository fileRepository)
        {
            _options = options;
            _fileRepository = fileRepository;
        }

        public async Task<int> Upload(IFormFile file)
        {
            var fileName = Path.GetRandomFileName();
                var filePath = Path.Combine(_options.BasePath, fileName
                    );

                using (var stream = System.IO.File.Create(filePath))
                {
                    await file.CopyToAsync(stream);
                }

                var model = _fileRepository.Add(new Gas.Shared.Models.Core.File()
                {
                    Path = fileName,
                    FileName = file.ContentType
                });
                return await Task.Run(() => model.ID);
        }

        public async Task<FileDownloadResult> Download(int id)
        {
            var model = _fileRepository.Get(id);
            if (model == null)
                return null;

            var filePath = Path.Combine(_options.BasePath, model.Path
            );

            if (!File.Exists(filePath))
                return null;

            var image = System.IO.File.OpenRead(filePath);
            return new FileDownloadResult()
            {
                fileStream = image,
                Type = model.FileName
            };
        }
    }
}