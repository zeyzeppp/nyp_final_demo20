using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace final_calisma_demo
{
    class StringMethods
    {
        public static void Main()
        {
            // SubString Metodu

            string s = "zeynep alperen";

            string x = s.Substring(7);

            Console.WriteLine("{0}", x);

            string y = s.Substring(3, 7);

            Console.WriteLine("{0}", y);


            // IndexOf Metodu

            string name, text;
            
            name = "Zeynep Alperen";

            int number = name.IndexOf("e");

            Console.WriteLine("{0}", number);

            int number2 = name.IndexOf("e", 7);

            Console.WriteLine("{0}", number2);

            text = "bu sepette 2 elma vardir.";

            int number3 = text.IndexOf("elma");

            Console.WriteLine("{0}", number3);


            // Remove  Metodu

            string sehir = "Ankara";

            string rm = sehir.Remove(2);

            Console.WriteLine("{0}", rm);

            string rm1 = sehir.Remove(2, 3);

            Console.WriteLine("{0}", rm1);

            // Insert Metodu

            string takim = "fener";

            string new_takim = takim.Insert(5, "bahce");

            Console.WriteLine("{0}", new_takim);


            // Replace Metodu

            string text1 = "benim adim Zeynep Alperen";

            string text2 = text1.Replace("Zeynep", "Beyza");

            Console.WriteLine("{0}", text2);
        }
    }
}
