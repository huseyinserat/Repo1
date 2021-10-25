using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace mod
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            int sayi1, sayi2, sonuc;
            Console.Write("birinci sayıyı giriniz");
            sayi1 =Convert.ToInt32(Console.ReadLine());
            Console.Write("ikinci sayıyı giriniz");
            sayi2=Convert.ToInt32(Console.ReadLine());

            sonuc = sayi1 % sayi2;
             Console.Write(sayi1 + "sayısının"+sayi2 + "Sayısına bölümünden kalan "+ sonuc);
            Console.ReadKey();
        }
    }
}