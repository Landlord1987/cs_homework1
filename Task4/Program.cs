Console.WriteLine("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int[] num = {num1, num2, num3};
int max = num[0];

if (max < num[1]) max = num[1];
if (max < num[2]) max = num[2];

Console.WriteLine("max = {0}", max);