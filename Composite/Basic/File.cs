namespace Composite
{
    class File : FileSystem
    {
        public File(string name, int size) : base(name, size)
        {
        }

        

        public override int GetSize()
        {
            //return $"FileName: {this.Name}, Size: {this.Size}";
            return this.Size;
        }
    }
}
