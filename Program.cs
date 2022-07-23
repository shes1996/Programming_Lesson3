/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/
int number = Convert.ToInt32(Console.ReadLine());
int temporary = number;
int rebmun = 0;
while (temporary != 0)
{
    rebmun = rebmun * 10 + temporary % 10;
    temporary = temporary/10;
}
if (number==rebmun) Console.WriteLine("Число является палиндромом");
else Console.WriteLine("Число не является палиндромом");


/*Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите координату x1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z1");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y2");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z2");
int z2 = Convert.ToInt32(Console.ReadLine());
double distance = Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2)+Math.Pow(z2-z1, 2));
Console.WriteLine("Расстояние между точками = "+ distance);
*/

/*Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < N+1; i++)
{
    double cube = Math.Pow(i, 3);
    Console.WriteLine (cube);
}*/