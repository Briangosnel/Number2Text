using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number2Text
{
    public class RoubleCases
    {
        public string ConvertPadej(int value)
        {
            int div = value % 10;
            int div10 = (value / 10) % 10;

            if (div10 == 1) return "рублей";

            if (div == 0 || div >= 5 && div <= 9) return "рублей";
            if (div == 1) return "рубль";
            if (div >= 2 && div <= 4 && div10 != 1) return "рубля";

            return "";
        }
    }
}
