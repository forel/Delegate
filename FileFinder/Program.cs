using System;

namespace FileFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Здесь указывать путь к директории для поиска в ней файлов
            string path = @"C:\Temp";
            
            Finder finder = new Finder();
            finder.FileFound += FinderEventHandler;
            finder.ShowFileName(finder.GetFiles(path));
        }

        public static void FinderEventHandler(object sender, FileArgs fileArgs)
        {
            Console.WriteLine($"Найден файл: {fileArgs.fileName}");
            Console.WriteLine($"Нажмите <Esc> чтобы выйти или любую другую клавишу чтобы продолжить ...");
            ConsoleKeyInfo cki = Console.ReadKey();
            if (cki.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
    }
}
