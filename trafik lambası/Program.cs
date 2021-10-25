using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace trafik
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("trafik lambası renklerinden birini yazınız.");
            string renk = Console.ReadLine();

            switch (renk)
            {
                case "kırmızı":
                    Console.WriteLine("kırmızı ışıkta dur");
                    break;
                case "sarı":
                    Console.WriteLine("sarı ışıkta bekle");
                    break;
                case "yeşil":
                    Console.WriteLine("yeşil ısıkta geç.");
                    break;
                    
                    default:
                    Console.WriteLine("yenlış ışık girdiniz..");
                    break;
                
            }
            Console.ReadKey();
        }
    }
}
