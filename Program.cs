using System;
using System.IO;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EUP Pack Converter | By Wilson#0159";

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("   ____  _   _ _  __     __     _____  _    _ _   _       ____  _   _  _____ ______ ");
            Console.WriteLine(@"  / __ \| \ | | | \ \   / /    |  __ \| |  | | \ | |     / __ \| \ | |/ ____|  ____|");
            Console.WriteLine(@" | |  | |  \| | |  \ \_/ /     | |__) | |  | |  \| |    | |  | |  \| | |    | |__   ");
            Console.WriteLine(@" | |  | | . ` | |   \   /      |  _  /| |  | | . ` |    | |  | | . ` | |    |  __|  ");
            Console.WriteLine(@" | |__| | |\  | |____| |       | | \ \| |__| | |\  |    | |__| | |\  | |____| |____ ");
            Console.WriteLine(@"  \____/|_| \_|______|_|       |_|  \_\\____/|_| \_|     \____/|_| \_|\_____|______|");

            Console.WriteLine("\n  _____  ______ _____       ______ _    _ _____       _____        _____ _  __");
            Console.WriteLine(@" |  __ \|  ____|  __ \     |  ____| |  | |  __ \     |  __ \ /\   / ____| |/ /");
            Console.WriteLine(@" | |__) | |__  | |__) |    | |__  | |  | | |__) |    | |__) /  \ | |    | ' / ");
            Console.WriteLine(@" |  ___/|  __| |  _  /     |  __| | |  | |  ___/     |  ___/ /\ \| |    |  <  ");
            Console.WriteLine(@" | |    | |____| | \ \     | |____| |__| | |         | |  / ____ \ |____| . \ ");
            Console.WriteLine(@" |_|    |______|_|  \_\    |______|\____/|_|         |_| /_/    \_\_____|_|\_\");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write("\n\nPlease enter the file path ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("containing");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" the ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("eup_componentpeds.rpf");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" and ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("eup_componentpeds_p.rpf");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" folders.");

            Console.Write("\n\nPath ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("(e.g E:\\FiveM\\EUP\\EUPMegaPack)");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(": ");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string rootPath = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            string[] files = Directory.GetFiles(rootPath, "*", SearchOption.AllDirectories);

            foreach (var subFolder in Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories))
            {
                string subFolderName = Path.GetFileName(subFolder);
                foreach (var filePath in Directory.GetFiles(subFolder))
                {
                    string fileName = Path.GetFileName(filePath);
                    string fileFolder = Path.GetDirectoryName(filePath);
                    string newPath = Path.Combine(fileFolder, $"{subFolderName}^{fileName}");
                    File.Move(filePath, newPath);
                }
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Renaming Successful!");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nPress ENTER to exit program.");
            Console.ReadLine();
        }
    }
}