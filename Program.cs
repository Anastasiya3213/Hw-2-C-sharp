// ДЗ2 
/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
/*
int number = ReadInt("Введите трехзначное число: ");
int amount = number.ToString().Length;

if (amount < 3 || amount > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine(InCenter(number));
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int InCenter(int a)
{
    
    int result = ((a / 10) % 10);
    return result;
}
*/

/* 
Задача 13: Напишите программу, которая выводит третью цифру заданного числа.
645 -> 5
32679 -> 6
21 -> -1
*/
/*
int number = ReadInt("Введите число: ");
int count = number.ToString().Length;
Console.Write(MakeArray(number, count));

int ReadInt(string message)
{
 Console.Write(message);
 return Convert.ToInt32(Console.ReadLine());
}

int MakeArray(int a, int b)
{
int result = -1;
 if (b < 3)
    {
 Console.Write("Третьей цифры нет: ");
    }
 else
    {
 int c = 1;
 for (int i = b; i > 3; i--)
        {
 c = c * 10;
        }

 result = (a / c) % 10;
    }
return result;
}
*/ 

/*
Задача 15: 
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

int dayNumber = ReadInt("Введите число от 1 до 7: ");
Console.WriteLine(WorkHoliday(dayNumber));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

string WorkHoliday(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write("Под цифрой " + a + " - Выходной");
        }
        else
        {
            Console.Write("Под цифрой " + a + " - Рабочий");
        }
    }
    else
    {
        Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить");
    }
    return " день.";
}






























/*
int CutNumber(int number)

{
int sot = number / 100;
int ed = number % 10;

int result = sot * 10 + ed;
return  result;
}


//или num2 = num3 / 100 * 10 + num3 % 10 
int num = new Random().Next(100, 1000);

int newNum = CutNumber(num);
Console.WriteLine($"new version of {num} is {newNum}"); 
*/
//Напишите программу, которая показывает случайное число из 
//отрезка [10,99] и показывает наибольшую цифру числа.
/*int MaxNumber(int number) 
{
    int dec = number/10;
    int det = number%10; 
    int result = dec;
    if(det<result) 
    {
    result = det;
    }
    else 
    {
    result = dec;
    }
    return result;
  

    
}
int num = new Random().Next(10,100);
int max = MaxNumber(num);
Console.WriteLine($"maximum number {num} and {max}");
*/
//Напишите программу, котор будет принмать на вход 2 числа и выводить,
//является ли второе число кратным первому.
/*
bool NumKrat(int number1, int number2)
{   
    int result = false;
    if(number2%number1 == 0)
    {
        result = true;
    }

    return result;
}
Console.WriteLine("Input number {num1} and {num2} ");
int num1 = Convert.ToInt32(num1);
Console.WriteLine("Input number {num1} and {num2} ");
bool result = NumKRat(number1,number2);
Console.WriteLine(result);
*/

