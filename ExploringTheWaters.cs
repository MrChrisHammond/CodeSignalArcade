int[] alternatingSums(int[] a) {
    int oddeven = 0;
    int[] returnArr = new int[2];
    for(int i = 0; i < a.Length; i++)
    {
        if(i%2 == 0)
        {
            returnArr[0] += a[i];
        }
        else
        {
            returnArr[1] += a[i];
        }
    }
    return returnArr;
}

string[] addBorder(string[] picture) {
    string[] returnArr = new string[picture.Length + 2];
    int longestRow = 0;
    for(int i = 1; i < returnArr.Length-1; i++)
    {
        if(picture[i-1].Length > longestRow)
            longestRow = picture[i-1].Length;
        
        returnArr[i] = picture[i-1].Insert(0, "*");
        returnArr[i] += "*";
    }
    string stars = "";
    for(int i = 0; i < longestRow+2; i++)
    {
        stars += "*";
    }
    returnArr[0] = stars;
    returnArr[returnArr.Length-1] = stars;
    return returnArr;
}

bool areSimilar(int[] a, int[] b) {
    
    int diffCount = 0;
    
    for(int i = 0; i < a.Length; i++)
    {
        if(a[i] != b[i])
            diffCount++;
    }
    
    if(diffCount > 2)
        return false;
    
    Array.Sort(a);
    Array.Sort(b);

    return Enumerable.SequenceEqual(a, b);
}

int arrayChange(int[] inputArray) {
    int count = 0;
    for(int i = 0; i < inputArray.Length-1; i++)
    {
        if(inputArray[i] >= inputArray[i+1])
        {
            int diff = inputArray[i] + 1 - inputArray[i+1];
            inputArray[i+1] = inputArray[i]+1;
            count += diff;
        }
    }
    return count;
}

bool palindromeRearranging(string inputString) {
           // if (inputString.Length == 1)
           //     return true;
            List<char> stringList = new List<char>(inputString.ToCharArray());
            int single = 0;
               
            List<char> unique = stringList.GroupBy(s => s).Select(s => s.FirstOrDefault()).ToList();
            for(int i = 0; i < unique.Count; i++)
            {
                if(stringList.FindAll(s => s.Equals(unique[i])).Count()%2 != 0)
                {
                    single++;
                }
                if(single > 1)
                {
                    break;
                }
            }
            return single < 2;
}


