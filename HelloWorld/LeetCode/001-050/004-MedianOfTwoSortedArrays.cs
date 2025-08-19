public class _004_MedianOfTwoSortedArrays
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        // Merge the two sorted arrays
        List<int> merged = new List<int>();
        int i = 0, j = 0;
        while (i < nums1.
        Length && j < nums2.Length)
        {
            if (nums1[i] < nums2[j])
            {
                merged.Add(nums1[i++]);
            }
            else
            {
                merged.Add(nums2[j++]);
            }
        }

        // Add remaining elements from nums1 or nums2
        while (i < nums1.Length)
        {
            merged.Add(nums1[i++]);
        }
        while (j < nums2.Length)
        {
            merged.Add(nums2[j++]);
        }

        // Find the median
        int length = merged.Count;

        if (length % 2 == 1)
        {
            return merged[length / 2];

        }
        // Odd length, return the middle element
        else
        {
            return (merged[length / 2 - 1] + merged[length / 2]) / 2.0;
        }
        // Even length, return the average of the two middle elements
    }
}