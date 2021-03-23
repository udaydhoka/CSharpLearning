/* mod 8 arrays

using System;

class Program
{
   public static void Main()
    {

        int[] i = new int[3];
        i[1] = 0;
        i[0] = 1;
        i[2] = 3;
        //i[3] = 4;// throws inder out of range error since ,the size is 3
        Console.WriteLine(i[0]);
    }
}
//*/