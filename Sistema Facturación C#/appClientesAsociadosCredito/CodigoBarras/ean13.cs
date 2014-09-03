using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoBarras
{
    class Ean13
    {
        private Ean13Settings settings;
        private string code;
        private string title;

        public Ean13(string code, string title)
            : this(code, title, new Ean13Settings())
        {
        }

        public Ean13(string code, string title, Ean13Settings settings)
        {
            this.settings = settings;
            this.code = code;
            this.title = title;

            if (!CheckCode(code))
                throw new ArgumentException("Invalid EAN-13 code specified.");
        }

        private bool CheckCode(string code)
        {
            if (code == null || code.Length != 13)
                return false;

            int res;
            foreach (char c in code)
                if (!int.TryParse(c.ToString(), out res))
                    return false;

            char check = (char)('0' + CalculateChecksum(code.Substring(0, 12)));
            return code[12] == check;
        }

        public static int CalculateChecksum(string code)
        {
            if (code == null || code.Length != 12)
                throw new ArgumentException("Code length should be 12, i.e. excluding the checksum digit");

            int sum = 0;
            for (int i = 0; i < 12; i++)
            {
                int v;
                if (!int.TryParse(code[i].ToString(), out v))
                    throw new ArgumentException("Caracter invalido para especificar el código.");
                sum += (i % 2 == 0 ? v : v * 3);
            }
            int check = 10 - (sum % 10);
            return check % 10;
        }
    }
}
