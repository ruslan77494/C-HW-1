//Напишите прогромму которая на вход принимает два числа и выдает какое число больше а какое ментшее.

Console.WriteLine(" Пожалуйста введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = Convert.ToInt32(Console.ReadLine());


int a = n;

int b = n1;


int min = 0;
int max = 0;
if (b > max) max = b;
if (b < a) min = b;
if (a > max) max = a;
if (a < b) min = a; 
Console.WriteLine(max);
Console.WriteLine(min);
