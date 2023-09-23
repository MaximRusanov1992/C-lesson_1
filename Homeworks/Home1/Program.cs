//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

// System.Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 > num2)
// {
//     System.Console.WriteLine($"max={num1} " );
// }
// if (num2 > num1)
// {
//     System.Console.WriteLine($"max={num2} " );
// }
// if (num2 == num1)
// {
//     System.Console.WriteLine("числа равны");
// }

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

// System.Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите третье число: ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// if (num1 > num2 && num1>num3)
// {
//     System.Console.WriteLine($"max={num1} " );
// }
// if (num2 > num1 && num2>num3)
// {
//     System.Console.WriteLine($"max={num2} " );
// }
// if (num3 > num1 && num3>num2)
// {
//     System.Console.WriteLine($"max={num3} " );
// }
// if (num3 == num1 && num3>num2)
// {
//     System.Console.WriteLine($"max={num3} " );
// }
// if (num2 == num1 && num2>num3)
// {
//     System.Console.WriteLine($"max={num2} " );
// }
// if (num2 == num3 && num2>num1)
// {
//     System.Console.WriteLine($"max={num2} " );
// }
// if (num2 == num1 && num1 == num3)
// {
//     System.Console.WriteLine("числа равны");
// }

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

// System.Console.WriteLine("input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num%2==0)
// {
//    System.Console.WriteLine("да");
// }
// else
// {
//    System.Console.WriteLine("нет");
// }

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

System.Console.WriteLine("input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count<num)
{
    if (count%2==0)
        if (count%2==0 & num == count+1 | num == count+2)
        {
            System.Console.Write(count);
            count++;
        }
        else
        {
            System.Console.Write($"{count}, ");
            count++;
        }
    else 
    {
        count++;
    }
}    