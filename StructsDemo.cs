using System;
using System.Data;
using System.Xml;

namespace final_calisma_demo
{
    class StructsDemo
    {
        public static void Main()
        {
            FirstStruct strct;
            
            //FirstStruct strct2 = new FirstStruct();

            strct.num1 = 85;
            strct.num2 = 48;

            Console.WriteLine(" num1: {0} \n num2: {1}", strct.num1, strct.num2);


            strct.Foo(); // eger struct'in tum veri elemanlarina deger atamasaydim bu Foo fonksiyonunu calistirmayacakti.


        }


    }

    struct FirstStruct
    {
        public int num1;
        public int num2;

        public void Foo()
        {
            Console.WriteLine("Zeynep Alperen");
        }
    }

}
