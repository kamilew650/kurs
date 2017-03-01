using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSkonsola
{
    class KursACs
    {
        int[] tab = new int [5];
      
        public void wczytaj()
        {
            for(int i = 0; i < 5; i++)
            {
                this.tab[i] = int.Parse(Console.ReadLine());
            }
        }

        public void wypisz()
        {
            for(int i = 0; i < 5; i++)
            {
                Console.Write(this.tab[i]+"\n");
            }
        }

    }
}
