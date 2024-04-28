using Ebana.MyException;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
 
namespace Ebana.Helper
{
    internal class AddShowLIst
    {

       
        


        public static void ShowFolders()
        {

           try
           {





             Console.WriteLine("                   Folderin Yolun Qeyd Edin:                     ");
             Console.WriteLine("                                                                 ");

             string path = Console.ReadLine();
             string a = $@"{path}";
             string[] data = Directory.GetDirectories(a);
             foreach (string folder in data)
             {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(folder);
                Console.ForegroundColor = ConsoleColor.White;

             }








           }
           catch  
           {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(new Error());
                Console.ForegroundColor = ConsoleColor.White;
                FileOrFolder.FoldOp();
            }
            
        }
        public static void ShowFiles()
        {
            
            try
            {





             Console.WriteLine("                   Faylin Yolun Qeyd Edin:                       ");
             Console.WriteLine("                                                                 ");

             string fath = Console.ReadLine();
             string c = $@"{fath}";

             string[] data = Directory.GetFiles(c);
             foreach (string folder in data)
             {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(folder);
                Console.ForegroundColor = ConsoleColor.White;
             }








            }
            catch
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(new Error());
                Console.ForegroundColor = ConsoleColor.White;
                FileOrFolder.FileOp();
            }
            


        }
        public static void ReadFile()
        {

             
            try
            {





              Console.WriteLine("                   Faylin Yolun Qeyd Edin:                       ");
             Console.WriteLine("                                                                 ");

             string read = Console.ReadLine();
             string r = $@"{read}";

              using (StreamReader sr = new StreamReader(r))
              {
                Console.ForegroundColor = ConsoleColor.Cyan;
                string text = sr.ReadToEnd();
                Console.WriteLine($"                     {text}");
                Console.ForegroundColor = ConsoleColor.White;

              }








            }
            catch 
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(new Error());
                Console.ForegroundColor = ConsoleColor.White;
                FileOrFolder.FileOp();
            }
            


        }


        public static void WriteFile()
        {


            
            try
            {

             Console.WriteLine("                   Faylin Yolun Qeyd Edin:                       ");
             Console.WriteLine("                                                                 ");

             string write = Console.ReadLine();
             string wrt = $@"{write}";

             using (StreamWriter wr = new StreamWriter(wrt))
             {
                Console.WriteLine("      Elave etmek istediyiniz melumati qeyd edin:");
                Console.WriteLine("                                                             ");
                    string text = Console.ReadLine();
                wr.WriteLine(text);
                    Console.WriteLine("                                                             ");
                    Console.WriteLine($" Melumat Ugurla ( {write} ) faylina Qeyd Edildi");

             }


            }
            catch  
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(new Error());
                Console.ForegroundColor = ConsoleColor.White;
                FileOrFolder.FileOp();

            }

            

        }


        public static void FileAdd()
        {
            
            try
            {
                Console.WriteLine("    Faylin Yolun sonuna (left slash) Qoyaraq  Qeyd Edin:      ");
                Console.WriteLine("                                                              ");
                string yol = Console.ReadLine();
                string fyol = $@"{yol}";
                Console.WriteLine("                                                             ");
                Console.WriteLine("                    Faylin Adin  Qeyd Edin:                  ");
                Console.WriteLine("                                                             ");
                string ad = Console.ReadLine();

                fyol += ad;
                fyol += ".txt";

                File.Create(fyol);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("                                                       ");
                Console.WriteLine("                                                       ");
                Console.WriteLine($"              ({ad})- Fayli Ugurla Yaradildi          ");
                Console.WriteLine("                                                       ");
                Console.WriteLine("                                                       ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(new Error());
                Console.ForegroundColor = ConsoleColor.White;
                FileOrFolder.FileOp();

            }

             



        }

        public static void CreateFolder()
        {

            try
            {
                Console.WriteLine("                  Folderin Yolun  Qeyd Edin:                 ");
                Console.WriteLine("                                                             ");
                string cr = Console.ReadLine();
                string path = $@"{cr}";
                Console.WriteLine("                   Folderin Adin Qeyd Edin:                 ");
                string ad = Console.ReadLine();
                path += ad;

                Directory.CreateDirectory(path);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("                                                       ");
                Console.WriteLine("                                                       ");
                Console.WriteLine($"              ({ad})- Folderi Ugurla Yaradildi!       ");
                Console.WriteLine("                                                       ");
                Console.WriteLine("                                                       ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch  
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(new Error());
                Console.ForegroundColor = ConsoleColor.White;
                FileOrFolder.FileOp();

            }
            






        }
















    }
}
