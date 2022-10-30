Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine());
int sum = 0;
string s = x.ToString();
for (int i = s.Length; i>=0; i--)
{
    sum+=x/(int)Math.Pow(10, i);
    x = x%(int)Math.Pow(10, i);
}
Console.Write("Сумма цифр числа составила: ");
Console.WriteLine(sum);




