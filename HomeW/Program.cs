using System;

class Program 
{
    public static void Main ()
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());

    if (A > B)
    {
        Console.WriteLine ($"Максимальное число : {A}");
        Console.WriteLine ($"Минимальное число : {B}");

    }
    else if (B > A)
    {
        Console.WriteLine ($"Максимальное число : {B}");
        Console.WriteLine ($"Минимальное число : {A}"); 
    }
    else 
    {
        Console.WriteLine ("Числа равнозначны");
    }
    }
}
