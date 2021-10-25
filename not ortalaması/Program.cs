using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Notortalaması
{
    class Program
    {
        static void Main(string[] args)
        {
            double vizenotu, finalnotu, ortalama;
            Console.Write("vize notunu giriniz");
            vizenotu = Convert.ToDouble(Console.ReadLine());
            Console.Write("final notunu giriniz");
            finalnotu = Convert.ToDouble(Console.ReadLine());
            ortalama = vizenotu * 0.4 + finalnotu * 0.6;
            if (ortalama > 84 && ortalama < 100)
            {
                Console.WriteLine("AA aldınız");
            }
            if(ortalama >69 && ortalama <= 84)
            {
                Console.WriteLine("BB");
            }
            if(ortalama>54 && ortalama <= 69)
            {
                Console.WriteLine("CC");
            }
            if(ortalama >44 && ortalama < 54)
            {
                Console.WriteLine("DD");
            }
            if(ortalama>0 && ortalama <=44)
            {
                Console.WriteLine("FF","Kaldınız");
            }
            Console.ReadKey();
        }
    }
}
        
       
        
      