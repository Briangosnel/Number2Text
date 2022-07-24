using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number2Text
{
    public class Currency
    {
    public string ValueWithCurrency(int value)
        {
            var Number2Text = new Number2Text();
            var RoubleCases = new RoubleCases();
            return Number2Text.Convert(value) + " " + RoubleCases.ConvertPadej(value); ;
        }
    }
}
