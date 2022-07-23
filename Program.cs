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





/*string number = (Console.ReadLine ());
int lenght = (int)(Math.Log10(Math.Abs(Convert.ToInt32(number)))+1);
//Console.WriteLine(lenght);
if (lenght == 5)
{
    for (int i = 0; i < lenght-1; i++)
    {
        if (number[i] == number[lenght-1-i]) Console.WriteLine("Число является палиндромом");
        else Console.WriteLine("Введенное число не является палиндромом");
    }
}
else Console.WriteLine("Введено не пятизначное число");*/