int num1, num2, num3, max;
string p;
Console.Write("Neobhodimo vvesti tri raznih chisla ");

Console.Write("Vvedite pervoe chislo : ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Vvedite vtoroe chislo : ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Vvedite pervoe chislo : ");
num3 = Convert.ToInt32(Console.ReadLine());

max = num1;
if (max>num2)
{   if (max>num3)
    { Console.WriteLine("maksimalnoe chislo= " + max); }
    else 
    {max=num3;
    Console.WriteLine("maksimalnoe chislo= " + max);}
}
else   if (max<num2) 
{  max = num2;
   if (max>num3)
   {Console.WriteLine("maksimalnoe chislo= " + max);}
   else {max = num3;
   Console.WriteLine("maksimalnoe chislo= " + max);}
}
else 

{  Console.WriteLine("vvedeni odinakovie chisla");
}

