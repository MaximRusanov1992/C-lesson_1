// void Cratnost (int num1, int num2)
// {
//     if (num1 % num2 == 0)
//     {
//         System.Console.WriteLine($"{num1}, {num2} -> кратны");
//     }
//     else
//     {
//         System.Console.WriteLine($"{num1}, {num2} -> не кратны, остаток {num1%num2}");

//     }
// }

// System.Console.WriteLine("input first num: ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("input second num: ");
// int n2 = Convert.ToInt32(Console.ReadLine()); 

// Cratnost(n1, n2);




// int RandomNumber(int num)
// {
//     System.Console.WriteLine($"random number -> {num}");

//     int ed = num % 10;
//     int dec = num / 10;

//     if (ed>dec)
//     {
//         return ed;
//     }
//     else
//     {
//         return dec;
//     }
// }

// int num = new Random().Next(10,100);


// System.Console.WriteLine(RandomNumber(num));



int RandomNumber(int num)
{
    System.Console.WriteLine($"random number -> {num}");

    int ed = num % 10;
    int dec = num / 10;
    int hun = num / 100;
    int num0 = hun * 10 + ed;
    return num0;
}
int num = new Random().Next(100,1000);


System.Console.WriteLine(RandomNumber(num));

