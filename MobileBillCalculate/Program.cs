using System;
using System.Data;

namespace MobileBillCalculate
{
    public class Program
    {

        static void Main(string[] args)
        {
            var peekHourStart = Convert.ToDateTime ("9:00:00 am") ;
            var peekHourEnd = Convert.ToDateTime("10:59:59 pm"); ;
   

            var inputTime = "2019-08-31 08:59:13 am";
            var outputTime = "2019-08-31 09:00:39 am";
            decimal bill = 0;

            DateTime startTime = Convert.ToDateTime(inputTime);
            DateTime endTime = Convert.ToDateTime(outputTime);
            DateTime timeNow = startTime;

            while (timeNow <= endTime)
            {
                decimal rate = (timeNow.Hour >= 9 && timeNow.Hour <= 10 && timeNow.Minute<=59 && timeNow.Second <=59) ? 20 : 30;
                bill = bill + rate;
                Console.WriteLine("{0:HH:mm}, rate: ${1:#,0.00}, bill: ${2:#,0.00}", timeNow, rate, bill);
                timeNow = timeNow.AddSeconds(20);
            }

            Console.WriteLine("Bill: {0:HH:mm:ss tt} to {1:HH:mm::ss tt}, {2:#,0} mins, ${3:#,0.00}", startTime, endTime, (endTime - startTime).TotalMinutes, bill);

            Console.ReadLine();
        }


    }

}
