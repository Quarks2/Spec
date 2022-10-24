// #1

// int second(int num)
// {
//     int lastTwoDigits = num / 10;
//     int two = lastTwoDigits % 10;
//     return two;
// }
// Console.Write("Введите трёхзначное число: ");
// int input = Convert.ToInt32(Console.ReadLine());
// int result = second(input);
// Console.WriteLine($"Вторая цыфра числа {input} это {result}");

// //#2
// Console.Write("Введите трёхзначное число число: ");
// int num  = Convert.ToInt32(Console.ReadLine());
// string numText = Convert.ToString(num);
// if (numText.Length > 2){
//   Console.WriteLine("третья цифра " + numText[2]);
// }
// else {
//   Console.WriteLine("третьей цифры нет");
// }

// //#3
// Console.Write("Введи цифру, обозначающую день недели: ");
// int day = Convert.ToInt32(Console.ReadLine());

// void Check (int day) {
//   if (day == 6 || day == 7) {
//   Console.WriteLine("Это выходной день");
//   }
//   else if (day < 1 || day > 7) {
//     Console.WriteLine("это не день недели");
//   }
//   else Console.WriteLine("Это будний день");
// }

// Check(day);


