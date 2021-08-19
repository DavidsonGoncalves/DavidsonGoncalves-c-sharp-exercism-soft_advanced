using System;

public static class Pangram{
    public static bool IsPangram(string input){
        char [] alphabet = {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
                
        string[] splitInput = input.Split();
        for(int i =0; i < splitInput.Length;){
           
            if(splitInput[i].ToUpper()==alphabet[i].ToString()){
                i++;
            }
            else
            if(splitInput[i] == " "){
                i++;
            }
            else{
                return false;
            }
        }
        return true;
    }
}
