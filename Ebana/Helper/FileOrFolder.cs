using Ebana.MyException;
using Ebana.Start;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ebana.Helper
{  
    class FileOrFolder
    {
           
        
        


        

        public static void FoldOp()
        {
          try
          {



              bool _dongu = true;
           while (_dongu)
           {


            Console.WriteLine("*                   Folderleri Gormek Ucun 1                    *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*                Yeni Folder Elave Etmek Ucun 2                 *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*                    Menuya Qayidmaq Ucun 3                     *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*                       Duymesini Secin                         *");
            Console.WriteLine("*                                                               *");
            int secim = Convert.ToInt32(Console.ReadLine());
             if (secim<=3)
             {

                        switch (secim)
                        {
                            case 1:
                                AddShowLIst.ShowFolders();

                                break;

                            case 2:
                                AddShowLIst.CreateFolder();
                                break;
 
                            case 3:
                                StartProject.PStart();
                                break;
                            case 0:
                                Stop.PStop();
                                _dongu = false;

                                break;



                        }


             }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(new Error());
                        Console.ForegroundColor = ConsoleColor.White;
                        FoldOp();
                    }
             





           }


          }
          catch 
          {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(new Error());
                Console.ForegroundColor = ConsoleColor.White;
                FoldOp();
            }


            
            


        }
        

        public static void FileOp()
        {



            try
            {






                bool _dongu = true;

                while (_dongu)
                {




                    Console.WriteLine("*                   Fayllari Gormek Ucun 1                      *");
                    Console.WriteLine("*                                                               *");
                    Console.WriteLine("*                Yeni Fayl Elave Etmek Ucun 2                   *");
                    Console.WriteLine("*                                                               *");
                    Console.WriteLine("*                    Fayli Oxumaq Ucun 3                        *");
                    Console.WriteLine("*                                                               *");
                    Console.WriteLine("*               Movcud Fayla Yazi Yazmaq Ucun 4                 *");
                    Console.WriteLine("*                                                               *");
                    Console.WriteLine("*                    Menuya Qayidmaq Ucun 5                     *");
                    Console.WriteLine("*                                                               *");
                    Console.WriteLine("*                 Emeliyyati Durdurmaq Ucun 0                   *");
                    Console.WriteLine("*                                                               *");
                    Console.WriteLine("*                       Duymesini Secin                         *");
                    int secim = Convert.ToInt32(Console.ReadLine());
                    if (secim<=5)
                    {


                        switch (secim)
                        {
                            case 1:
                                AddShowLIst.ShowFiles();
                                break;
                            case 2:
                                AddShowLIst.FileAdd();
                                break;
                            case 3:

                                AddShowLIst.ReadFile();

                                break;

                            case 4:
                                AddShowLIst.WriteFile();

                                break;

                            case 5:

                                StartProject.PStart();
                                break;
                            case 0:
                                Stop.PStop();
                                _dongu = false;
                                break;






                        }


                    }
                    else
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(new Error());
                        Console.ForegroundColor = ConsoleColor.White;
                        FileOp();


                    }
                     





                }





            }
            catch  
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(new Error());
                Console.ForegroundColor = ConsoleColor.White;
                FileOp();
            }
            






        }







    }
    
    
    
    
}