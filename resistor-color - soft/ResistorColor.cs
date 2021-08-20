using System;
public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        int code=0;
        for(int i =0; i<Colors().Length; i++)
        {
            if(Colors()[i]==color)
            {
                code = i;
            }
        }
        return code;
    }

    public static string[] Colors()
    {
      string[] colors = {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "violet", "grey", "white"};
      return colors;
    }
}