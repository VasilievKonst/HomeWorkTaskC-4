// Ввод значений чисел A B

double GetAB(string text)
{
Console.Write(text + ":");
double value = Convert.ToDouble(Console.ReadLine());
return value;
}
double A = GetAB("Введите значение числа А");
double B = GetAB("Введите значение числа В");

double count = 1;
double resault = A;

while (count < B)
{
    resault *= A;
    count++ ;
}

Console.Write("Результатом возведения А=" +A+ ", в степень В=" +B+ ", будет являться число: ");
Console.WriteLine(resault);