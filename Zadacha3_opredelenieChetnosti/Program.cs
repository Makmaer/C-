int num1;
string p;
Console.Write("Vvedite chislo : ");
num1 = Convert.ToInt32(Console.ReadLine());

if (num1 % 2 == 0)
{   p="chetnoe ";
}

else 

{   p="nechetnoe ";
}

Console.WriteLine("chislo " + num1 + " " + p);