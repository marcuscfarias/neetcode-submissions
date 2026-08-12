public class Solution {
    public bool IsValid(string s) {
        
        if(string.IsNullOrWhiteSpace(s)){
            return false;
        }

        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> pairBrackets = new Dictionary<char,char>(){
            {'}','{'},
            {']','['},
            {')','('}
        };

        for(int i = 0; i < s.Length; i++){

            char sValue = s[i];
            Console.WriteLine("sValue: {0}", sValue);

            if(!pairBrackets.ContainsKey(sValue)){
                stack.Push(sValue);
            }else{
                Console.WriteLine("i: {0}, Contém!", i);
                if(stack.Count > 0 && stack.Peek() == pairBrackets[sValue]){
                    stack.Pop();
                }else{
                    return false;
                }
            }
        }


        return stack.Count == 0;
    }
}
