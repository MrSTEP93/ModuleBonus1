using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleBonus1.DataFinder.DAL
{
    internal class FileEntity
    {
        public Guid Id;
        public string Name;
        public string Path;

        public FileEntity(Guid id, string name, string path)
        {
            this.Id = id;
            this.Name = name;
            this.Path = path;
        }
    }
}
