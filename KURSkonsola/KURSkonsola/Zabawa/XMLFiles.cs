using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace KURSkonsola.Zabawa
{
    class XMLFiles
    { 

        public void LoadXMLFile(string path)
        {
            XmlDocument doc = new XmlDocument();

            try
            {
                doc.Load(@path);
                Console.Write("Udalo sie :)");
            }
            catch (XmlException e)
            {

                Console.Write(e.Message);
            }
            Console.Read();

        }

    }
}
