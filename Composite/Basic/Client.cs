using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite.Basic
{
    class Client
    {
        public void BasicComposite()
        {
            Console.WriteLine("Composite Pattern Basic!!!");

            Directory root = new Directory("Root");
            Directory cdrive = new Directory("C:");
            Directory ddrive = new Directory("D:");
            root.Add(cdrive);
            root.Add(ddrive);

            File cfile1 = new File("cfile1", 100);
            File cfile2 = new File("cfile2", 50);
            File cfile3 = new File("cfile3", 10);
            cdrive.Add(cfile1);
            cdrive.Add(cfile2);
            cdrive.Add(cfile3);
            File dfile1 = new File("dfile1", 110);
            File dfile2 = new File("dfile2", 70);
            File dfile3 = new File("dfile3", 150);
            ddrive.Add(dfile1);
            ddrive.Add(dfile2);
            ddrive.Add(dfile3);

            Directory cdriveFolder1 = new Directory("cdriveFolder1");
            Directory cdriveFolder2 = new Directory("cdriveFolder2");
            cdrive.Add(cdriveFolder1);
            cdrive.Add(cdriveFolder2);

            Directory ddriveFolder1 = new Directory("ddriveFolder1");
            Directory ddriveFolder2 = new Directory("ddriveFolder2");
            ddrive.Add(ddriveFolder1);
            ddrive.Add(ddriveFolder2);

            File cdriveFolder1file1 = new File("cdriveFolder1file1", 20);
            File cdriveFolder1file2 = new File("cdriveFolder1file2", 30);
            cdriveFolder1.Add(cdriveFolder1file1);
            cdriveFolder1.Add(cdriveFolder1file2);

            File cdriveFolder2file1 = new File("cdriveFolder2file1", 10);
            File cdriveFolder2file2 = new File("cdriveFolder2file2", 11);
            cdriveFolder2.Add(cdriveFolder2file1);
            cdriveFolder2.Add(cdriveFolder2file2);

            File ddriveFolder1file1 = new File("ddriveFolder1file1", 44);
            File ddriveFolder1file2 = new File("ddriveFolder1file2", 34);
            ddriveFolder1.Add(ddriveFolder1file1);
            ddriveFolder1.Add(ddriveFolder1file2);


            File ddriveFolder2file1 = new File("ddriveFolder2file1", 15);
            File ddriveFolder2file2 = new File("ddriveFolder2file2", 19);

            ddriveFolder2.Add(ddriveFolder2file1);
            ddriveFolder2.Add(ddriveFolder2file2);

            PrintDirectoryTreeSize(ddriveFolder2);
            Console.ReadLine();
        }
        private static int OrderOnType(FileSystem item)
        {
            if (item is Directory)
                return 0;
            if (item is File)
                return 1;
            return 2;
        }
        private int PrintDirectoryTreeSize(Directory dir)
        {
            int totalsize = 0;
            foreach (var item in dir.filesAndFolders.OrderByDescending(OrderOnType))
            {
                if (item is Directory)
                {
                    totalsize = totalsize + PrintDirectoryTreeSize((Directory)item);
                }
                else
                {
                    Console.WriteLine($"{item.Name}, {item.GetSize()}");
                    totalsize = totalsize + item.GetSize();
                }
            }
            Console.WriteLine($"{dir.Name}, {totalsize}");
            return totalsize;
        }
    }
}
