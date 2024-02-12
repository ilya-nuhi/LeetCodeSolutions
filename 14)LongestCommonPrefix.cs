public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        StringBuilder sb = new StringBuilder("");
        int minLength = strs.Min(s => s.Length);
        for(int i = 0; i < minLength ; i++){
            bool sameLetter = true;
            for(int j = 1; j < strs.Length ; j++){
                sameLetter = true;
                if(strs[j][i]!=strs[0][i]){
                    sameLetter = false;
                    break;
                }
            }
            if(sameLetter){
                sb.Append(strs[0][i]);
            }
            else{
                return sb.ToString();
            }
        }
        return sb.ToString();
        
    }
}