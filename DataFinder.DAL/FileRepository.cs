using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleBonus1.DataFinder.DAL
{
    public class FileRepository
    {
        public IEnumerable<FileEntity> Files { get; }

        public FileRepository()
        {
            Files = new List<FileEntity>()
            {
                new FileEntity(Guid.NewGuid(), "покупки январь.xlsx", "C:\\test\\покупки январь.xlsx"),
                new FileEntity(Guid.NewGuid(), "data_max.zip", "C:\\test\\data_max.zip"),
                new FileEntity(Guid.NewGuid(), "startup.txt", "C:\\test\\startup.txt"),
                new FileEntity(Guid.NewGuid(), "Перевод 5000 УАЗ.PNG", "C:\\test\\Перевод 5000 УАЗ.PNG")
            };
        }

        public IEnumerable<FileEntity> GetFilesByDirectrory()
        {
            return this.Files;
        }

        public FileEntity GetFileByName(string fileName)
        {
            return Files.FirstOrDefault(f => f.Name == fileName);
        }
    }
}
