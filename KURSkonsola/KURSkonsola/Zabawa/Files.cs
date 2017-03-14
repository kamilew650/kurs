using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KURSkonsola.Zabawa
{
    class Files
    {
        
        public void CreateDirectory(string path)
        {
            if(!Directory.Exists(@path))
            {
                Directory.CreateDirectory(@path);
            }
        }
       
        public void WriteFile(string path, string date)
        {
            if(!File.Exists(@path))
            {
                StreamWriter sw = File.CreateText(@path);
                sw.WriteLine(date);
                sw.Close();

            }else
            {
                StreamWriter sw = new StreamWriter(@path);
                sw.WriteLine(date);
                sw.Close();
            }
        }

    }
}
