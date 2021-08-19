using System;

public static class Grains
{
    static ulong [] chessboard =  new ulong[64];
    public static ulong Square(int n)
    {
        chessboard[1]=1;
        for(int i = 1; i<=chessboard.Length+1; i++)
        {
            
            chessboard[i] = chessboard[i-1]+chessboard[i-1];
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