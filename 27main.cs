/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
    static void Main() 
    {
        Console.Clear();
    
        int number = getInt("Enter a number : ");
    
        //int degree = getInt("Enter the degree : ");
    
        int result = getSumDigits(number);//exponentiation(number, degree);
     
        Console.WriteLine("Result = " + result);
    }
  
    static int getInt(string message)
    {
        Console.Write(message);
        while(true)
        {
            if (int.TryParse(Console.ReadLine(), out int num))
                return num;
            Console.WriteLine("Ошибка ввода");
        }
        
    }
    
    static int getSumDigits(int n)
    {
        n = Math.Abs(n);
        int sumDigits = 0;
        while (n > 0)
        {
            sumDigits += n % 10;
            n /= 10;
        }
        return sumDigits;
    }
  
    // static int exponentiation(int n, int e)
    // {
    //     if (e < 0) return -1;
    //     else if (e == 0) return 1;
    //     else if (n == 0) return 0;
    //     else
    //     {
    //         int exp = 1;
    //         for (int i = 0; i < e; i++)
    //             {
    //                 exp *= n;
    //             }
    //         return exp;
    //     }
    // }
}
