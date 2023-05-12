using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_CS
{
    internal class Program
    {
        static void fileExists()
        {            
            string file_path = "";            
            int counterStopEnter = 0;
            Console.WriteLine("Checking for the existence of a file in a given path.\n");
            do
            {
                Console.WriteLine("Enter the file path to continue, or 'end_input' to end.");
                file_path = Console.ReadLine();
                Console.WriteLine(file_path);
                if (file_path == "end_input")
                {
                    counterStopEnter++;
                }
                else
                {
                    bool fileExist = File.Exists(file_path);
                    if (fileExist)
                    {
                        Console.WriteLine("File exists!");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("File path is invalid. File does not exist.");
                        Console.ReadKey();
                    }
                }
                Console.Clear();
            } while (counterStopEnter == 0);
        }
        static void fileExistsCmd(string path)
        {
            string file_path = path;                  
            bool fileExist = File.Exists(file_path);
            if (fileExist)
            {
                Console.WriteLine("File exists!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("File path is invalid. File does not exist.");
                Console.ReadKey();
            }               
            Console.Clear();            
        }
        static void Main(string[] args)
        {
            //002 Написать программу, проверяющую наличие файла по заданному пути.Аргументы
            //сообщаются приложению при запуске, в случае ввода некорректных аргументов(содержание,
            //количество) и при запуске без аргументов должна выводиться справка по использованию
            //программы.
            //           

            string path = "";
            try
            {
                path = args[0];
                fileExistsCmd(path);
            }
            catch
            {
                Console.WriteLine("There are no options.\r\n");
                path = Environment.CurrentDirectory;
            }   
        }
    }
}
