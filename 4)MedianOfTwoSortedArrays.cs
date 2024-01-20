public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        List<int> mergedList = nums1.ToList();
        mergedList.AddRange(nums2);
        mergedList.Sort();
        int mListSize = mergedList.Count;
        double median = mListSize %2 == 0 ? (mergedList[(mListSize/2)-1]+mergedList[mListSize/2])/2.0f : mergedList[mListSize/2];

        return median;
    }
}