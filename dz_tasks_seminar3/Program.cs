
void Zadacha19()
{
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine ("Задача 19");
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int one = number / 10000;
int two = (number / 1000) % 10;
int three = (number / 100) % 10;
int four = (number / 10) % 10;
int five = number % 10;

if (one == five && two == four)
{
    Console.WriteLine("Полиндром");
}
else
{
    Console.WriteLine("Неполиндром");
}
}


void Zadacha21()
{
// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine ("Задача 21");
Random random = new Random();
double Ax = random.Next(-10, 11);
double Ay = random.Next(-10, 11);
double Az = random.Next(-10, 11);
double Bx = random.Next(-10, 11);
double By = random.Next(-10, 11);
double Bz = random.Next(-10, 11);

Console.WriteLine($"Точки: A({Ax}, {Ay}, {Az}), В({Bx}, {By}, {Bz})");
double Length = Math.Round(Math.Sqrt(Math.Pow((Bx - Ax),2) + Math.Pow((By - Ay),2) + Math.Pow((Bz - Az),2)),2);
Console.WriteLine($"Растояние между А и B: {Length}");
}



void Zadacha23()
{
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine ("Задача 23");
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
double Cube;

while (i <= N)
{
    Cube = Math.Pow(i, 3);
    Console.WriteLine($" {Cube}");
    i++;
}
}


Zadacha19();
Zadacha21();
Zadacha23();