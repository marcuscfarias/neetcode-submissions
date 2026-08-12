public class Solution {
    public bool IsValid(string s) {

        if(string.IsNullOrWhiteSpace(s)){
            return false;
        }

        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> bracketPairs = new Dictionary<char, char>(){
            {'}','{'},
            {')','('},
            {']','['}
        };

        for(int i = 0; i < s.Length; i++){

            char sValue = s[i];

            if(bracketPairs.ContainsKey(sValue)){

                if(stack.Count > 0 && stack.Peek() == bracketPairs[sValue]){
                    stack.Pop();
                }else{
                    return false;
                }

            }else{
                stack.Push(sValue);
            }

        }

        return stack.Count == 0;
    }
}
