//1->Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
}

Console.WriteLine("-------------------------------------------------------------------------");

//2-> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

for (int i = 1; i < 21; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("-------------------------------------------------------------------------");

//3-> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

for (int i = 1; i < 21; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine("-------------------------------------------------------------------------");

//4-> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.

int toplam = 0;

for (int i = 50; i < 151; i++)
{
    toplam += i;
}
Console.WriteLine(toplam);

Console.WriteLine("-------------------------------------------------------------------------");

//5-> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.

int tekToplam = 0;
int ciftToplam = 0;

for (int i = 1; i < 121; i++)
{

    if (i % 2 == 0)
    {
        ciftToplam += i;

    }
    else
    {

        tekToplam += i;
    }
}
Console.WriteLine("Tek sayıların toplamı: " + tekToplam);
Console.WriteLine("Çift sayıların toplamı: " + ciftToplam);