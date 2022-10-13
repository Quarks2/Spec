//Console.Write("Input int number: ");
//int num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Its new number {num} and its good" );

//Задача 1. Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя)
/*
Console.Write("Input int number: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = num*num;
Console.WriteLine($"Quard of {num} is {result}");
*/
// Задача 2. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
/*
Console.Write("Input first int number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second int number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1==num2*num2){
    Console.WriteLine($"{num1} is a quard of {num2}");
}
else{Console.WriteLine($"{num1} is not quard of {num2}");
}
*/
// Задача 3. Напишите программу, которая на вход принимает одно число (N), а на выходе 
// показывает все целые числа в промежутке от -N до N.
/*
Console.Write("Input first int number: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = (-1)*num;
while (current <= num){
    Console.Write(current + " ");
    current++;
}
*/
// Задача 4. Напишите программу, которая принимает на вход трёхзначное число и на 
// выходе показывает последнюю цифру этого числа.

//357 / 100 = 3 деление нацело
//357 % 100 = 57 деление с остатком

Console.Write("Input three-dight int number: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = num % 10;
Console.WriteLine($"Last dight of {num} is {result}");