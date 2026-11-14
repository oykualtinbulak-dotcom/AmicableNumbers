int toplam1 = 0;
int toplam2= 0;
Console.Write("1.sayıyı giriniz :");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("2.sayıyı giriniz :");
int y = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i < x; i++)
{
    if (x % i == 0)
    {
        toplam1 = toplam1 + i;
    }
}
for (int i = 1; i < y; i++)
{
    if (y % i == 0)
    {
        toplam2 = toplam2 + i;
    }
}
if(x==toplam2 && y==toplam1)
{
    Console.Write("dost sayılardır");
}
else
{
    Console.Write("Dost sayı değiillerdir");
}