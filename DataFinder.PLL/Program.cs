using System;
using System.Linq;
using System.Threading.Tasks.Dataflow;
using ModuleBonus1.DataFinder.BLL;

namespace ModuleBonus1.DataFinder.PLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var fileService = new FileService();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Data Finder v.1.0");
                Console.WriteLine("Отобразить все файлы - нажмите 1");
                Console.WriteLine("Выполнить поиск файла по имени - нажмите 2");
                string inputValue = Console.ReadLine();

                if (inputValue == "1")
                    fileService.GetAllFiles().ToList().ForEach(file =>
                    {
                        ShowFileInfo(file);
                    });
                if (inputValue == "2")
                {
                    Console.Write("Type name of searching file: ");
                    string fileName = Console.ReadLine();

                    try
                    {
                        var file = fileService.GetFileByName(fileName);
                        ShowFileInfo(file);
                    }
                    catch (BusinessRuleException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        private static void ShowFileInfo(File file)
        {
            Console.WriteLine($"ID: {file.Id}; Filename: {file.Name}; FilePath: {file.Path};");
        }
    }
}
