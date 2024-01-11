using System;
using System.Data;
using System.Xml;


namespace final_calisma_demo
{

    class Constructors
    {

        public static void Main1()
        {
            Demo d = new Demo();
            //Demo d2 = new Demo(5, 8);



            d.Disp();


            //Console.WriteLine("{0}, {1}", d, d2);
            
            Console.ReadLine();

        }

    }

    class Demo
    {
        int a;
        int b;

        public Demo()
        {
            Console.WriteLine("Default Constructor");

        }

        public Demo(int x, int y)
        {
            a = x;
            b = y;

            Console.WriteLine("a: {0}, b: {1}, constructor", a, b);
        }

        public void Disp()
        {
            Console.WriteLine("a: {0}, b: {1}, constructor", a, b);
        }
    }
}
