using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using CalculadoraCompras.iOS;
using System.IO;

[assembly: Dependency(typeof(FileHelper))]
namespace CalculadoraCompras.iOS
{
    class FileHelper : IFileHelper
    {
        public String GetLocalFilePath(String FileName)
        {
            String docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            String libFolder = Path.Combine(docFolder, "..", "Library", "Database");

            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }

            return Path.Combine(libFolder, FileName);
        }
    }
}