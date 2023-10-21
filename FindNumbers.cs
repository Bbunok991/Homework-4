using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    internal class FindNumbers
    {
        public List<int> FindThreeNumbers(int[] arr, int target)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < arr.Length - 2; i++)
            {
                HashSet<int> set = new HashSet<int>();

                int currentSum = target - arr[i];

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (set.Contains(arr[j]))
                    {
                        result.Add(arr[i]);
                        result.Add(arr[j]);
                        result.Add(currentSum - arr[j]);
                        return result;
                    }

                    set.Add(currentSum - arr[j]);
                }
            }

            return result;
        }
    }
}

