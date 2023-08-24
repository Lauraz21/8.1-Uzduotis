Console.WriteLine("Iveskite 3 skaicius: ");
int number = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());

if (number == number2 && number3 == number)
{
    Console.WriteLine("Visi skaiciai yra lygus");
}
else if (number == number2 || number == number3 || number2 == number3 )
{
    Console.WriteLine("Du skaiciai yra lygus");
}
else
{
    Console.WriteLine("Ne vienas skaicius nera lygus");
}