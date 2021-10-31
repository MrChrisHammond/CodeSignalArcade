int add(int param1, int param2) {
return param1 + param2;
}

int centuryFromYear(int year) {
    int result = year / 100;
    if(year % 100 == 0){
        return result;
    }
    else{
         return result + 1; 
    }
}

bool checkPalindrome(string inputString) {
    string newString = new string(inputString.ToCharArray().Reverse().ToArray());
  
    if(newString.Equals(inputString))
    {
        return true;
    }
    else return false;
}
