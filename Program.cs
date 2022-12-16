using System;
class Program
{
    static void Main(string[] args)
    {

        string[] arr = Console.ReadLine().Split();
        int N = int.Parse(arr[0]);
        int X = int.Parse(arr[1]);
        if ((N >= 1) && (X <= 10000))
        {
            string[] arr2 = new string[N];
            arr2 = Console.ReadLine().Split();
            for (int i = 0; i < arr2.Length; i++)
            {
                if (X > int.Parse(arr2[i]))
                {
                    Console.Write(arr2[i] + " ");
                }
            }
        }
        else { Console.WriteLine("잘못된값"); }


    }
}