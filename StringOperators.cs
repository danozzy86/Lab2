using System;
/* 
   Lab 2 - Operations on Strings - Programming 1
   Daniel Osborne Github - danozzy86
   Due 9/14 @ 4PM
*/
class StringOperators {
    public static int VowelCount(string usrInput){
        //Loops through and checks how many vowels are in the string by using the split method.
        char[] vowelArr = {'A','E','I','O','U'};
        usrInput = usrInput.ToUpper();
        int intVowelCount = 0;

        foreach (char v in vowelArr){
        intVowelCount += usrInput.Split(v).Length;    
        }
        return intVowelCount - 5;
    }
    public static int WordCount(string usrInput){
        //This method is still a WIP, basically just checks for spaces to count words.
        int intWordCount = 1;
        int strPos = 0;

        while (strPos <= usrInput.Length - 1){
            if (usrInput[strPos] == ' '){
                intWordCount++;
            }
            strPos++;
        }
        return intWordCount;
    }
    public static bool IsPalindrome(string usrInput){
        //This method will basically seperate the string into a char array, reverse it, turn it back into a string then compare.
        string usrInputRev;
        char[] charArr = usrInput.ToCharArray();
        
        Array.Reverse(charArr);
        usrInputRev = new string(charArr);

        if (usrInput == usrInputRev)
            return true;
        else
            return false;
    }
}


