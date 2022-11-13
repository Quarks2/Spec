//   Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B 

// Console.WriteLine("Введите число а: ");
// int firstnumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число b: ");
// int secondnumber = Convert.ToInt32(Console.ReadLine());

// int count = firstnumber;
// int degree = 1;
// while (degree < secondnumber)
// {
//     count = count * firstnumber;
//     degree++;
// }
// Console.WriteLine($"Число А в степени В = {count}");



//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


// Console.WriteLine("Введите число а: ");
// int firstnumber = Convert.ToInt32(Console.ReadLine());

// int sum = 0;
// int temp = firstnumber;

// while ( temp > 0)
// {   
//     int check = temp % 10;
//     temp = temp / 10;
//     sum = sum + check;  
// }
// Console.WriteLine($"Сумма цифр в числе = {sum}");


// Напишите программу, которая создает массив заданного пользователем размера, заполняет массив элементами от 1 до 99 и выводит их на экран.


// Console.Write("Введите количество элементов массива:\t");
// int elementsCount = Convert.ToInt32(Console.ReadLine());
// int [] myArray = new int [elementsCount];
// Random rand = new Random();
// Console.Write("[");
// for(int i =0;i<myArray.Length;i++)
//    {
//     myArray[i] = rand.Next(0,99);
//     Console.Write($"{myArray[i]},");
//    }
// Console.Write("\b]");

