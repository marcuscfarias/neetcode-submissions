public class Solution {
    public bool IsPalindrome(string s) {
        
        int l = 0;
        int r = s.Length - 1;

        while(!string.IsNullOrWhiteSpace(s) && l < r){

            char leftChar = s[l];
            char rightChar = s[r];

            Console.WriteLine("leftChar: {0}, rightChar: {1}", leftChar, rightChar);

            while(l < r && !Char.IsLetterOrDigit(rightChar)){
                r--;
                rightChar = s[r];
                Console.WriteLine("new rightChar: {0}", rightChar);
            }

            while(l < r && !Char.IsLetterOrDigit(leftChar)){
                l++;
                leftChar = s[l];
                Console.WriteLine("new leftChar: {0}", leftChar);
            }


            if(Char.ToLower(leftChar) != Char.ToLower(rightChar)){
                return false;
            }

            r--;
            l++;
        }

        return true;
    }
}
