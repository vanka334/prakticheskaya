using System;

Console.WriteLine("1. Сложить 2 числа");
Console.WriteLine("2. Вычесть первое из второго");
Console.WriteLine("3. Перемножить два числа");
Console.WriteLine("4. Разделить первое на второе");
Console.WriteLine("5. Возвести в степень N первое число");
Console.WriteLine("6. Найти квадратный корень из числа");
Console.WriteLine("7. Найти 1 процент от числа");
Console.WriteLine("8. Найти факториал из числа");
Console.WriteLine("9. Выйти из программы");
int nomer = 0;
do
{
    Console.WriteLine("Введите номер задания");
    nomer = Convert.ToInt16(Console.ReadLine());
    if (nomer == 1)
    {
        Console.WriteLine("Введите два числа");
        int chislo1 = Convert.ToInt32(Console.ReadLine());
        int chislo2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Сумма равна = " + (chislo2 + chislo1));

    }
    else if (nomer == 2)
    {
        Console.WriteLine("Введите два числа");
        int chislo1 = Convert.ToInt32(Console.ReadLine());
        int chislo2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Разность равна = " + (chislo2 - chislo1));

    }
    else if (nomer == 3)
    {
        Console.WriteLine("Введите два числа");
        int chislo1 = Convert.ToInt32(Console.ReadLine());
        int chislo2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Умножение двух чисел = " + (chislo2 * chislo1));
    }
    else if (nomer == 4)
    {
        Console.WriteLine("Введите два числа");
        double chislo1 = Convert.ToDouble(Console.ReadLine());
        double chislo2 = Convert.ToDouble(Console.ReadLine());
        double resultat = chislo1 / chislo2;
        Console.WriteLine("Деление двух чисел = " + resultat );
    }
    else if (nomer == 5)
    {
        Console.WriteLine("Введите число для возведения в степень");
        double chislo1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите степень, в которую возвести число");
        double chislo2 = Convert.ToDouble(Console.ReadLine());
        double chislo3 = Math.Pow(chislo1, chislo2);
        Console.WriteLine("Получилось = " + chislo3);
    }
    else if (nomer == 6)
    {
        Console.WriteLine("Введите число для нахождения корня");
        double chislo1 = Convert.ToDouble(Console.ReadLine());
        double chislo3 = Math.Sqrt(chislo1);
        Console.WriteLine("квадратный корень из " + chislo1 + " = " + chislo3);
    }
    else if (nomer == 7)
    {
        Console.WriteLine("Введите число для нахождения одного процента");
        double chislo1 = Convert.ToDouble(Console.ReadLine());
        double chislo3 = chislo1 * 0.01;
        Console.WriteLine("1 % от числа =  " + chislo3);
    }
    else if (nomer == 8)
    {
        Console.WriteLine("Введите число для нахождения факториала");
        int chislo1 = Convert.ToInt32(Console.ReadLine());
        int res = 1;
        for (int i = 2; i <= chislo1; i++)
        {
            res = res* i ;
            
        }
        Console.WriteLine("Факториал введенного числа = " + res);
    }
    else if (nomer == 9)
    {
        Console.WriteLine("Программа завершена");
    }
}
while (nomer != 9);

    


