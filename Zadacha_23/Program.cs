/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.WriteLine("Введите число N: ");
double N = Convert.ToDouble(Console.ReadLine());
double index = 1;


while (index <= N)
{
    double cub = Math.Pow(index, 3);
    Console.Write($"{cub}, ");
    index++;
}
