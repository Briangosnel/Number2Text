using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number2Text
{
    public class Number2Text
    {

        public string Convert(int value)
        {
           // char[] numstr = value.ToString().ToCharArray();
            // char div = ((char)(value % (int)(Math.Pow(10, 1)).ToString()[0]));
            char div = (char)(value % 10);
            char div10 = (char)(((value - (value % 10) ) / 10));
            char div100 = (char)(((value - (value % 100)) / 100));
            char div1000 = (char)(((value - (value % 1000)) / 1000));
            char div1002 =(char) (div1000 % 10);
            char div100000 = (char)(((value - (value % 100000)) / 100000));
            char divM = (char)(((value - (value % 1000000)) / 1000000));
            char divM2 = (char)(divM % 10);
            char div100M = (char)(((value - (value % 100000000)) / 100000000));
            //     string result = "";
            if (value >= 0 && value <= 9)
            {
                return Convert1(div);
            }
            if (value >= 10 && value <= 99)
            {
                return Convert2(value, div10, div);
            }
            if (value >= 100 && value <= 999)
            {
                return Convert3(value, div100);
                
            }
            if (value >= 1000 && value <= 9999)
            {
                return Convert4(value, div1000);
            }
            if (value >= 10000 && value <= 99999)
            {
                return Convert5(value, div1000, div1002);
            }
            if (value >= 100000 && value <= 999999)
            {
                return Convert6(value, div100000);
            }
            if (value >= 1000000 && value <= 9999999)
            {
                return Convert7(value, divM);
            }
            if (value >= 10000000 && value <= 99999999)
            {
                return Convert8(value, divM, divM2);
            }
            if (value >= 100000000 && value <= 999999999)
            {
                return Convert9(value, div100M);
            }

            return "";
        }


        public static string Convert1(int div)
        {
            string result = "";
            switch (div)
            {
                case 0: result += "ноль"; break;
                case 1: result += "один"; break;
                case 2: result += "два"; break;
                case 3: result += "три"; break;
                case 4: result += "четыре"; break;
                case 5: result += "пять"; break;
                case 6: result += "шесть"; break;
                case 7: result += "семь"; break;
                case 8: result += "восемь"; break;
                case 9: result += "девять"; break;
            }
            return result;
        }
        public static string Convert2(int value, char div10, char div)
        {
            if (value == 10) return "десять";
            if (value == 11) return "одиннадцать";
            if (value == 12) return "двенадцать";
            if (value == 13) return "тринадцать";
            if (value == 14) return "четырнадцать";
            if (value == 15) return "пятнадцать";
            if (value == 16) return "шестнадцать";
            if (value == 17) return "семнадцать";
            if (value == 18) return "восемнадцать";
            if (value == 19) return "девятнадцать";
            if (value >= 20 && value <= 39)
            {
                if (value % 10 == 0) return Convert1(div10) + "цать";
                return Convert1(div10) + "дцать " + Convert1(div);
            }
            if (value >= 40 && value <= 49)
            {
                if (value % 10 == 0) return "сорок";
                return "сорок " + Convert1(div);
            }
            if (value >= 50 && value <= 89)
            {
                if (value % 10 == 0) return Convert1(div10) + "десят";
                return Convert1(div10) + "десят " + Convert1(div);
            }
            if (value <= 99 && value >= 90)
            {
                if (value % 10 == 0) return "девяносто";
                return "девяносто " + Convert1(div); ;
            }
            return "";
        }

        public string Convert3(int value, char div100)
        {
            if (value >= 100 && value <= 199)
            {
                if (value % 100 == 0) return "сто";
                return "сто " + Convert(value % 100);
            }
            if (value >= 200 && value <= 299)
            {
                if (value % 100 == 0) return "двести";
                return "двести " + Convert(value % 100);
            }
            if (value >= 300 && value <= 399)
            {
                if (value % 100 == 0) return "триста";
                return "триста " + Convert(value % 100);
            }
            if (value >= 400 && value <= 499)
            {
                if (value % 100 == 0) return "четыреста";
                return "четыреста " + Convert(value % 100);
            }
            if (value >= 500 && value <= 999)
            {
                if (value % 100 == 0) return Convert(div100) + "сот";
                return Convert(div100) + "сот " + Convert(value % 100);
            }
            return "";
        }
        public string Convert4(int value, char div1000)
        {
            if (div1000 == 1)
            {
                if (value % 1000 == 0) return "одна тысяча";
                return "одна тысяча " + Convert(value % 1000);
            }
            if (div1000 == 2)
            {
                if (value % 1000 == 0) return "две тысячи";
                return "две тысячи " + Convert(value % 1000);
            }
            if (div1000 >= 3 && div1000 <= 4)
            {
                if (value % 1000 == 0) return Convert(div1000) + " тысячи";
                return Convert(div1000) + " тысячи " + Convert(value % 1000);
            }
            if (div1000 >= 5 && div1000 <= 9)
            {
                if (value % 1000 == 0) return Convert(div1000) + " тысяч";
                return Convert(div1000) + " тысяч " + Convert(value % 1000);
            }
            return "";
        }
        public string Convert5(int value, char div1000, char div1002)
        {
            if (div1000 >= 10 && div1000 <= 20)
            {
                if (value % 1000 == 0) return Convert(div1000) + " тысяч";
                return Convert(div1000) + " тысяч " + Convert(value % 1000);
            }
            else
            {
                if (value % 10000 == 0) return Convert(div1000) + " тысяч";
                if (value % 1000 == 0) return Convert(div1000 - div1002) + " " + Convert(value % 10000); 
                if (div1000 % 10 == 0) return Convert(div1000 - div1002) + " тысяч " + Convert(value % 10000);
                return Convert(div1000 - div1002) + " " + Convert(value % 10000);
            }
        }

        public string Convert6(int value, char div100000)
        {
            if (value % 100000 == 0)
            {
                return Convert(div100000 * 100) + " тысяч";
            }
            else
            {
                return Convert(div100000 * 100) + " " + Convert(value % 100000);
            }
        }
        public string Convert7(int value, char divM)
        {
            if (divM == 1)
            {
                if (value % 1000000 == 0)
                {
                    return Convert(divM) + " миллион";
                }
            }
            if (divM >= 2 && divM <= 4)
            {
                if (value % 1000000 == 0) return Convert(divM) + " миллиона";
                return Convert(divM) + " миллиона " + Convert(value % 1000000);
            }
            if (divM >= 5 && divM <= 9)
            {
                if (value % 1000000 == 0) return Convert(divM) + " миллионов";
                return Convert(divM) + " миллионов " + Convert(value % 1000000);
            }
            return "";
        }
        public string Convert8(int value, char divM, char divM2) 
        {
            if (divM >= 10 && divM <= 20)
            {
                if (value % 1000000 == 0) return Convert(divM) + " миллионов";
                return Convert(divM) + " миллионов " + Convert(value % 1000000);
            }
            else
            {
                if(value % 10000000 == 0) return Convert(divM) + " миллионов";
                if (value % 1000000 == 0) return Convert(divM - divM2) + " " + Convert(value % 10000000);
                if (divM % 10 == 0) return Convert(divM - divM2) + " миллионов " + Convert(value % 10000000);
                return Convert(divM - divM2) + " " + Convert(value % 10000000);
            }
        }
        public string Convert9(int value, char div100M)
        {
            if (value % 100000000 == 0)
            {
                return Convert(div100M * 100) + " миллионов";
            }
            else
            {
                return Convert(div100M * 100) + " " + Convert(value % 100000000);
            }
        }
        }
        }
    