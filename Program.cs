// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


bool Palindrom(int num)
{
    int num_copy = num;
    int inverted = 0;
    int temp = 0;
    while ( num > 0)
    {
    temp = num % 10;
    inverted = inverted * 10 + temp;
    num = num / 10;
    }
    if (num_copy == inverted)
    {
        Console.WriteLine("Input number" );
        Console.WriteLine( num_copy );
        Console.WriteLine("Inverted number" );
        Console.WriteLine( inverted );
            return true;
    } 
    else
    {
       Console.WriteLine("Input number" );
        Console.WriteLine( num_copy );
        Console.WriteLine("Inverted number" );
        Console.WriteLine( inverted );
            return false;
    }
}
Console.WriteLine("Input you number");
int number = Convert.ToInt32(Console.ReadLine());
bool result = Palindrom(number);
Console.WriteLine(result);


