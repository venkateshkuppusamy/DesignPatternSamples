namespace Composite
{
    abstract class  FileSystem{
        public string Name { get; set; }
        public int Size { get; set; }
        public FileSystem(string name)
        {
            this.Name = name;
        }

        public FileSystem(string name,int size)
        {
            this.Name = name;
            this.Size = size;
        }
        public abstract int GetSize();
        
    }
}
