using System;

namespace Conversions
{
    public static class CBase
    {
        public static int BinADec(string binaire)
        {
            int deciml = 0;
            char[] chiffres = binaire.ToCharArray();
            for (int chiffreIdx = 0; chiffreIdx < chiffres.Length; chiffreIdx++)
            {
                char chiffre = chiffres[chiffreIdx];
                if (chiffre == '1')
                {
                    deciml += (int)Math.Pow(2, (chiffres.Length - 1 - chiffreIdx));
                }
            }
            return deciml;
        }

        public static string DecABin(int deciml)
        {
            string binaire = null;
            while (deciml > 0)
            {
                binaire = $"{deciml % 2}{binaire}";
                deciml /= 2;
            }
            return binaire;
        }

        public static int HexADec(string hexa)
        {
            int deciml = 0;
            char[] chiffres = hexa.ToCharArray();
            for (int chiffreIdx = 0; chiffreIdx < chiffres.Length; chiffreIdx++)
            {
                char chiffre = chiffres[chiffreIdx];
                if (chiffre >= '0' && chiffre <= '9')
                {
                    deciml += (int)Math.Pow(16, (chiffres.Length - 1 - chiffreIdx)) * int.Parse(chiffre.ToString());
                }
                else if (chiffre >= 'A' && chiffre <= 'F')
                {
                    deciml += (int)Math.Pow(16, (chiffres.Length - 1 - chiffreIdx)) * (10 + (int)chiffre - (int)'A');
                }
            }
            return deciml;
        }

        public static string DecAHex(int deciml)
        {
            string hexa = null;
            while (deciml > 0)
            {
                int reste = deciml % 16;
                if (reste < 10)
                {
                    hexa = $"{reste}{hexa}";
                }
                else
                {
                    hexa = $"{(char)((int)'A' + reste - 10)}{hexa}";
                }
                deciml /= 16;
            }
            return hexa;
        }

        public static string BinAHex(string binaire)
        {
            return DecAHex(BinADec(binaire));
        }

        public static string HexABin(string hexa)
        {
            return DecABin(HexADec(hexa));
        }
    }
}
