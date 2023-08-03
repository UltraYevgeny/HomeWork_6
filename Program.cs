/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

/*
void Zero(int [] arrDigits)
{   
    int count = 0;
    for (int i = 0; i < arrDigits.Length; i++)
    {
        if (arrDigits[i] > 0)
        count++;
    }
    Console.WriteLine("Number of digits greater than zero: " + count);
}

int[] EnterNumber(int numberVolues)
{
    int [] arrDigits = new int[numberVolues];
    for (int i = 0; i < numberVolues; i++)
    {
        Console.Write($"Enter volue №{i+1}: ");
        arrDigits[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arrDigits;
}


int Question()
{   
    int numberValues = 0;
    while (numberValues < 1)
    {
    Console.Write("How many values do you want to enter: ");
    numberValues = Convert.ToInt32(Console.ReadLine());
    }
    return numberValues;
}


int[] arrDigits = EnterNumber(Question());
Zero(arrDigits);
*/


/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
-------------------------------------------------------
y = k1*x + b1
y = k2*x + b2

k1*x + b1 = k2*x + b2
k1*x - k2*x = b2 - b1
x*(k1 - k2) = b2 -b1

x = (?)/(?)
*/


void CrossPoint(double[] arrayCoord)
{
    double b1 = arrayCoord[0];
    double k1 = arrayCoord[1];
    double b2 = arrayCoord[2];
    double k2 = arrayCoord[3];

    double x = (b2-b1)/(k1-k2);
    Console.WriteLine("Value x = " + x);

    double y1 = k1*x + b1;
    double y2 = k2*x + b2;
    Console.WriteLine($"Cross of points (y1/y2): {y1}/{y2}");
}

double[] EnterCoord()
{
    double [] arrayCoord = new double[4];
    Console.Write($"Enter coordinate b1: ");
    arrayCoord[0] = Convert.ToDouble(Console.ReadLine());
    Console.Write($"Enter coordinate k1: ");
    arrayCoord[1] = Convert.ToDouble(Console.ReadLine());
    Console.Write($"Enter coordinate b2: ");
    arrayCoord[2] = Convert.ToDouble(Console.ReadLine());
    Console.Write($"Enter coordinate k2: ");
    arrayCoord[3] = Convert.ToDouble(Console.ReadLine());
    return arrayCoord;
}

Console.WriteLine("Given the equations:\ny1 = k1 * x + b1\ny1 = k2 * x + b2");
Console.WriteLine("Enter your coordinates");
CrossPoint(EnterCoord());

