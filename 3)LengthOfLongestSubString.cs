public class Solution {
    public int LengthOfLongestSubstring(string s) {
        char lastChar = s[0];
        int longestSubStringLength = 1;
        string currentSubString = "";
        for(int i = 1; i < s.Length; i++){
            if(!currentSubString.Contains(s[i]))
                currentSubString += s[i];
            else{
                if(currentSubString.Length > longestSubStringLength){
                    longestSubStringLength = currentSubString.Length;
                }
                currentSubString = s[i].ToString();
            }
        }

        return longestSubStringLength;
    }
}