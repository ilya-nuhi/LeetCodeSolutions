public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        IList<string> myList = new List<string>();
        GenerateParanthesisHelper(myList, "(", n-1, 1);
        return myList;
    }

    public void GenerateParanthesisHelper(IList<string> mylist, string currentStr, int n, int difference){
        if(n==0){
            for(int i= 0; i < difference; i++){
                currentStr+=")";
            }
            mylist.Add(currentStr);
            return;
        }
        else {
            if(difference>0){
                GenerateParanthesisHelper(mylist, currentStr + ")", n, difference-1);
            }
            GenerateParanthesisHelper(mylist, currentStr + "(", n-1, difference+1);
        }
    }
}