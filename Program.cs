    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genel_ödev_6
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Birinci kenar uzunluğunu giriniz: ");
            int kenar1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci kenar uzunluğunu giriniz: ");
            int kenar2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Üçüncü kenar uzunluğunu giriniz: ");
            int kenar3 = Convert.ToInt32(Console.ReadLine());

            if (kenar1 == kenar2 && kenar2 == kenar3)
            {
                Console.WriteLine("Bu bir eşkenar üçgendir.");
            }
            else if (kenar1 == kenar2 || kenar1 == kenar3 || kenar2 == kenar3)
            {
                Console.WriteLine("Bu bir ikizkenar üçgendir.");
            }
            else
            {
                Console.WriteLine("Bu bir çeşitkenar üçgendir.");
            }
            Console.ReadKey();
        }

       
        
    }
}
