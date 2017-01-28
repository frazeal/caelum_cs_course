using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaLibrary
{
    public static class GeradorDevedores
    {
        public static ICollection<string> GeraListaT()
        {
            //List<string> nomes = new List<string>();
            HashSet<string> nomes = new HashSet<string>();

            for (int i = 0; i < 300000; i++)
            {
                nomes.Add("Devedor " + i);
            }
            return nomes;
        }

        //public static ICollection<T> GeraListaKV()
        //{
        //    //List<string> nomes = new List<string>();
        //    HashSet<string> nomes = new HashSet<string>();

        //    for (int i = 0; i < 300000; i++)
        //    {
        //        nomes.Add("Devedor " + i);
        //    }
        //    return nomes;
        //}
    }
}
