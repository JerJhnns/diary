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
using System.Threading;

namespace Oppikirja
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            
            List<Topic> listuri = new List<Topic>();
            Topic topi = new Topic();
            int valinta ;
            Method.Raekwon();
            var context = new DiaryContext();
            //Method.OldDirtyBastard(listuri, context);
           
            
            do
            {

                Console.WriteLine(
                    "\n\n\t\t\tVaihtoehtosi \n\n\n\n\tValitse 1: Jos haluat lisätä opinnon. " +
                    "\n\n\tValitse 2: Jos haluat tarkastaa, muokata tai poistaa Id:llä tai Titlellä" +
                    "\n\n\tValitse 3: Checkata aiheesi" +
                    "\n\n\tValitse 4: jos haluat lopettaa.");
                
                valinta = Convert.ToInt32(Console.ReadLine());

                switch (valinta)
                {
                    case 1:
                        Console.Clear();
                        Method.Methodman(topi );
                        Console.Clear();
                        break;
                    case 2:

                        Console.Clear();
                        Method.Redman( topi, context);
                        Console.Clear();
                        break;

                
                    case 3:
                        Console.Clear();
                        Method.Rza();
                        Console.Clear();
                        break;

                    case 4:
                        Method.OldDirtyBastard();
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





