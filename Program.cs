/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/
int number = Convert.ToInt32 (Console.ReadLine ());
int lenght = (int)(Math.Log10(Math.Abs(number))+1);
Console.WriteLine(lenght);
/*if (lenght == 5 && number[1] != "-")
{
    for (int i = 0; i < lenght-1; i++)
    {
        if (number[i] == number[lenght-1-i]) Console.WriteLine("Число является палиндромом");
    }
}*/
