using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraCompras
{
    public interface IFileHelper
    {
        String GetLocalFilePath(String FileName);
    }
}
