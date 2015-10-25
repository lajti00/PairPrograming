using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LajtiCodeKatas
{
    public class LajtiBinaryChop
    {
        public void RandomArrayGen(ref int[] randA, int min, int max)
        {
            Random rnd = new Random();
            randA[0] = min;//rnd.Next(min, max);
            for (int i = 1; i < randA.Length; i++)
            {
                if (randA[i - 1] < max)
                {
                    randA[i] = rnd.Next(randA[i - 1] + 1, max);
                }
                else
                {
                    randA[i] = max;
                }
            }
            
        } 
        public int[] find(int[] array, int value)
        {
            List<int> indexesList = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    indexesList.Add(i);
                }
            }
            int[] indexes = indexesList.ToArray();
            if (indexes.Length == 0)
            {
                Array.Resize(ref indexes, 1);
                indexes[0] = -1;
            }

            return indexes;
        }
    }
}
