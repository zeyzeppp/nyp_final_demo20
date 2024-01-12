using System;
using System.Data;
using System.Xml;

namespace final_calisma_demo
{

    class EncapsulationDemo
    {
        public static void Main()
        {
            Date1 d = new Date1();

            d.SetDay(1);
            d.SetMonth(9);
            d.SetYear(2003);

            Console.WriteLine("{0}/{1}/{2}", d.GetDay(), d.GetMonth(), d.GetYear());
        }
    }

    class Date1
    {
        private int m_day;
        private int m_month;
        private int m_year;

        public int GetDay()
        {
            return m_day;
            
        }
        public void SetDay(int day)
        {
            m_day = day;

        }

        public int GetMonth()
        {
            return m_month;
        }
        public void SetMonth(int month)
        {
            m_month = month;
        }

        public int GetYear()
        {
            return m_year;
        }
        
        public void SetYear(int year)
        {
            m_year = year;

        }


    }
}
