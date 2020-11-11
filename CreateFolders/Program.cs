using System;
using System.IO;

namespace CreateFolders
{
    class Program
    {
        public static void CreateFolder(string path)
        {
            Directory.CreateDirectory(path);
        }

        public static void CreateFolderArray(string[] paths)
        {
            foreach (string folder in paths)
            {
                CreateFolder(folder);
            }
        }
        static void Main(string[] args)
        {
            CreateFolder("One Folder Create");
            string[] folders = {"F1","F2","F3" };
            CreateFolderArray(folders);
        }
    }
}
