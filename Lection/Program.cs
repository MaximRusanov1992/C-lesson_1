//LECTION2

// Task 1

// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }
// int[] array = { 11, 21, 31, 41, 15, 61, 17, 18, 19};
// array[0]= 12;
// System.Console.WriteLine(array[0]);

// int max = Max( 
//     Max(array[0], array[1], array[2]), 
//     Max(array[3], array[4], array[5]), 
//     Max(array[6], array[7], array[8])
// );
// System.Console.WriteLine(max);

// Task 2

// int[] array = {1,12,18,4,15,16,17,18};

// int n = array.Length;
// int find = 18;

// int index = 0;

// while (index<n)
// {
//     if(array[index] == find)
//     {
//         System.Console.WriteLine(index);
//         break;
//     }
//     index++;
// }

// Task 3

void FillArray(int[] collection);

void PrintArray(int[] col);
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}



// {
//     int length = collection.Length;
//     int index = 0
//     while (index < length)
//     {
//         collection[index] = new Random().Next(1,10);
//     }
// }

int[] array = new int[10];

FillArray(array);
PrintArray(array);
