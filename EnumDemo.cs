using System;
using System.Data;
using System.Xml;

namespace final_calisma_demo
{
    class EnumDemo
    {
        enum SehirPlakalari
        {
            Ankara  = 6,
            Istanbul = 34,
            Bursa = 16
        }
        
        

        public static void Main()
        {
            //
           
            SehirPlakalari p1 = SehirPlakalari.Ankara;
            SehirPlakalari p2 = SehirPlakalari.Bursa;

            int result = p2 - p1;
            Console.WriteLine(result); // enum turlerinde cıkartma islemi yapılabilir ama toplama islemi yapilamaz.

            Console.WriteLine("{0}", Convert.ToInt32(p1));

            string[] sehirler = Enum.GetNames(typeof(SehirPlakalari));

            foreach (string sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }

            //

            


        }
    }
}
