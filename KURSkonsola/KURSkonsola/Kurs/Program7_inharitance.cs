using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSkonsola.Kurs
{
    class Program7_inharitance
    {
        //public static void Main(string[] args)
        //{

        //    var text = new Text();
        //    text.Width = 100;
        //    text.Copy();
        //}

    }

    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine("We added a link to " + url);
        }

    }


    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Copy");
        }

        public void Duplicate()
        {
            Console.WriteLine("Copy");
        }
    }
}
