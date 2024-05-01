using Ebana.MyException;
using Ebana.Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebana.APIoperation
{
     class OpAPI
    {

        
        public static async Task FetchDataFromUrl()
        {
            while (true)
            {

                string stop =" ";

                Console.WriteLine("                     URL'yi Qeyd Edin:                       ");
                await Console.Out.WriteLineAsync(" ");
                string urlapi = Console.ReadLine();
                urlapi = $@"{urlapi}";
                 
                using HttpClient hp = new HttpClient();

                try
                {

                    HttpResponseMessage message = await hp.GetAsync(urlapi);
                    if (message.IsSuccessStatusCode)
                    {


                        string data = await message.Content.ReadAsStringAsync();

                        Console.WriteLine(" ");
                        Console.WriteLine("                       API Cavabi:                            ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(data);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("                Emeliyyati Bitirmey Ucun 0                     ");
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("                  API Emeliyyati Ucun  1                       ");
                        Console.WriteLine("                                                               ");
                        Console.WriteLine("                     Duymesini Secin!                          ");
                        stop = Console.ReadLine();  

                    }
                    else
                    {
                        Console.WriteLine("                        Ugursuz!!!                                 ");
                    }
                }
                catch
                {
                    Console.WriteLine(new Error());
                }


                if (stop == "0")
                {

                    Stop.PStop();
                    break;
                }
                else if (stop == "1") { OpAPI.FetchDataFromUrl(); }

            }
             

        }



    }
}
