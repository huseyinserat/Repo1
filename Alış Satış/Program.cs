using System.Collections.Generic;
using System.Linq;  
using System.Text;
using System.Threading.Tasks;

namespace Alişsatiş
{
    class Program
    {
        static void Main(string [] args)
        {
            double sayi, yüzde, sonuc;
            Console.Write("sayıyı giriniz");
            sayi=Convert.ToDouble(Console.ReadLine());
            Console.Write("yüzdeyi giriniz");
            yüzde=Convert.ToDouble(Console.ReadLine());
            sonuc = sayi * yüzde / 100;
            Console.WriteLine("girilen sayının %{0}'i:{1}",yüzde, sonuc);
            Console.ReadKey();
        }
    }
}