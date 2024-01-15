using System;
using System.Data;
using System.Xml;

namespace final_calisma_demo
{
    class OverridingDemo
    {

        public static void Main()
        {
            Ogrenci ogrenci = new Ogrenci();

            Jandarma jandarma = new Jandarma();

            Yetiskin yetiskin = new Yetiskin();

            ogrenci.Basim();
            jandarma.Basim();
            yetiskin.Basim();


        }

    }

    class Kart
    {
        public virtual void Basim()
        {
            Console.WriteLine("kart basim ucreti 10 tl");
        }
        
    }
    
    class Yetiskin : Kart
    {

    }

    class Ogrenci : Kart
    {
        public override void Basim()
        {
            Console.WriteLine("kart basim ucreti 3 tl");

        }

    }

    class Jandarma : Kart
    {
        public override void Basim()
        {
            Console.WriteLine("kart basimi ucretsiz");
        }
    }
    
}
