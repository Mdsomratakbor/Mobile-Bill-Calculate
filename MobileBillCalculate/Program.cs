using System;
using System.Data;

namespace MobileBillCalculate
{
    public class Program
    {

        static void Main(string[] args)
        {
            //DateTime peekHourStart = Convert.ToDateTime ("9:00:00 am") ;
            //DateTime peekHourEnd = Convert.ToDateTime("10:59:59 pm"); ;
            decimal bill = 0;
             
            DateTime startTime = Convert.ToDateTime("2019-08-31 08:59:13 am");
            DateTime endTime = Convert.ToDateTime("2019-08-31 11:00:00 pm");
            DateTime timeNow = startTime;

            while (timeNow <= endTime)
            {
                decimal rate = (timeNow.Hour >= 9 && timeNow.Hour <= 22 && timeNow.Minute<=59 && timeNow.Second <=59) ? 20 : 30;
                bill = bill + rate;

                timeNow = timeNow.AddSeconds(20);
                Console.WriteLine("{0:HH:mm:ss tt}, rate: {1:#,0.00}, bill: {2:#,0.00}", new DateTime(timeNow.Ticks).ToString("hh:mm:ss tt"), rate, bill);
            }

            Console.WriteLine("Bill: {0:HH:mm:ss tt} to {1:HH:mm:ss tt}, {2:#,0} mins, {3:#,0.00} taka", startTime, new DateTime(endTime.Ticks).ToString("hh:mm:ss tt"), (endTime - startTime).TotalMinutes, bill/100);

            Console.ReadLine();
        }


    }

}
