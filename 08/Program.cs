// задача 4 Напишите программу которая принимает на вход число (N)  а на выходе принимает все четные числа от 1 до N.

Console.WriteLine(" Пожалуйста введите число: ");
int n= Convert.ToInt32(Console.ReadLine());
for (int i = 1 ; i <= n; i++)
{
    
    if (i % 2 == 0)
    {
        Console.Write(i);
    }

     {
        Console.Write(" ");
    }
}

