using System.Runtime.CompilerServices;

namespace Codility_Flags
{
    public class Solution
    {
        public const int RANGE_LOWEST_VALUE = 1;
        public const int RANGE_HIGHEST_VALUE = 400000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(int[] A)
        {
            int N = A.Length;
            if (N >= RANGE_LOWEST_VALUE && N <= RANGE_HIGHEST_VALUE) 
            {
                if (N <= 2)
                    return Math.Min(N, 1); // If there are less than 3 elements, it's impossible to set more than 1 flag.

                // Find all the peaks in the array.
                List<int> peaks = new List<int>();
                for (int i = 1; i < N - 1; i++)
                {
                    if (A[i] > A[i - 1] && A[i] > A[i + 1])
                        peaks.Add(i);
                }

                int numPeaks = peaks.Count;
                if (numPeaks <= 1)
                    return numPeaks; // If there are 0 or 1 peaks, set flags on all of them.

                // Use binary search to find the maximum number of flags.
                int maxFlags = 0;
                int left = 1;
                int right = numPeaks;
                while (left <= right)
                {
                    int flags = (left + right) / 2;
                    if (canSetFlags(peaks, flags))
                    {
                        maxFlags = flags;
                        left = flags + 1;
                    }
                    else
                        right = flags - 1;
                }

                return maxFlags;
            }

            return -1;
        }

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        // Helper function to check if it's possible to set 'flags' flags with the given peak indices.
        private bool canSetFlags(List<int> peaks, int flags)
        {
            int pos = peaks[0];
            int count = 1;
            for (int i = 1; i < peaks.Count; i++)
            {
                if (peaks[i] - pos >= flags)
                {
                    pos = peaks[i];
                    count++;
                    if (count == flags)
                        return true;
                }
            }

            return false;
        }
    }
}
