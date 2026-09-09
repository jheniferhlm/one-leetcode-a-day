public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] result = new int[nums1.Length + nums2.Length];
        int i = 0, j = 0, k = 0;

        while (i < nums1.Length && j < nums2.Length)
        {
            if (nums1[i] <= nums2[j])
                result[k++] = nums1[i++];
            else
                result[k++] = nums2[j++];
        }

        while (i < nums1.Length)
            result[k++] = nums1[i++];

        while (j < nums2.Length)
            result[k++] = nums2[j++];

        int size = result.Length;
        int median = size / 2;

        if (size % 2 != 0)
            return result[median];
        else
            return (result[median - 1] + result[median]) / 2.0;
    }
}