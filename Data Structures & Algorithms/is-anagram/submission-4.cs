public class Solution {
    public bool IsAnagram(string s, string t) {

        //0. O que é um anagrama? É pegar uma palavra e embaralhar suas letras. Dessa forma, se forma uma palavra diferente, mas com os mesmos caracteres.
        //1. o tamanho precisa ser igual (OK)
        //2. Em s não pode ter letras diferentes de t
        //3. em t não pode ter letras diferentes de s
        //4. o número de repetições de cada caracter precisam ser os mesmos.
        //5. caso contrário, é falso.

        if(s.Length != t.Length)
            return false;

        Dictionary<char, int> sCounter = new Dictionary<char, int>();
        Dictionary<char, int> tCounter = new Dictionary<char, int>();
        
        for(int i = 0; i < s.Length; i++){

            char sElement = s[i];
            char tElement = t[i];

            if(!sCounter.ContainsKey(sElement))
                sCounter.Add(sElement, 1);
            else
                sCounter[sElement] += 1;

            if(!tCounter.ContainsKey(tElement))
                tCounter.Add(tElement, 1);
            else
                tCounter[tElement] += 1;   
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

        // Console.WriteLine("Dicionário S.");
        // foreach(var item in sCounter){
        //     Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
        // }

        // Console.WriteLine("Dicionário T.");
        // foreach(var item in tCounter){
        //     Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
        // }

        return true;
    }
}
