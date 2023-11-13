using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FileOperations
{
    public class File
    {

        public static void Main(string[] args)
        {  
            List<string> systemConfig= new List<string>();
            systemConfig = ReadFile(systemConfig, "C:\\Windows", "\\system.ini");
            PrintFile(systemConfig);
            Console.ReadKey();
        }

        private static void PrintFile(List<string> systemConfig)
        {
            foreach (var item in systemConfig)
            {
                Console.WriteLine(item);
            }
        }

        public static List<string> ReadFile(List<string> systemConfig, string directory, string filePath)
        {

            StreamReader reader = new StreamReader(directory + filePath);
            try
            {
                do
                {
                    systemConfig.Add(reader.ReadLine());
                }
                while (reader.Peek() != -1);
            }
            catch (FileNotFoundException e)
            {
                throw new FileNotFoundException(e.Message);
            }
            catch
            {
                systemConfig.Add(("File is empty"));
            }
            finally
            {
                reader.Close();
            }
            return systemConfig;
        }
    }
}
