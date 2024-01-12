using System;
using System.Data;
using System.Xml;

namespace final_calisma_demo
{
    class PropertiesGetSet
    {
        public static void Main()
        {

            // demo property


            Manager m = new Manager();

            m.A = 5; //set
            int yas = m.A; //get

            Console.WriteLine("{0}", yas);



            // automatic property

            Employee e = new Employee();

            e.Emp = "Zeynep";
            string name = e.Emp;

            Console.WriteLine("{0}", name);


            // static property

            /*
            
            Clients c = new Clients() ------> ERROR !!!;

            STATIC: Static means, something which cannot be instantiated, you cannot create an object of a static class
            and cannot access static members using an object.

            */




            Clients.Cli = 1415;
            int musteri_sayisi = Clients.Cli;

            Console.WriteLine("{0}", musteri_sayisi);
            

        }
    }

    class Manager
    {
        // demo property



        public int A
        {
            get;
            set;
        }
        
        

    }

    
    class Employee
    {
        // automatic property

        private string m_name;

        public string Emp
        {
            get
            {
                return m_name;
            }
            set
            {
                m_name = value;
            }
        }

    }

    
    class Clients
    {
        // static property

        private static int m_sayi;

        public static int Cli
        {
            get
            {
                return m_sayi;
            }
            set
            {
                m_sayi = value;
            }
        }
    }
    

}
