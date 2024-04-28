using Ebana.MyException;
using System;
using System.Collections.Generic;
using System.Linq;
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
                string text = Console.ReadLine();
                wr.WriteLine(text);
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
                Console.WriteLine("               Faylin Yolun Ve Adin Qeyd Edin:               ");
                Console.WriteLine("                                                             ");
                string yol = Console.ReadLine();
                string fyol = $@"{yol}";
                File.Create(fyol);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("                                                       ");
                Console.WriteLine("                                                       ");
                Console.WriteLine($"        ({yol})- Fayli Ugurla Yaradildi               ");
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
