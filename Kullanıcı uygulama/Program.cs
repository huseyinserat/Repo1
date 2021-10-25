using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kullanıcı
{
    public class Program
    {
        static void Main(string[] args)
        {
            string Kullanıcıİd, Şifre;
            Console.Write("kullanıcı İd giriniz");
            Kullanıcıİd = Console.ReadLine();
            Console.Write("şifrenizi giriniz");
            Şifre = Console.ReadLine();

            if(Kullanıcıİd =="yönetici" &&Şifre == "1791657z")
            {
                Console.Write("Giriş başarılı");

            }
            else
            {
                Console.Write("Kullanıcı İd Veya Şifre yanlış");
            }
            Console.ReadKey();
        }
    }
}