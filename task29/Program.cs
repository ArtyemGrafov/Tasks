using System;
class HelloWorld 
{
    static void Main() 
    {
        Console.Clear();
    
        int length = getInt("Enter length of array : ");
        
        int[] array = new int[length];
        
        for (int i = 0; i < length; i++)
        {
            array[i] = getInt($"Enter element array {i + 1} of {length} : ");
        }
    
        Console.WriteLine($"[{string.Join(", ", array)}]");
    }
  
    static int getInt(string message)
    {
        Console.Write(message);
        while(true)
        {
            if (int.TryParse(Console.ReadLine(), out int num))
                return num;
            Console.WriteLine("error");
        }
    }
}
