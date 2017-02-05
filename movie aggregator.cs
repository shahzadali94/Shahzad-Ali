using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace ConsoleApplication1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int ch;
            Console.WriteLine("\n***************MOVIE AGGREGATOR*************");
            Console.WriteLine("\n \nEnter movie name : ");
            string movie=Console.ReadLine();
            Console.WriteLine("\nEnter RunTime :");
            string runtime = Console.ReadLine();
            Console.WriteLine("\nEnter Language : ");
            string lang = Console.ReadLine();
            Console.WriteLine("\nEnter Lead actor : ");
            string leadactor = Console.ReadLine();
            Console.WriteLine("\nEnter Genre:");
            string genre = Console.ReadLine();
            
            do
            {
                Console.WriteLine("Enter the format you would like to export to :");
                Console.WriteLine("1.Text Format");
                Console.WriteLine("2.PDF format");
                string choice= Console.ReadLine();
                Int32.TryParse(choice, out ch);
                
                switch(ch) {
                
                   case 1:
                    text(movie, runtime, leadactor, lang, genre);
                    Console.WriteLine("Successfully exported to text");
                    break;
                    case 2:
                    pdf(movie, runtime, leadactor, lang, genre);
                    Console.WriteLine("Successfull exported to PDF");
                    break;

                

                } 
                
                break;
            }while(ch<3);
          
            

        }
        static void pdf(string a,string b,string c, string d, string e) //function to export into pdf
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(@"D:\Movie.pdf", FileMode.Create));
            doc.Open();
           Paragraph paragraph = new Paragraph(string.Format("***************MOVIE INFO***************\nMovie name :{0}\nRun Time   : {1}\nLead Actor : {2}\nLanguage : {3}\nGenre      : {4}",a,b,c,d,e));
            doc.Add(paragraph);
            
            doc.Close();
            
        }
        static void text(string a, string b, string c, string d, string e) //function to export into text
        {
            Console.ReadLine();
            StreamWriter sw;
            string Filename = @"D:\Movie.txt";
            sw = File.CreateText(Filename);
            sw.WriteLine("\nMovie Name : {0}",a);
            sw.WriteLine("\nRun Time   : {0}",b);
            sw.WriteLine("\nLead Actor : {0}",c);
            sw.WriteLine("\nLanguage   : {0}",d);
            sw.WriteLine("\nGenre      : {0}",e);
            sw.Close();
            Console.ReadLine();
        }
    }
}
