using System;
using System.Globalization;

namespace MyAppDataHours
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //var data = new DateTime(2020, 10, 12, 8, 23, 14);
            var data = DateTime.Now;

            /*var formato = String.Format("{0: dd/MM/yyyy}", data);
            var formato_data = String.Format("{0:d}", data);
            Console.WriteLine(formato);
            Console.WriteLine(formato_data);
            */

            /*
            Console.WriteLine(data.AddDays(21));  //Preferir assim para adicionar datas caraí          
            Console.WriteLine(data.AddMonths(1));
            Console.WriteLine(data.AddYears(2));
            */

            // COMPARAÇÃO DE DATAS
            /*
            if (data.Date == DateTime.Now.Date)
            {
                Console.WriteLine("É igual");
            } else
            {
                Console.WriteLine("É diferente");
            }

            Console.WriteLine(data);
            */

            /*var pt = new CultureInfo("pt-PT");
            var br = new CultureInfo("pt-BR");
            var en = new CultureInfo("pt-EN");
            var de = new CultureInfo("pt-DE");
            var atual = CultureInfo.CurrentCulture; // PEGAR DATA DO MÁQUINA ATUAL

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.ToString("D", pt));
            */

            /*
            var utcDate = DateTime.UtcNow; // HORÁRIO GLOBAL DO SERVIDOR
            Console.WriteLine(utcDate);
            Console.WriteLine(utcDate.ToLocalTime()); // PEGAR A HORA LOCAL DO USUÁRIO CONECTADO

            var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            Console.WriteLine(timezoneAustralia);

            var horaAustralia =
                TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia);
            Console.WriteLine(horaAustralia);
            
            var timezones = TimeZoneInfo.GetSystemTimeZones(); // pegar todos os time zone info
            foreach (var timezone in timezones)
            {
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone);
                Console.WriteLine("______________");
            }*/

            /*var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);

            var timeSpanNano = new TimeSpan(1);
            Console.WriteLine(timeSpanNano);

            var timeSpanHoraMinuto = new TimeSpan(5, 12, 8);
            Console.WriteLine(timeSpanHoraMinuto);
            */

            //QUANTOS DIAS TEM UM MÊS NO ANO ESPECÍFICO
            Console.WriteLine(DateTime.DaysInMonth(2020, 2));
            Console.WriteLine(DateTime.DaysInMonth(2021, 2));

            // SE É FINAL DE SEMANA OU NÃO
            static bool IsWeekDay(DayOfWeek today)
            {
                return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
            }
            Console.WriteLine(IsWeekDay(DateTime.Now.DayOfWeek));

            // SE ESTÁ OU NÃO NO HORÁRIO DE VERÃO
            Console.WriteLine(DateTime.Now.IsDaylightSavingTime());
        }
    }
}
