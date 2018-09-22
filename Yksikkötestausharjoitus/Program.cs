using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yksikkötestausharjoitus
{
    public class Program
    {
        static void Main(string[] args)
        {

            string hetu ="041085-072W";
            
            Console.WriteLine(HeTuOk(hetu));
        }

        public static bool HeTuOk(string hetu)
        {
            string pvm;
            char välimerkki;
            string numero;
            char tarkistusmerkki;
            string tMerkit = "0123456789ABCDEFHJKLMNPRSTUVWXY";

            hetu = hetu.Trim();

            if (hetu.Length != 11) { return false; }

            pvm = hetu.Substring(0, 6);
            välimerkki = hetu[6];
            numero = hetu.Substring(7, 3);
            tarkistusmerkki = hetu[10];

            int i = 0;
            if (!int.TryParse(numero, out i)) { return false; }

            if (välimerkki != '-' && välimerkki != '+' && välimerkki != 'A')
            {
                return false;
            }

            if (!int.TryParse(numero, out i)) { return false; }
            i = int.Parse(pvm + numero) % 31;
            if (tMerkit[i] != tarkistusmerkki)
            {
                return false;
            }
            return true;
        }
    }
}
