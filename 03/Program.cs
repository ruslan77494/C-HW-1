//Напишите прогромму которая на вход принимает три  числа и выдает какое число больше .

Console.WriteLine(" Пожалуйста введите 3 числа : ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());

int a = n;

int b = n1;

int c = n2;

int max = 0;

if (b > max) max = b;

if (c > max) max = c;

if (a > max)  max = a; 

Console.WriteLine(max);


