// 2.Verilmiş int Arrayın ən böyük dəyərə sahib elementini tapın
int[] elementler = { 13, 32, 18, 20, 3 };
int a = elementler[0];
for (int i = 1; i < elementler.Length; i++)
{
    if (elementler[i] > a)
    {
        a = elementler[i];
    }
}
Console.WriteLine(a);
