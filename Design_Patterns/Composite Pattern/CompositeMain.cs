using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Composite_Pattern
{
    public class CompositeMain
    {
        public static void Main(string[] args)
        {
            AFileSystemItem MyBook = new FileItem("MyBook.txt", 12000);
            AFileSystemItem MyVideo = new FileItem("MyVideo.mp4", 1000000);
            AFileSystemItem MyMusic = new FileItem("MyMusic.mp3", 20000);
            AFileSystemItem MyResume = new FileItem("MyResume.pdf", 18000);
            AFileSystemItem MySoftware = new FileItem("MySoftware.exe", 250000);
            AFileSystemItem MyDocument = new FileItem("MyDocument.doc", 87000000);

            Directory RootDirectory = new Directory("RootDirectory");

            
            Directory Folder1 = new Directory("Folder1");
            Directory Folder2 = new Directory("Folder2");
           
            RootDirectory.AddComponent(Folder1);
            RootDirectory.AddComponent(Folder1);
            
            Folder1.AddComponent(MyBook);
            Folder1.AddComponent(MyVideo);
            
            Directory SubFolder1 = new Directory("Sub Folder1");

            SubFolder1.AddComponent(MyMusic);
            SubFolder1.AddComponent(MyResume);
            Folder1.AddComponent(SubFolder1);


            Folder2.AddComponent(MySoftware);
            Folder2.AddComponent(MyDocument);
            Console.WriteLine("Composite Objects:");
            Console.WriteLine($"Total size of (RootDirectory): {RootDirectory.GetSize()} KB");
            Console.WriteLine($"Total size of (Folder 1): {Folder1.GetSize()}KB");
            Console.WriteLine($"Total size of (Folder 2): {Folder2.GetSize()}KB");
            Console.WriteLine($"Total size of (SubFolder 1): {SubFolder1.GetSize()}KB");
            Console.WriteLine("\nLeaf Objects:");
            Console.WriteLine($"Total size of MyVideo File: {MyVideo.GetSize()}KB");
            Console.WriteLine($"Total size of MyResume File: {MyResume.GetSize()}KB");
            Console.WriteLine($"Total size of MyBook File: {MyBook.GetSize()}KB");
            Console.WriteLine($"Total size of MyDocument File: {MyDocument.GetSize()}KB");
            Console.Read();
        }
    }
}
