using System;
using System.Globalization;

namespace Datas
{
    class Program
    {
        static void Main(string[] args)
        {

            // DATAS


            Console.Clear();
            var data = new DateTime(); // aqui ele vem com os valores padrões, no caso 01/01/0001 12:00:00
            var data = DateTime.Now; // Para pegar a data atual

            var data = new DateTime(2020, 10, 12, 08, 23, 14); // aqui eu informei todos os valores da data que eu quero
            Console.WriteLine(data.Year);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Day);
            Console.WriteLine(data.Hour);
            Console.WriteLine(data.Minute);
            Console.WriteLine(data.Second);  // Nesses casos eu posso pegar pelo ano, mes, dia, hora, minuto ou segundo se eu quiser

            Console.WriteLine((int)data.DayOfWeek); // aqui ele mostra o 1 na tela, que seria segunda feira

            Console.WriteLine(data.DayOfYear); // aqui ele mostra qual dia do ano é








            // --------------------------------------------------------------------------------------------------------------






            // FORMATAÇÃO DE DATAS


            var data = DateTime.Now;
            Console.WriteLine(data);



            var formato = "";
            var formatada = String.Format("{0:dd/MM/yyyy hh:mm:ss}", data); // Dessa forma ele vai exbir a data completa formatada em português

            /*
            Y = Ano
            M = Mês
            D = Dia

            H = Hora
            m = Minutos
            s = Segundos

            */


            data.AddDays(15); // esse método vai adicionar 15 dias a partir da data da variável data 
            Console.WriteLine(data);




            // --------------------------------------------------------------------------------------------------------------





            // COMPARAÇÃO DE DATAS

            var data = DateTime.Now;

            if (data.Date == DateTime.Now.Date)  // forma correta de comparar datas
            {
                Console.WriteLine("é igual");
            }






            // --------------------------------------------------------------------------------------------------------------





            //GLOBALIZAÇÃO

            var pt = new CultureInfo("pt-PT");
            var br = new CultureInfo("pt-BR");
            var en = new CultureInfo("pt-US");
            var de = new CultureInfo("de-DE");
            var atual = CultureInfo.CurrentCulture; // dessa forma ele pega a cultura da máquina

            Console.WriteLine(DateTime.Now.ToString("D", pt)); // o D serve para que ele exiba a data completa por extenso, e o pt é para selecionar a cultura
            Console.WriteLine(DateTime.Now.ToString("D", de)); // Dessa forma porm exemplo eu estaria exibindo a hora no formato da Dinamarca
            Console.WriteLine(string.Format("{0:D}", DateTime.Now)); // Dessa forma também funcionaria 


            // SERVIDORES MÚLTIPLOS : Em casos que o programa está sendo replicado em vários servidores e não teria como usar o var atual = CultureInfo.CurrentCulture; uso o código abaixo
            var utcDate = DateTime.UtcNow; // aqui ele pega a data e hora base sem aplicar fuso
            Console.WriteLine(DateTime.Now);

            Console.WriteLine(utcDate);

            Console.WriteLine(utcDate.ToLocalTime()); // aqui eu exibo a hora sem o fuso e conserto para o fuso do usuário






            // --------------------------------------------------------------------------------------------------------------





            //PARA PEGAR TODOS OS TIMEZONES DO MUNDO

            var timezones = TimeZoneInfo.GetSystemTimeZones();
            foreach (var timezone in timezones)
            {
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
                Console.WriteLine("----------");

            }





            // --------------------------------------------------------------------------------------------------------------



            //  TIMESPAN

            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);


            var timeSpaneNanoSegundos = new TimeSpan(1);
            Console.WriteLine(timeSpaneNanoSegundos);

            var timeSpaneMinutoSegundo = new TimeSpan(5, 12, 8); // quando se coloca 3 informações então eu exibo hora, minuto e segundo
            Console.WriteLine(timeSpaneMinutoSegundo);




        }
    }
}
