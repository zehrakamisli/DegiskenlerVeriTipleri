using System;


namespace denemex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b = 8;        //1 byte
            Console.WriteLine("0 ile 255 arası (Tam sayı)"+" "+b);
            sbyte s = 9;       //1 byte
            Console.WriteLine("-128 ile 127 arası(Tam sayı)"+" "+s);

            short s1 = 10;     //2 byte
            Console.WriteLine("-32768 ile 32767 arası (Tam sayı)"+" "+s1);
            ushort s2 = 10;    //2 byte
            Console.WriteLine("0 ile 65535 arası (Tam sayı)" + " "+s2);

            int i = 1;        //4 byte
            int i16 = 2;     //2 byte
            int i32 = 3;     //4 byte
            int i64 = 4;    //8 byte
            Console.WriteLine("-2147483648 ile 2147483648 arası (Tam sayı)" + i+" "+i16 + " " + i32 + " " + i64);

            uint ui = 2;    //4 byte
            Console.WriteLine("0 ile 4294967295 (tam sayı)"+" "+ui);
            long u = 5;      //8 byte
            Console.WriteLine("-9223372036854775808 ile 9223372036854775807 (tam sayı)"+" "+u);
            ulong ul = 8;  //8 byte
            Console.WriteLine("0 ile 18446744073709551615 (tam sayı)"+" "+ul);

            // Reel sayılar
            float f = 5;    //4 byte
            Console.WriteLine("±1.5*10-45, …, ±3.4*1038 (reel sayı)"+" "+f);
            double d = 5;       //8 byte
            Console.WriteLine("±5.0*10-324, …, ±1.7*10308 (reel sayı)"+" "+d);
            decimal c = 5;      //16 byte
            Console.WriteLine("±1.5*10-28, …, ±7.9*1028 (reel sayı)"+" "+c);

            char ch = '2';        //2 byte
            Console.WriteLine("Tek karakter"+ch);
            string abc = "Zehra";   //sınırsız
            Console.WriteLine(abc);

            bool b1 = true;
            bool b2 = false;
            Console.WriteLine(b1+" "+b2);

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = "y";
            object o3 = 5;
            object o4 = 4.3;
            Console.WriteLine(o1+" "+o2+" "+ " " + o3 + " "+o4);

            string str1 = string.Empty;
            Console.WriteLine(str1);
            str1 = "Merhaba";
            string ad = "Zehra";
            string soyad = "Kamışlı";
            string birlestirme = ad + " " + soyad;
            Console.WriteLine(str1);
            Console.WriteLine(birlestirme);

            //İnteger tanımlama
            int integer1 = 5;
            int integer2 = 9;
            int carp = integer1 * integer2;
            Console.WriteLine(carp);    

            //boolean
            bool bool1 = 100 < 2;
            Console.WriteLine(bool1);   
            bool bool2 = 100>2;
            Console.WriteLine(bool2);

            //Değişken Dönüşümleri
            string str20 = "20";
            int int20 = 20;

            string stryenideger=str20+int20.ToString();
            Console.WriteLine(stryenideger);    

            int intyenideger= Convert.ToInt32(str20)+int20;
            Console.WriteLine(intyenideger);    

            //Datetime

            string datetime=DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);
            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);
            string saat = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(saat);
            Console.ReadKey();

        }
    }
}
