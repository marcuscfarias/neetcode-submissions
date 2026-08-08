public class Solution {
    public bool IsAnagram(string s, string t) {

        //1. tamanho tem que ser igual
        //2. todas letras de s, precisam estar em t
        //3. todas letras de t, precisam estar em s

        if(s.Length != t.Length)
            return false;

        Dictionary<char, int> sCounter = new Dictionary<char,int>();
        Dictionary<char, int> tCounter = new Dictionary<char,int>();

        for(int i = 0; i < s.Length; i++){

            char sElement = s[i];
            char tElement = t[i];

            if(!sCounter.ContainsKey(sElement)){
                sCounter.Add(sElement, 1);
            }else{
                sCounter[sElement] += 1;    
            }

            if(!tCounter.ContainsKey(tElement)){
                tCounter.Add(tElement, 1);
            }else{
                tCounter[tElement] += 1;    
            }
            
            // Console.WriteLine("Key: {0}, Value: {1}", sElement, sCounter[sElement]);
        }

        foreach(var item in sCounter){

            char sKey = item.Key;
            int sValue = item.Value;

            if(!tCounter.ContainsKey(sKey))
                return false;
            
            int tValue = tCounter[sKey];

            if(sValue != tValue)
                return false;          
        }

        return true;
    }
}
