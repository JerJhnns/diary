using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Oppikirja
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*var path = @"C:\Users\Jere\source\repos\Oppikirja\Id.txt"; // Habeeb, "Dubai Media City, Dubai"
            using (TextFieldParser csvParser = new TextFieldParser(path))
            {
                csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                // Skip the row with the column names
                csvParser.ReadLine();

                while (!csvParser.EndOfData)
                {
                    // Read current line fields, pointer moves to the next line.
                    string[] fields = csvParser.ReadFields();
                     = fields[0];
                    string Address = fields[1];
                }
            }
            */
            Console.WriteLine("---------------------------");
            Console.WriteLine("\tTERVETULOA");
            Console.WriteLine("---------------------------");
            int valinta ;
            Dictionary<int, Topic> uusTopi = new Dictionary<int, Topic>();
           

            do
            {
                Console.WriteLine(
                    "Vaihtoehtosi \nValitse 1: Jos haluat lisätä opinnon. " +
                    "\nValitse 2: Jos haluat tarkastaa tietoja Id:llä tai Titlellä \n" +
                    "Valitse 3: Jos haluat tyhjentää tiedot " +
                    "\nValitse 4 Jos haluat " +
                    "\nValitse 5 jos haluat lopettaa.");

                valinta = Convert.ToInt32(Console.ReadLine());

                switch (valinta)
                {
                    case 1:
                        Console.Clear();
                        Method.Methodman(uusTopi);
                        
                        break;
                    case 2:
                        Console.Clear();
                        Method.Redman(uusTopi);
                        break;
                    case 3:
                        Console.Clear();
                        Method.Raekwon();
                        break;
                    case 4:
                        Console.Clear();
                        Method.Ghostfacekillah();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("\tTervemenoa!");
                        Console.WriteLine("---------------------------");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("---------------------------");
                        Console.WriteLine( "\nInvalid choice mate\n");
                        Console.WriteLine("---------------------------");
                        break;
                }
                
            }
            
            while (valinta != 5) ;
        }  
        }
    }





