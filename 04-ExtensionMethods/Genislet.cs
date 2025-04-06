using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ExtensionMethods
{
    internal static class Genislet
    {
        public static int KareAl(this int sayi)
        {
            return sayi * sayi;
        }

        public static int KupAl(this int sayi)
        {
            return sayi * sayi * sayi;
        }

        public static int IkiyeBol(this int sayi)
        {
            return sayi / 2;
        }

        public static int SayiIleCarp(this int sayi, int carpilacakSayi)
        {
            return sayi * carpilacakSayi;
        }
    }
}
