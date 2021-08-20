using System;

public static class Grains
{
    static ulong [] chessboard =  new ulong[64];
    public static ulong Square(int n)
    {
        chessboard[0]=0;
        chessboard[1]=1;
        for(int i = 0; i<=chessboard.Length;)
        {
           if(chessboard[i]==0|| chessboard[i]==1){
                i++;
            }
            else{
                 chessboard[i] = chessboard[i-1]+chessboard[i-1];
                 i++;
            }
        }
        return chessboard[n];
    }

    public static ulong Total()
    {
        ulong totalvalue=0;
       foreach(ulong n in chessboard)
       {
           totalvalue+=n;
       }
       return totalvalue;
    }
}
