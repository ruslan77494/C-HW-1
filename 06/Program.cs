
    // Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
Console.WriteLine("Введите пожалуйста  число  : ");
int n = Convert.ToInt32(Console.ReadLine());

if (n == 0) {
    Console.WriteLine (" ");
}
else
if (n % 2 == 0) {
    Console.WriteLine(" + ");
}
else 
Console.WriteLine(" - " );

