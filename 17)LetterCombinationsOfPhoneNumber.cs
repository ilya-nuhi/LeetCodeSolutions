public class Solution {
    public IList<string> LetterCombinations(string digits) {
        string[] numberLetters = {"abc","def","ghi","jkl","mno","pqrs","tuv","wxyz"};
        IList<string> answer = new List<string>();
        List<StringBuilder> container = new List<StringBuilder>();

        if(digits.Length > 0){
            foreach(var letter in numberLetters[digits[0] - '2']){
                container.Add(new StringBuilder().Append(letter));
            }
        }

        for(int i = 1; i < digits.Length; i++){
            int digitIndex = digits[i] - '2'; // Convert char to int

            int count = container.Count;
            for(int j = 0; j < count; j++)
            {
                var tempWord = container[j];
                for(int k = 1; k < numberLetters[digitIndex].Length; k++)
                {
                    StringBuilder str = new StringBuilder(tempWord.ToString()); // Make a copy
                    str.Append(numberLetters[digitIndex][k]);
                    container.Add(str);
                }
                container[j].Append(numberLetters[digitIndex][0]); // Append the first character for the original string
            }
        }

        foreach(var elem in container){
            answer.Add(elem.ToString());
        }
        return answer;
    }
}
