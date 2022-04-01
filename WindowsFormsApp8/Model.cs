using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    internal class Model
    {
        int[,] array = new int[5, 7];
        private void InEntry(int i, int j)
        {
            array[i, j] = 1;
        }

        delegate void Delegate(int i, double j);

    }
    
}
