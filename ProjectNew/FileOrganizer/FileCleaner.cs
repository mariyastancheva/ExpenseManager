using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNew.Models
{
    static class FileCleaner
    {
        private static string filePath = Path.GetFullPath("DataBase.txt");

        public static void Clear()
        {
            File.Delete(filePath);
            File.WriteAllText(filePath, String.Empty);
        }
    }
}
