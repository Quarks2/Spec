//   Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B 

// int Stepen(int firstnumber, int secondnumber)
// {
//     int result = firstnumber;
//     for (int pow = 1; pow < secondnumber; pow++)
//         result *= firstnumber;
//     return result;
// }
// Console.Write("Введите число а: ");
// int firstnumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число в: ");
// int secondnumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Число А в степени В = {Stepen(firstnumber, secondnumber)}");



//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int SumOfNumbers(int number)
// {
//     int result = 0;
//     int temp = number;
//     while (temp != 0)
//     {
//         result += temp % 10;
//         temp /= 10;
//     }
//     return result;
// }
// Console.WriteLine("Введите число а: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма цифр в числе = {SumOfNumbers(number)}");


// Напишите программу, которая создает массив заданного пользователем размера, заполняет массив элементами от 1 до 99 и выводит их на экран.


// int[] RandArray(int n)
// {
//     int[] arr = new int[n];
//     for (int index = 0; index < n; index++)
//     {
//         arr[index] = new Random().Next(1,100);
//     }
//     return arr;
// }

// void Print(int[] arr)
// {
//     Console.Write("[");
//     for(int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]},");
//     }
//     Console.Write("\b]");
//     Console.WriteLine();
// }

// Console.Write("Введите количество элементов массива:\t");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num > 0) Print(RandArray(num));
// else Console.WriteLine("Не может быть 0 элементов, попробуйте снова");