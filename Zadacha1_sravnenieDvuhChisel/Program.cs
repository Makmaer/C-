int num1, num2;
string p;
Console.Write("Vvedite pervoe chislo : ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Vvedite vtoroe chislo : ");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1>num2)
{   p="> ";
}
else 
  if (num1<num2) 
{   p="< ";
}
else 

{   p="= ";
}

Console.WriteLine("pervoe chislo " + p + "vtoroe chislo");