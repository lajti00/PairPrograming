using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LajtiCodeKatas
{
    public class LajtiBinaryChop
    {

        public int[] Find(int[] orderedArray, int valueToFind)
        {
            var indexesList = FindValuesInArray(orderedArray, valueToFind);

            var indexes = indexesList.ToArray();
            if (indexes.Length == 0)
            {
                return new[]{-1};
            }

            return indexes;
        }

        private static List<int> FindValuesInArray(int[] orderedArray, int valueToFind)
        {
            var indexesList = new List<int>();
            for (var i = 0; i < orderedArray.Length; i++)
            {
                if (orderedArray[i] == valueToFind)
                {
                    indexesList.Add(i);
                }
            }
            return indexesList;
        }
    }
}
