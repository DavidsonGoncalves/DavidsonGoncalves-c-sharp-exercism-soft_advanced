using System;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        Classification what =  new Classification();
        int total=0;
        
        for(int i=0; i<=number;i++)
        {
            if(i % number==0)
            {
                total+=i;   
            }

        }
         if(total==number){
            what = Classification.Perfect;
         }
         else 
         if(total>number){
             what = Classification.Abundant;
         }
         else 
             what = Classification.Deficient;
         
        return what;
    }
}
