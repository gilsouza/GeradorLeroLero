using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeLerolero
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var range = random.NextDouble();
            var dateStart = DateTime.ParseExact("10-06-2015 02:22:01,001", "dd-MM-yyyy HH:mm:ss,fff", System.Globalization.CultureInfo.InvariantCulture); //new DateTime(2015, 6, 10, 2, 22, 1); 
            var dateEnd = DateTime.ParseExact("11-06-2015 18:35:01,035", "dd-MM-yyyy HH:mm:ss,fff", System.Globalization.CultureInfo.InvariantCulture); ; //new DateTime(2015, 6, 11, 18, 35, 0);
            var nSamples = 97138;
            var secondsInterval = 1;
            var mac = "00 13 42 00 40 B2 EF B0";

            var j = 0.0;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Gilmar\Desktop\data\tests.data"))
            {   
                var date = dateStart;

                for (int i = 0; i < nSamples; i++, date = date.AddSeconds(secondsInterval).AddMilliseconds(46)) // * (range > 0 ? range * 1.1 : 1)))
                {
                    range = random.NextDouble();

                    var watt = 2.8;
                    var volt = (double)random.Next(120,130);
                    var amper = (watt / volt);
                    var kwh = (watt * (date - dateStart).Hours) / 1000;
                    var kw = (volt * amper) / 1000;

                    j += kwh;

                    file.WriteLine(String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}", mac, kw, kwh, j / i, amper, volt, date.ToString("dd/MM/yyyy HH:mm:ss")));
                }
            }

            j = 0.0;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Gilmar\Desktop\data\consumo_medio_tomada1.data"))
            {
                var date = dateStart;

                for (int i = 0; i < nSamples; i++, date = date.AddSeconds(secondsInterval).AddMilliseconds(46)) // * (range > 0 ? range * 1.1 : 1)))
                {
                    range = random.NextDouble();

                    var watt = 2.8;
                    var volt = (double)random.Next(120, 130);
                    var amper = (watt / volt);
                    var kwh = (watt * (date - dateStart).Hours) / 1000;
                    var kw = (volt * amper) / 1000;

                    j += kwh;

                    file.WriteLine(String.Format("{0}|{1}", mac, j / i));
                }
            }

            j = 0.0;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Gilmar\Desktop\data\consumo_medio_tomada2.data"))
            {
                var date = dateStart;

                for (int i = 0; i < nSamples; i++, date = date.AddSeconds(secondsInterval).AddMilliseconds(46)) // * (range > 0 ? range * 1.1 : 1)))
                {
                    range = random.NextDouble();

                    var watt = 2.8;
                    var volt = (double)random.Next(120, 130);
                    var amper = (watt / volt);
                    var kwh = (watt * (date - dateStart).Hours) / 1000;
                    var kw = (volt * amper) / 1000;

                    j += kwh;    
                }

                file.WriteLine(String.Format("{0}|{1}", mac, j));
            }

            j = 0.0;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Gilmar\Desktop\data\consumo_medio_residencia1.data"))
            {
                var date = dateStart;

                for (int i = 0; i < nSamples; i++, date = date.AddSeconds(secondsInterval).AddMilliseconds(46)) // * (range > 0 ? range * 1.1 : 1)))
                {
                    range = random.NextDouble();

                    var watt = 2.8;
                    var volt = (double)random.Next(120, 130);
                    var amper = (watt / volt);
                    var kwh = (watt * (date - dateStart).Hours) / 1000;
                    var kw = (volt * amper) / 1000;

                    j += kwh;

                    file.WriteLine(String.Format("{0}|{1}", j / i, date.ToString("dd/MM/yyyy HH:mm:ss")));
                }
            }

            j = 0.0;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Gilmar\Desktop\data\consumo_medio_residencia2.data"))
            {
                var date = dateStart;

                for (int i = 0; i < nSamples; i++, date = date.AddSeconds(secondsInterval).AddMilliseconds(46)) // * (range > 0 ? range * 1.1 : 1)))
                {
                    range = random.NextDouble();

                    var watt = 2.8;
                    var volt = (double)random.Next(120, 130);
                    var amper = (watt / volt);
                    var kwh = (watt * (date - dateStart).Hours) / 1000;
                    var kw = (volt * amper) / 1000;

                    j += kwh;

                    file.WriteLine(String.Format("{0}|{1}", j / i, date.ToString("HH:mm:ss")));
                }
            }

            j = 0.0;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Gilmar\Desktop\data\tempo_indisponibilidade.data"))
            {
                var date = dateStart;

                for (int i = 0; i < nSamples; i++, date = date.AddSeconds(secondsInterval).AddMilliseconds(46)) // * (range > 0 ? range * 1.1 : 1)))
                {
                    range = random.NextDouble();

                    var watt = 2.8;
                    var volt = (double)random.Next(120, 130);
                    var amper = (watt / volt);
                    var kwh = (watt * (date - dateStart).Hours) / 1000;
                    var kw = (volt * amper) / 1000;

                    j += kwh;

                    file.WriteLine(String.Format("{0}|{1}", 0, date.ToString("dd/MM/yyyy")));
                }
            }

            j = 0.0;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Gilmar\Desktop\data\pico_consumo_dia.data"))
            {
                var date = dateStart;

                for (int i = 0; i < nSamples; i++, date = date.AddSeconds(secondsInterval).AddMilliseconds(46)) // * (range > 0 ? range * 1.1 : 1)))
                {
                    range = random.NextDouble();

                    var watt = 2.8;
                    var volt = (double)random.Next(120, 130);
                    var amper = (watt / volt);
                    var kwh = (watt * (date - dateStart).Hours) / 1000;
                    var kw = (volt * amper) / 1000;

                    j += kwh;

                    file.WriteLine(String.Format("{0}|{1}", kw, date.ToString("dd/MM/yyyy HH:mm:ss")));
                }
            }

            j = 0.0;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Gilmar\Desktop\data\pico_consumo_horario.data"))
            {
                var date = dateStart;

                for (int i = 0; i < nSamples; i++, date = date.AddSeconds(secondsInterval).AddMilliseconds(46)) // * (range > 0 ? range * 1.1 : 1)))
                {
                    range = random.NextDouble();

                    var watt = 2.8;
                    var volt = (double)random.Next(120, 130);
                    var amper = (watt / volt);
                    var kwh = (watt * (date - dateStart).Hours) / 1000;
                    var kw = (volt * amper) / 1000;

                    j += kwh;

                    file.WriteLine(String.Format("{0}|{1}", kw, date.ToString("HH:mm:ss")));
                }
            }

            j = 0.0;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Gilmar\Desktop\data\consumo_dia.data"))
            {
                var date = dateStart;
                var par = new List<KeyValuePair<double, string>>();
                
                for (int i = 0; i < nSamples; i++, date = date.AddSeconds(secondsInterval).AddMilliseconds(46)) // * (range > 0 ? range * 1.1 : 1)))
                {
                    range = random.NextDouble();

                    var watt = 2.8;
                    var volt = (double)random.Next(120, 130);
                    var amper = (watt / volt);
                    var kwh = (watt * (date - dateStart).Hours) / 1000;
                    var kw = (volt * amper) / 1000;

                    j += kwh;

                    //kws.Add(kw);
                    //dates.Add(date.ToShortDateString());

                    par.Add(new KeyValuePair<double, string>(kw, date.ToShortDateString()));

                    //file.WriteLine(String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}", mac, kw, kwh, j / i, amper, volt, date.ToString("dd/MM/yyyy HH:mm:ss")));
                }

                var datas = par.Select(x => x.Value).Distinct().ToArray();

                for (int i = 0; i < datas.Length; i++)
                {
                    file.WriteLine(String.Format("{0}|{1}", par.Where(x => x.Value == datas[i]).Sum(x => x.Key), datas[i]));
                }
            }

            j = 0.0;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Gilmar\Desktop\data\relatorio_falha.data"))
            {
                var date = dateStart;
                var par = new List<KeyValuePair<double, string>>();

                for (int i = 0; i < nSamples; i++, date = date.AddSeconds(secondsInterval).AddMilliseconds(46)) // * (range > 0 ? range * 1.1 : 1)))
                {
                    range = random.NextDouble();

                    var watt = 2.8;
                    var volt = (double)random.Next(120, 130);
                    var amper = (watt / volt);
                    var kwh = (watt * (date - dateStart).Hours) / 1000;
                    var kw = (volt * amper) / 1000;

                    j += kwh;

                    //file.WriteLine(String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}", mac, kw, kwh, j / i, amper, volt, date.ToString("dd/MM/yyyy HH:mm:ss")));

                    par.Add(new KeyValuePair<double, string>(0, date.ToShortDateString()));
                }

                var datas = par.Select(x => x.Value).Distinct().ToArray();

                for (int i = 0; i < datas.Length; i++)
                {
                    file.WriteLine(String.Format("{0}|{1}", par.Where(x => x.Value == datas[i]).Sum(x => x.Key), datas[i]));
                }
            }

            System.Console.WriteLine("Media kwh: " + j/nSamples);
            System.Console.ReadKey();            
        }
    }
}
