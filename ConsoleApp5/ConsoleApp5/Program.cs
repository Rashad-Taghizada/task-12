// 6.Tam ədədlər ardıcıllığı verilir. Ardıcıllığın hər bir mənfi olmayan elementini 2 vahid artırmalı.
int[] ededler = { -5, 10, 0, -2, 15, 3 };
for (int i = 0; i < ededler.Length; i++)
{
    if (ededler[i] >= 0)
    {
        ededler[i] = ededler[i] + 2;
    }
}
Console.WriteLine(" ardıcıllıq:");
for (int i = 0; i < ededler.Length; i++)
{
    Console.Write(ededler[i] + " ");
}