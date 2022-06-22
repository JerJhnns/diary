using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;
using System.Globalization;
using System.Text;
using CsvHelper.Configuration;
using System.Data;
using Oppikirja.Models;

namespace Oppikirja
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            
            List<Topic> listuri = new List<Topic>();
            Topic topi = new Topic();
            
            int valinta ;
            Method.OldDirtyBastard( topi,  listuri);
            Console.ForegroundColor
            = ConsoleColor.Blue;
            Console.WriteLine("---------------------------");
            Console.WriteLine("\tTERVETULOA");
            Console.WriteLine("---------------------------");
            Console.ForegroundColor
            = ConsoleColor.White;
            var context = new DiaryContext();
            var t = (from s in context.Table1s select s).ToList();
            foreach( var on in t )
            {
                listuri.Add(new Topic
                {
                    Id = on.Id,
                    Title = on.Title,
                    Description = on.Description,
                    EstimatedTimeToMaster = Convert.ToDouble(on.TimeToMaster),
                    TimeSpent = Convert.ToDouble(on.TimeSpent),
                    Source = on.Source,
                    StartLearningDate = Convert.ToDateTime(on.StartLearningDate),
                    InProgress = Convert.ToBoolean(on.InProgress),
                    CompletionDate = Convert.ToDateTime(on.CompletionDate)
                });
            };
            


            do
            {

                Console.WriteLine(
                    "Vaihtoehtosi \nValitse 1: Jos haluat lisätä opinnon. " +
                    "\nValitse 2: Jos haluat tarkastaa, muokata tai poistaa Titlellä \n" +
                    "Valitse 3: Jos haluat tarkastaa, muokata tai poistaa Id:llä" +
                    "\nValitse 4: Jos haluat tyhjentää tiedot txt kansiosta " +
                    "\nValitse 5: Checkata aiheesi" +
                    "\nValitse 6: jos haluat lopettaa.");
                
                valinta = Convert.ToInt32(Console.ReadLine());

                switch (valinta)
                {
                    case 1:
                        Console.Clear();
                        Method.Methodman(topi, listuri );
                        Console.Clear();
                        break;
                    case 2:

                        Console.Clear();
                        Method.Redman( topi, listuri, context);
                        Console.Clear();
                        break;

                    case 3:
                        Console.Clear();
                        Method.Ghostfacekillah(topi, listuri);
                        Console.Clear();
                        break;

                    case 4:
                        Console.Clear();
                        
                        Console.Clear();
                        break;
                        
                    case 5:
                        Console.Clear();
                        Method.Rza(listuri);
                        Console.Clear();
                        break;

                    case 6:
                        Console.Clear();
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("\tTervemenoa!");
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("\n\n\n\n\nSovellus on myynnissä lähtöhinta: 1 euro enemmän kuin Wolt");
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("---------------------------");
                        Console.WriteLine( "\nInvalid choice mate\n");
                        Console.WriteLine("---------------------------");
                        break;
                }
               
                
            }
            
            while (valinta != 6) ;
        }  
        }
    }





