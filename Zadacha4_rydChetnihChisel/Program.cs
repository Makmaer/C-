int N;
Console.Write("Vvedite chislo : ");
N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Polnij ryd: ");
for (int x = 1; x < N+1; x++)
{
Console.Write(" " + x);
}
Console.WriteLine( "\n Ryd iz chetnih: ");

for (int x=2; x < N+1;)
{
Console.Write(" " + x);
x=x+2;
}