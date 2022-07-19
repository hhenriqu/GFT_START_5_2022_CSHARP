Console.WriteLine("digite um valor entre 0 a 999.999.999");

int number = int.Parse(Console.ReadLine());
do
if (number < 0 || number > 999999999)
Console.WriteLine("digite novamente um valor entre 0 a 999.999.999");
else
Console.WriteLine("valor");
while(number < 0 || number > 999999999);