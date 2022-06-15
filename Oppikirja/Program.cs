using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;
using System.Globalization;
using System.Text;
using CsvHelper.Configuration;

namespace Oppikirja
{
    class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<int, Topic> uusTopi = new Dictionary<int, Topic>();
            List<Topic> listuri = new List<Topic>();
            string path = @"C:\Users\Jere\source\repos\Oppikirja\Id.txt";
            string path2 = @"C:\Users\Jere\source\repos\Oppikirja\uusi.csv";
            Topic topi = new Topic();
            Method.OldDirtyBastard(path, topi, uusTopi, listuri);
            int valinta ;
           
            /*var writer = new StreamWriter(path2);
            var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);

                var newLine = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}", topi.Id, topi.Title, topi.Description, topi.EstimatedTimeToMaster,
             +topi.TimeSpent, topi.Source, topi.StartLearningDate, topi.InProgress, topi.CompletionDate);

            csv.WriteRecords(newLine);*/
            

            




            Console.WriteLine("---------------------------");
            Console.WriteLine("\tTERVETULOA");
            Console.WriteLine("---------------------------");

            do
            {
                Console.WriteLine(
                    "Vaihtoehtosi \nValitse 1: Jos haluat lisätä opinnon. " +
                    "\nValitse 2: Jos haluat tarkastaa tietoja Id:llä tai Titlellä ja muokata niitä \n" +
                    "Valitse 3: Jos haluat tyhjentää tiedot " +
                    "\nValitse 4 Jos haluat " +
                    "\nValitse 5 jos haluat lopettaa.");

                valinta = Convert.ToInt32(Console.ReadLine());
                

                switch (valinta)
                {
                    case 1:
                        Console.Clear();
                        Method.Methodman(path,uusTopi,topi, listuri, path2 );
                        
                        break;
                    case 2:
                        Console.Clear();
                        Method.Redman(uusTopi, topi, path, listuri);
                        break;
                    case 3:
                        Console.Clear();
                        Method.Raekwon();
                        break;
                    case 4:
                        Console.Clear();
                        
                       foreach( var item in listuri)
                        {
                            Console.WriteLine(item.Id);
                            Console.WriteLine(item.Title);
                            Console.WriteLine(item.Description);
                            
                            

                        }

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





