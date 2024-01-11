using System;
using System.Data;
using System.Xml;

namespace final_calisma_demo
{
    class stringDemo
    {
        public static void Main()
        {

            string z;
            Console.Write("Bir isim giriniz: ");
            z = Console.ReadLine();

            //Console.WriteLine("{0}", z.Length);

            for(int i = z.Length - 1; i >= 0; i--)
            {
                Console.Write(z[i]);
            }


            String a = new String('z', 5);
            Console.WriteLine(a);


        }
        


    }
}
}
