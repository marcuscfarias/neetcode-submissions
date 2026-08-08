public class Solution {
    public bool IsAnagram(string s, string t) {

        //1. tamanho de S tem que ser tamanho de t
        //2. a soma de cada caracter tem que ser iguais
        //2.1 os caracteres de s tem que ter a mesma soma de t
        //2.2 os caracteres de t tem que ter a mesma soma de s

        if(s.Length != t.Length){
            return false;
        }

        Dictionary<char, int> sCounter = new Dictionary<char, int>();
        Dictionary<char, int> tCounter = new Dictionary<char, int>();

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
        }

        foreach(var item in sCounter){
            
            char sKey = item.Key;
            int sValue = item.Value;

            if(!tCounter.ContainsKey(sKey)){
                return false;
            }

            int tValue = tCounter[sKey];

            if(tValue != sValue){
                return false;
            }
        }

        return true;
    }
}
