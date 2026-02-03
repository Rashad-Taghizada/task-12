// 5.Verilmiş n tam ədədinin neçə mərtəbəli olduğunu tapın. Məs: 23452, output: 5   
int n = 23452;
int a = 0;


if (n == 0)
{
    a = 1;
}
else
{
    
    while (n > 0)
    {
        n = n / 10; 
        a++;   
    }
}

Console.WriteLine("Mertebe sayı: " + a);