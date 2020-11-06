using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nani
{
    class Methods
    {
        public static bool Verifica(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                if (Globals.visualizza[i] == 1)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
