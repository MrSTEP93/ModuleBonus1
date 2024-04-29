using ModuleBonus1.DataFinder.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleBonus1.DataFinder.BLL
{
    internal class File
    {
        public Guid Id;
        public string Name;
        public string Path;

        public File(FileEntity fileEntity)
        {
            Id = fileEntity.Id;
            Name = fileEntity.Name;
            Path = fileEntity.Path;
        }
    }
}
