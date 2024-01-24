public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1)
        {
            return s;
        }
        var output = new StringBuilder(s.Length);
        for(int i = 0 ; i < numRows; i++){
            int step = (numRows-i-1)*2;
            int currentIdx = i;
            while(currentIdx < s.Length){
                if(step>0){
                    output.Append(s[currentIdx]);
                    currentIdx += step;
                }
                
                if(currentIdx < s.Length && i>0){
                    output.Append(s[currentIdx]);
                    currentIdx += i*2;
                }
            }
        }
        return output.ToString();
    }
}