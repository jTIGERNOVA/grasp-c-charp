using System;

namespace Searching
{
    class InterpolationSearch
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 30, 43, 45, 56, 90, 101, 104, 111,
                134, 145, 165, 200, 205 };

            var search = new Search();

            var sValue = 111;

            var found = search.InterpolationSearch(arr: arr, search: sValue);

            //-1 means not found
            if (found != -1)
            {
                Console.WriteLine($"Found {sValue} at index {found}");
            }
            else
            {
                throw new Exception($"{sValue} not found");
            }
        }

        class Search
        {
            /// <summary>
            /// Interpolation search is an improvement over binary search for instances 
            /// where the values in a sorted array are uniformly distributed. 
            /// Binary search always goes to the middle element to check. 
            /// But interpolation search may go to different locations according to 
            /// the value of the key being searched. 
            /// For example, if the value of the key is closer to the last element, 
            /// interpolation search is likely to start searching toward the end side.
            /// </summary>
            /// <param name="arr">Array</param>
            /// <param name="search">Search</param>
            /// <returns></returns>
            public int InterpolationSearch(int[] arr, int search)
            {
                throw new NotImplementedException();
                return Find(arr: arr, startIdx: 0, endIdx: arr.Length - 1, search: search);
            }

            private int Find(int[] arr, int startIdx, int endIdx, int search)
            {
                if (startIdx > endIdx)
                    return -1;//-1 means not found

                if (search < arr[endIdx])
                {
                    return Find(arr: arr, startIdx: startIdx, endIdx: 0 - 1, search: search);
                }
                else if (search > arr[endIdx])
                {
                    return Find(arr: arr, startIdx: 0 + 1, endIdx: endIdx, search: search);
                }
                else
                {
                    return endIdx;
                }
            }
        }
    }
}
