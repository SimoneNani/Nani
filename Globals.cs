using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nani
{
    class Globals
    {
        public static int[,] val = new int[,] { { 1, 0, 0, 0 },            //dichiarazione matrice valori binari
                                                 { 1, 0, 1, 0 },
                                                 { 1, 0, 1, 1 },
                                                 { 1, 1, 0, 0 },
                                                };

        public static int[] visualizza = new int[4];
        public static int conversione = 0;                                  //valore indice 
        public static int decimale = 0;
    }
}
