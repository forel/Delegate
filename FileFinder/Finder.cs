using System;
using System.IO;

namespace FileFinder
{
    public class Finder
    {
        public string[] GetFiles(string directoryPath)
        {
            string[] files = null;

            try
            {
                files = Directory.GetFiles($"{directoryPath}", "*.*", SearchOption.AllDirectories);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return files;
        }

        public void ShowFileName(string[] files)
        {
            var fileArgs = new FileArgs();

            if (files != null)
            {
                foreach (var file in files)
                {
                    fileArgs.fileName = file;

                    OnFileFound(fileArgs);
                }
            }
            else
            {
                Console.WriteLine("Файлы не найдены");
            }
            
        }

        public event EventHandler<FileArgs> FileFound;
        public void OnFileFound(FileArgs fileArgs)
        {
            FileFound?.Invoke(this, fileArgs);
        }

    }
}
