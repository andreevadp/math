int a = 5;
int b = 7;
int max;
int min;
if (a > b)
{ 
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}
Console.WriteLine("Max number "+max);
Console.WriteLine("Min number "+min);