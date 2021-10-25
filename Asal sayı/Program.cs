using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;



namespace AsalSayı
{
    class Program
    {
        static void Main(string[] vs)
        {
            int sayi;
            Console.WriteLine("sayıyı giriniz");
            sayi=Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <= sayi; i++)
            {
                if (sayi % 2 == 0)
                {
                   
                  
                     Console.WriteLine("girdiğniz{0} sayısı asal sayıdır.", sayi);
                    }
                    else
                    {
                        Console.WriteLine("girdiginiz{0} sayısı asal değildir", sayi);
                    }
                    Console.ReadKey();
                }

            }
           
        }
    }
