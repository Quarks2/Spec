// Задача 1

// bool Check(int number)
// {
//     int reversed = 0;
//     int temp = number;
//     while (reversed < number)
//     {
//         reversed = reversed * 10 + temp % 10;
//         temp /= 10;
//     }
//     if (reversed == number) return true;
//     else return false;
// }
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// bool result = Check(num);
// Console.WriteLine($"Число {num} Является палиндромом? {result}");


// Задача 2


// double Dist(int xa, int xb, int ya, int yb, int za, int zb)
// {
//     double abz = Math.Sqrt(((xb-xa)*(xb-xa)) + ((yb-ya)*(yb-ya)) + ((zb-za)*(za-zb))); 
//     return abz;
// }
// Console.Write("Введите xa: ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите xb: ");
// int n2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите ya: ");
// int n3 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите yb: ");
// int n4 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите za: ");
// int n5 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите zb: ");
// int n6 = Convert.ToInt32(Console.ReadLine());
// double result = Dist(n1,n2,n3,n4,n5,n6);

// Console.WriteLine($"Расстояние между точками ({n1},{n4}) и ({n2},{n5}) и ({n3},{n6}) равно {result}");

// Задача 3

// void Table(int n)
// {
//     for (int cub = 1; 
//              cub <= n;
//              cub++)
//              {
//                 Console.Write($"{cub*cub*cub}, ");
//              }           
// }Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Table(n);
