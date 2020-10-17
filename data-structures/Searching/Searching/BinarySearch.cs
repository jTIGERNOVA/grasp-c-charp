using System;

namespace Searching
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 30, 43, 45, 56, 90, 101, 104, 111,
                134, 145, 165, 200, 205 };

            var search = new Search();

            var sValue = 111;

            var found = search.BinarySearch(arr: arr, search: sValue);

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
            public int BinarySearch(int[] arr, int search)
            {
                return Find(arr: arr, startIdx: 0, endIdx: arr.Length - 1, search: search);
            }

            private int Find(int[] arr, int startIdx, int endIdx, int search)
            {
                if (startIdx > endIdx)
                    return -1;//-1 means not found

                var medIdx = (int)Math.Floor((startIdx + endIdx) / 2D);

                if (search < arr[medIdx])
                {
                    return Find(arr: arr, startIdx: startIdx, endIdx: medIdx - 1, search: search);
                }
                else if (search > arr[medIdx])
                {
                    return Find(arr: arr, startIdx: medIdx + 1, endIdx: endIdx, search: search);
                }
                else
                {
                    return medIdx;
                }
            }
        }
    }
}
