using Composite.Classes;
using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Component fileSystem = new Directory("File system");
            // new disk
            Component diskC = new Directory("Disk c");
            // new file
            Component pngFile = new File("12345.png");
            Component docxFile = new File("Document.docx");
            // new files on disk C
            diskC.Add(pngFile);
            diskC.Add(docxFile);
            // add new disk C on file system
            fileSystem.Add(diskC);
            // print new data
            fileSystem.Print();
            Console.WriteLine();
            // remove file
            diskC.Remove(pngFile);
            // create new folder
            Component docsFolder = new Directory("My documents");
            // add new files
            Component txtFile = new File("readme.txt");
            Component csFile = new File("Program.cs");
            docsFolder.Add(txtFile);
            docsFolder.Add(csFile);
            diskC.Add(docsFolder);

            fileSystem.Print();

            Console.Read();
        }
    }
}
