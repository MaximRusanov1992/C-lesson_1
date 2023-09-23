//System.Console.WriteLine("input number: ");
//int num = Convert.ToInt32(Console.ReadLine()); 
//System.Console.WriteLine("Your num is -> " + num);

//System.Console.WriteLine("input number: ");
//int num = Convert.ToInt32(Console.ReadLine()); 
//System.Console.WriteLine($"Quad of {num} is ->  {num*num} " );

//System.Console.WriteLine("input number 1: ");
//int num = Convert.ToInt32(Console.ReadLine());
//System.Console.WriteLine("input number 2: ");
//int QuadNum = Convert.ToInt32(Console.ReadLine()); 
//if (QuadNum==num*num)
//{
//    System.Console.WriteLine("да");
//}
//else
//{
//    System.Console.WriteLine("нет");
//}


//System.Console.WriteLine("input number: ");
//int num = Convert.ToInt32(Console.ReadLine());
//int nums = -num;
//while (nums<num)
//{
//    System.Console.Write($"{nums}, ");
//    nums+=1;
//}
//System.Console.WriteLine(num);


System.Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 100 && num<=999)
{
    System.Console.WriteLine($"последняя цифра числа {num} -> {num%10} " );
}
else
{
    System.Console.WriteLine($"ваше число не трехзначное" );
}