Console.WriteLine("Введите пятизначное число: ");
int pal = Convert.ToInt32(Console.ReadLine());
bool Check(int pal)
{
int sum = 0;
int temp = pal;

while (sum < pal)
    {
        sum = sum * 10 + temp % 10;
        temp /= 10;
    }
    if (sum == pal) return true;
    else return false;
}
bool result = Check(pal);
Console.WriteLine($"Число {pal} Является палиндромом? {result}");