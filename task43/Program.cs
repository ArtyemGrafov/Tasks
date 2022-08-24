// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

int b1 = GetInt("Введите b1 для f1(x) = K1*x + b1 : ");
int k1 = GetInt("Введите к1 для f1(x) = K1*x + b1 : ");
int b2 = GetInt("Введите b2 для f2(x) = K2*x + b2 : ");
int k2 = GetInt("Введите к2 для f2(x) = K2*x + b2 : ");

GetCrossCoord(k1, b1, k2, b2);

//*********************************************************//

int GetInt(string msg)
{
    Console.Write(msg);
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int res)) return res;
        Console.WriteLine("Ошибка ввода!");
        Console.Write(msg);
    }
}

void GetCrossCoord(int k1, int b1, int k2, int b2)
{
    if (k1 - k2 == 0) Console.WriteLine("f1 и f2 не пересекаются."); 
    else 
    {
        double x = (double)(b2 - b1) / (double)(k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения f1 и f2 : ({x}; {y}).");
    }    
}