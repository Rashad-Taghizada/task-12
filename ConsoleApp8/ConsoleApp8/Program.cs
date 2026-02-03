//9. Verilmiş massivin ən kiçik elementini çıxışa verən proqram yazın
int[] ededler = { 13, 32, 18, 20, 3, 45 };
int enKicik = ededler[0];
for (int i = 1; i < ededler.Length; i++)
{
    if (ededler[i] < enKicik)
    {
        enKicik = ededler[i];
    }
}

Console.WriteLine("En kicik element: " + enKicik);
