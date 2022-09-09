// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
bool CheckPaliandrom(int arg)
{   int num = arg;
    if ((num % 10) == (num % 100000 / 10000) && (num % 100 / 10) == (num % 10000 / 1000))
    {
        return true;
    }
    else return false;
}
System.Console.WriteLine("Введите пятизначное число");
int input = Convert.ToInt32(Console.ReadLine());
bool num = CheckPaliandrom(input);
if (num == true){
    System.Console.WriteLine("Yes");
}
else {
    System.Console.WriteLine("No");
}
