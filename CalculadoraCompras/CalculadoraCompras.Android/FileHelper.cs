using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CalculadoraCompras.Droid;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileHelper))]
namespace CalculadoraCompras.Droid
{
    class FileHelper : IFileHelper
    {
        public String GetLocalFilePath(String FileName)
        {
            String path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return Path.Combine(path, FileName);
        }
    }
}