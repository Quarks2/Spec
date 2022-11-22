// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 4

// Console.Write("Введите числа через запятую: ");
// int[] numbers = StringToNum(Console.ReadLine());
// PrintArray(numbers);
// int sum = 0;
// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] > 0)
//     {
//         sum++;
//     }
// }
// Console.WriteLine();
// Console.WriteLine($"количество значений больше 0 = {sum}");

// int[] StringToNum(string input)
// {
//     int count = 1;
//     for (int i = 0; i < input.Length; i++)
//     {
//         if (input[i] == ',')
//         {
//             count++;
//         }
//     }

//     int[] numbers = new int [count];
//     int index = 0;

//     for (int i = 0; i < input.Length; i++)
//     {
//         string temp = "";

//         while (input [i] != ',')
//         {
//         if(i != input.Length - 1)
//         {
//             temp += input [i].ToString();
//             i++;
//         }
//         else
//         {
//             temp += input [i].ToString();
//             break;
//         }
//         }
//         numbers[index] = Convert.ToInt32(temp);
//         index++;
//     }
//     return numbers;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.Write("]");
// }

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// void FindXY (double b1, double k1, double b2, double k2)
// {
//     if (k1 != k2)
//     {
//         double x = (b1 - b2)/(k2 - k1);
//         Console.WriteLine($"[{x}; {k1 * x + b1}]");
//     }
//     else
//     {
//         Console.WriteLine("Нет");
//     }
// }

// Console.WriteLine("y = k1 * x + b1");
// Console.WriteLine("y = k2 * x + b2");
// Console.WriteLine();
// Console.Write("Введите точку k1: ");
// int k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите точку b1: ");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите точку k2: ");
// int k2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите точку b2: ");
// int b2 = Convert.ToInt32(Console.ReadLine());

// FindXY(b1, k1, b2, k2);