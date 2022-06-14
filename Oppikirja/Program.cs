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
            string path = @"C:\Users\Jere\source\repos\Oppikirja\Id.txt";
            Topic topi = new Topic();
            
            int valinta ;
            
            Dictionary<int, Topic> uusTopi = new Dictionary<int, Topic>();
            


            Method.OldDirtyBastard(path,  topi, uusTopi);




            Console.WriteLine("---------------------------");
            Console.WriteLine("\tTERVETULOA");
            Console.WriteLine("---------------------------");

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
                        Method.Methodman(path,uusTopi,topi );
                        
                        break;
                    case 2:
                        Console.Clear();
                        Method.Redman(uusTopi, topi, path);
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





