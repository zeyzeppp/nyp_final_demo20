using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Xml;


namespace final_calisma_demo
{

    class ConsDate
    {
        public static void Main()
        {
            Date d1 = new Date();

            d1.Disp();

        }
    }

    class Date
    {
        int day;
        int month;
        int year;

        public Date()
        {
            day = 1;
            month = 9;
            year = 2003;

        }

        public void setDate()
        {
            day = 1;
            month = 9;
            year = 2003;

        }


        public Date(int d, int m, int y)
        {
            day = d;
            month = m;
            year = y;

        }

        public void setDate(int d, int m, int y)
        {
            day = d;
            month = m;
            year = y;

        }

        public void Disp()
        {
            Console.WriteLine("{0}/{1}/{2}", day, month, year);

        }

        
    }

}
