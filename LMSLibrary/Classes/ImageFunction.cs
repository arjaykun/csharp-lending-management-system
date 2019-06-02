using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSLibrary.Classes
{
    public class ImageFunction
    {
        public void CopyImage(string oldPath, string fileName)
        {
            string newDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string newPath = newDirectory + fileName;
            File.Copy(oldPath, newPath);
        }
        public  void DeleteImage(string fileName)
        {
            string[] tokens = fileName.Split('\\', '/');
            if (File.Exists(fileName))
            {
                if (tokens[tokens.Length - 1] != "default.png")
                {
                    string directory = AppDomain.CurrentDomain.BaseDirectory;
                    File.Delete(directory + fileName);
                }
            }
        }

        public string GetImageName(string folder)
        {
            string directory = AppDomain.CurrentDomain.BaseDirectory;
            string newName = $@"{folder}\{DateTime.Now.Year}{DateTime.Now.Month}{DateTime.Now.Day}{Guid.NewGuid()}.png";
            return directory + newName;
        }

        public string RenameImage(string filename)
        {
            string[] tokens = filename.Split('.');
            string extension = tokens[tokens.Length - 1];
            string newName = $"{DateTime.Now.Year}{DateTime.Now.Month}{DateTime.Now.Day}{Guid.NewGuid()}";
            return $"{newName}.{extension}";
        }
    }
}
