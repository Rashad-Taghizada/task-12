// See\Verilmiş array-da müəyyən bir elementin neçə dəfə təkrarlandığını tapın.
//Məsələn: [1, 2, 3, 2, 4, 2], axtarış: 2 → Çıxış: 3
int[] ededler = { 1, 2, 3, 2, 4, 2 };
int axtaris = 2;
int saygac = 0;
for (int i = 0; i < ededler.Length; i++)
{
    if (ededler[i] == axtaris)
    {
        saygac++;
    }
}
Console.WriteLine("Tekrar say: " + saygac);
