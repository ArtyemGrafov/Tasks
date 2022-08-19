using System;
class HelloWorld {
    static void Main() 
    {
        Console.Clear();
    
        int number = getInt("Введите число : ");
    
        int result = getSumDigits(number);
     
        Console.WriteLine("Сумма цифр = " + result);
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
}