string[] allLongestStrings(string[] inputArray) {
    
    List<string> inputList = new List<string>(inputArray);
    Console.WriteLine(inputList.Count());
    int maxLength = inputList.OrderByDescending(x => x.Length).First().Length;
    inputList = new List<string>(inputArray);
    inputList.RemoveAll(s => s.Length < maxLength);
    return inputList.ToArray();

}

int commonCharacterCount(string s1, string s2) {
    
            Dictionary<char, int> letters = new Dictionary<char, int>();
            List<char> s2List = new List<char>(s2.ToCharArray());
            List<int> finalList = new List<int>();
            int total = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if(!letters.ContainsKey(s1[i]))
                {
                    letters.Add(s1[i], 1);
                }
                else
                {
                    letters[s1[i]] += 1;
                }
            }
            for(int i = s2.Length - 1;  i >= 0; i--)
            {
                if(letters.ContainsKey(s2[i]))
                {
                    int count = s2List.FindAll(s => s == s2[i]).Count();
                    if(count > 0)
                    {
                        if (count > letters[s2[i]])
                            total += letters[s2[i]];
                        else
                            total += count;
                            s2List.RemoveAll(s => s == s2[i]);
                    }
                }
            }
            return total;
}

bool isLucky(int n) {

        List<int> digits = new List<int>();
        while(n > 0)
        {
            digits.Add(n % 10);
            n /= 10;
        }
        if(digits.Count%2 == 0)
        {
            int firstHalf = 0;
            int secondHalf = 0;
            for(int i = 0; i < digits.Count(); i++)
            {
                if(i < digits.Count()/ 2)
                {
                    firstHalf += digits[i];
                }
                else{
                    secondHalf += digits[i];
                }
            }
            Console.Write(firstHalf+" : "+secondHalf);
            if(firstHalf == secondHalf)
            {
                return true;
            }
            else return false;
        }
    else return false;
}

int[] sortByHeight(int[] a) {
    List<int> n = new List<int>(a);
    n.RemoveAll(s => s == -1);
    n.Sort();
    int counter = 0;
    for(int i = 0; i < a.Length; i++)
    {
        if(a[i] != -1)
        {
            a[i] = n[counter];
            counter++;
        }
        
    }
    return a;
}

string reverseInParentheses(string inputString) {
            int s = 0, f = 0;
            int openingBrackets = 0, closingBrackets = 0;
            bool complete = false;
            int i = 0;
            while(!complete)
            {
                if (inputString.Length == 0){
                    break;
                }
                if (inputString[i] == '('){
                    s = i;
                    openingBrackets++;
                }
                else if (inputString[i] == ')'){
                    f = i;
                    closingBrackets++;
                }
                if(openingBrackets > 1){
                    openingBrackets = 1;
                }
                if (openingBrackets == closingBrackets && openingBrackets != 0){
                    char[] subString = inputString.Substring(s, f - s+1).ToArray();
                    Array.Reverse(subString);
                    List<char> chars = new List<char>(subString);
                    chars.RemoveAll(s => s == '(' || s == ')');
                    inputString = inputString.Remove(s, f - s+1);
                    inputString = inputString.Insert(s, new string(chars.ToArray()));
                    s = 0;
                    f = 0;
                    openingBrackets = 0;
                    closingBrackets = 0;
                    i = 0;
                }
                else {
                    i++;
                }
                if(openingBrackets == 0 && i == inputString.Length-1){
                    complete = true;
                }
              
            }
            return inputString;
}
