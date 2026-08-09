public class Solution {
    public bool IsPalindrome(string s) {
        
        int i = 0;
        int j = s.Length - 1;

        while(!string.IsNullOrWhiteSpace(s) && i < j){
            char leftChar = s[i];
            char rightChar = s[j];

            Console.WriteLine("leftChar: {0}, rightChar: {1}", leftChar, rightChar);

            while(!char.IsLetterOrDigit(leftChar) && i<j){
                i++;
                leftChar = s[i];
                Console.WriteLine("leftChar: {0}", leftChar);
            }

            while(!char.IsLetterOrDigit(rightChar) && i < j){
                j--;
                rightChar = s[j];
                Console.WriteLine("rightChar: {0}", rightChar);
            }

            if(Char.ToLower(rightChar) != Char.ToLower(leftChar)){
                return false;
            }

            i++;
            j--;
        }

        return true;
    }
}
