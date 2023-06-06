// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

bool SummaStoron(int num1, int num2, int num3)
{
    bool summa = false;
    if (num1 < num2+num3 && num2 < num1+num3 && num3 < num1+num2)
        summa = true;
    else summa = false;
    return summa;
}

Console.Clear();

System.Console.WriteLine($"Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Введите число 3: ");
int num3 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Может существовать такой треугольник: {SummaStoron(num1, num2, num3)}");


// Console.Clear();
// System.Console.WriteLine("Введите сторону а: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите сторону b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите сторону c: ");
// int c = Convert.ToInt32(Console.ReadLine());

// void treug(int a, int b, int c)
// {
//     int ab = a+b;
//     int bc = b+c;
//     int ac = a+c;

//     if(ab > c && bc > a && ac >b)
//     {
//         System.Console.WriteLine("yes");
//     }
//     else
//     {
//         System.Console.WriteLine("no");
//     }
// }

// System.Console.WriteLine("input a");
// int a = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("input a");
// int b = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("input a");
// int c = Convert.ToInt32(Console.ReadLine());

// treug(a,b,c);


// bool Res(double x, double y, double z)
// {
//     bool flag = false;
//     if (x < z + y && z < x + y && y < z + x)
//     {
//         flag = true;
//     }
//     return flag;
// }
// System.Console.WriteLine("Введите последовательно три числа: ");
// double x = Convert.ToDouble(Console.ReadLine());
// double y = Convert.ToDouble(Console.ReadLine());
// double z = Convert.ToDouble(Console.ReadLine());

// if (Res(x, y, z))
// {
//     System.Console.WriteLine("Построить можно");
// }
// else
//     System.Console.WriteLine("Нельзя");