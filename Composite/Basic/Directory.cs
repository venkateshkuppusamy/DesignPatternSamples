using System.Collections.Generic;

namespace Composite
{
    class Directory : FileSystem {
        public Directory(string name) : base(name)
        {

        }

        public List<FileSystem> filesAndFolders { get; set; } = new List<FileSystem>();

        public void Add(FileSystem fs)
        {
            this.filesAndFolders.Add(fs);
        }

        public override int GetSize()
        {
            int totalsize = 0;
           
            foreach (var item in filesAndFolders)
            {
                totalsize = totalsize + item.GetSize();
            }
            this.Size = totalsize;
            return this.Size;
        }
    }
}
