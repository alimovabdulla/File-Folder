using Ebana.Helper;
using Ebana.MyException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Ebana.Start
{
    internal class StartProject
    {
        public   static void PStart()
        {


            try
            {


                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine("|                  File/Folder Operations                       |");
                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine("*                                                               *");
                Console.WriteLine("*                                                               *");
                Console.WriteLine("*                 Folder Emeliyyati Ucun 1                      *");
                Console.WriteLine("*                                                               *");
                Console.WriteLine("*                  File Emeliyyati Ucun 2                       *");
                Console.WriteLine("*                                                               *");
                Console.WriteLine("*                     Duymesini Secin                           *");
                Console.WriteLine("*                                                               *");
                Console.WriteLine("*                                                               *");
                int _secim = Convert.ToInt32(Console.ReadLine());

                if (_secim<=2)
                {

                    switch (_secim)
                    {

                        case 1:
                            FileOrFolder.FoldOp();
                            break;
                        case 2:
                            FileOrFolder.FileOp();
                            break;








                    }


                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(new Error());
                    Console.ForegroundColor = ConsoleColor.White;
                     PStart();
                }
                 

            }
            catch  (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine( new Error());
                Console.ForegroundColor = ConsoleColor.White;
                StartProject.PStart();
            }







 



        }
         




















    }
}
