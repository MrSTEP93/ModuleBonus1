using ModuleBonus1.DataFinder.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ModuleBonus1.DataFinder.BLL
{
    internal class FileService
    {
        public FileRepository fileRepository;

        public FileService()
        {
            fileRepository = new FileRepository();
        }

        public IEnumerable<File> GetAllFiles()
        {
            return fileRepository.GetFilesByDirectrory().ToList()
                .Select(fileEntity => new File(fileEntity));
        }

        public File GetFileByName (string fileName)
        {
            if (String.IsNullOrEmpty(fileName))
                throw new BusinessRuleException("Incorrect value!");
            
            var fileEntity = fileRepository.GetFileByName(fileName);
            if (fileEntity == null)
                throw new BusinessRuleException("File not found");
            
            return new File(fileEntity);
        }
    }
}
