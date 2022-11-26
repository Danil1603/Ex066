/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/ 

int GetNumber(string msg)
{
    Console.WriteLine(msg);
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}

void GapNumberSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    GapNumberSum(numberM, numberN, sum);
}


int userNumberM = GetNumber("Введите число M:");
int userNumberN = GetNumber("Введите число N:");
GapNumberSum(userNumberM, userNumberN, 0);