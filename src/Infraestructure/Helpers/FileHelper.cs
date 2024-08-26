using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraestructureLayer.Helpers
{
    public static class FileHelper
    {
        private static readonly string FOLDER = ".\\Data";

        public static string GetFilePath(string fileName)
        {
            if (!Directory.Exists(FOLDER))
            {
                Directory.CreateDirectory(FOLDER);
            }
            return $"{FOLDER}\\{fileName}.bin";
        }

    }
}
