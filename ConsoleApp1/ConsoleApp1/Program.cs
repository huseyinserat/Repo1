// See https://aka.ms/new-console-template for more information



int j = 0;
int toplam = 0;
for (int j = 0; j < 10; j++)
{
    Console.WriteLine("bir sayı giriniz");
    toplam = toplam + j;
    toplam = toplam - j;
   Console.ReadKey();
}