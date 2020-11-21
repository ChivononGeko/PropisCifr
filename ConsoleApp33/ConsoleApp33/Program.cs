using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace l4t38

{

    /*

    * В классе Program создайте публичный статический метод GetIntAsString(), который принимает 1 целое число и возвращает строку:

    * 1) Если число от 1 до 9999 включительно – словесную форму полученного числа (Например: один (1), пятнадцать(15), одна тысяча девятьсот девяносто девять (1999))

    * 2) Если меньше 1 - "Слишком маленькое число".

    * 3) Если больше 9999 - "Слишком большое число".

    */

    public class Program

    {

        public static void Main(string[] args)

        {
            GetIntAsString(Console.ReadLine());
        }

        /* Добавьте свой код ниже */
        public static void GetIntAsString(string a)
        {
            do
            {
                if (int.Parse(a) < 1)
                {
                    Console.WriteLine("Слишком маленькое число. Пожалуйста, повторите попытку");
                     GetIntAsString(Console.ReadLine());
                }
                else if (int.Parse(a) > 9999)
                {
                    Console.WriteLine("Слишком большое число. Пожалуйста, повторите попытку");
                    GetIntAsString(Console.ReadLine());
                }
                else
                {
                    int n = int.Parse(a);
                    int edi = int.Parse(a) % 10;
                    if (n / 10 > 0)
                    {
                        n = n / 10;
                        int des = n % 10;

                        if (des == 1)
                        {
                            if (n / 10 > 0)
                            {
                                n = n / 10;
                                int sot = n % 10;

                                if (n / 10 > 0)
                                {
                                    n = n / 10;
                                    int tis = n % 10;

                                    Console.WriteLine(Tis(tis) + " " + Sot(sot) + " " + DesO(edi));
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine(Sot(sot) + " " + DesO(edi));
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine(DesO(edi));
                                break;
                            }
                        }
                        else
                        {

                            if (n / 10 > 0)
                            {
                                n = n / 10;
                                int sot = n % 10;

                                if (n / 10 > 0)
                                {
                                    n = n / 10;
                                    int tis = n % 10;

                                    Console.WriteLine(Tis(tis) + " " + Sot(sot) + " " + Des(des) + " " + Ed(edi));
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine(Sot(sot) + " " + Des(des) + " " + Ed(edi));
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine(Des(des) + " " + Ed(edi));
                                break;
                            }
                        }



                    }
                    else
                    {
                        Console.WriteLine(Ed(edi));
                        break;
                    }
                }
            }
            while (int.Parse(a) > 0 && int.Parse(a) < 10000);
        }
        public static string Ed(int edi)
        {
            if (edi == int.Parse("1"))
            {
                return "Один";
            }
            else if (edi == int.Parse("2"))
            {
                return "Два";
            }
            else if (edi == int.Parse("3"))
            {
                return "Три";
            }
            else if (edi == int.Parse("4"))
            {
                return "Четыре";
            }
            else if (edi == int.Parse("5"))
            {
                return "Пять";
            }
            else if (edi == int.Parse("6"))
            {
                return "Шесть";
            }
            else if (edi == int.Parse("7"))
            {
                return "Семь";
            }
            else if (edi == int.Parse("8"))
            {
                return "Восемь";
            }
            else if (edi == int.Parse("9"))
            {
                return "Девять";
            }
            else
            {
                return "";
            }
        }
        public static string DesO(int edi)
        {
            if (edi == int.Parse("0"))
            {
                return "Десять";
            }
            else if (edi == int.Parse("1"))
            {
                return "Одинадцать";
            }
            else if (edi == int.Parse("2"))
            {
                return "Двенадцать";
            }
            else if (edi == int.Parse("3"))
            {
                return "Тринадцать";
            }
            else if (edi == int.Parse("4"))
            {
                return "Четырнадцать";
            }
            else if (edi == int.Parse("5"))
            {
                return "Пятнадцать";
            }
            else if (edi == int.Parse("6"))
            {
                return "Шестьнадцать";
            }
            else if (edi == int.Parse("7"))
            {
                return "Семьнадцать";
            }
            else if (edi == int.Parse("8"))
            {
                return "Восемнадцать";
            }
            else
            {
                return "Девятнадцать";
            }
        }
        public static string Des(int edi)
        {
          
            if (edi == int.Parse("2"))
            {
                return "Двадцать";
            }
            else if (edi == int.Parse("3"))
            {
                return "Тридцать";
            }
            else if (edi == int.Parse("4"))
            {
                return "Сорок";
            }
            else if (edi == int.Parse("5"))
            {
                return "Пятьдесят";
            }
            else if (edi == int.Parse("6"))
            {
                return "Шестьдесят";
            }
            else if (edi == int.Parse("7"))
            {
                return "Семьдесят";
            }
            else if (edi == int.Parse("8"))
            {
                return "Восемьдесят";
            }
            else if(edi == int.Parse("9"))
            {
                return "Девяносто";
            }
            else
            {
                return "";
            }
        }
        public static string Sot(int edi)
        {    
            if (edi == int.Parse("1"))
            {
                return "Сто";
            }
            else if (edi == int.Parse("2"))
            {
                return "Двести";
            }
            else if (edi == int.Parse("3"))
            {
                return "Триста";
            }
            else if (edi == int.Parse("4"))
            {
                return "Четыреста";
            }
            else if (edi == int.Parse("5"))
            {
                return "Пятьсот";
            }
            else if (edi == int.Parse("6"))
            {
                return "Шестьсот";
            }
            else if (edi == int.Parse("7"))
            {
                return "Семьсот";
            }
            else if (edi == int.Parse("8"))
            {
                return "Восемьсот";
            }
            else if(edi == int.Parse("9"))
            {
                return "Девятьсот";
            }
            else
            {
                return "";
            }
        }
        public static string Tis(int edi)
        {
            if (edi == int.Parse("1"))
            {
                return "Тысяца";
            }
            else if (edi == int.Parse("2"))
            {
                return "Две тысячи";
            }
            else if (edi == int.Parse("3"))
            {
                return "Три тысячи";
            }
            else if (edi == int.Parse("4"))
            {
                return "Четыре тысячи";
            }
            else if (edi == int.Parse("5"))
            {
                return "Пять тысяч";
            }
            else if (edi == int.Parse("6"))
            {
                return "Шесть тысяч";
            }
            else if (edi == int.Parse("7"))
            {
                return "Семь тысяч";
            }
            else if (edi == int.Parse("8"))
            {
                return "Восемь тысяч";
            }
            else 
            {
                return "Девять тысяч";
            }
        }

    }

}