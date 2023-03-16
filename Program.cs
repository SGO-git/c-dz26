//  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    else if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    return 0;
}

int mNum = ReadInt("Input number M ");
int nNum = ReadInt("Input number N ");

if (mNum >= 0 && mNum >= 0) System.Console.WriteLine(Akkerman(mNum, nNum));
else System.Console.WriteLine("wrong");