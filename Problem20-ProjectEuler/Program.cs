
using System.Numerics;

BigInteger value = 1;

for(int i = 100; i > 0; i--)
{
    value = value * i;
}

char[] resultDigits = value.ToString().ToCharArray();
double sum = 0;

foreach(char c in resultDigits)
{
    sum = sum + Convert.ToInt32(c.ToString());
}

Console.WriteLine("The sum of the digits in the number 100! is: " + sum);

