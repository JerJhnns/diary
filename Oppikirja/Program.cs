using System;
using System.Collections.Generic;
using System.IO;

namespace Oppikirja
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Topic> topic = new List<Topic>();
            Topic topi = new Topic();

            
                
            
            
            
            Console.WriteLine("Anna aiheen tunniste");
                topi.Id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Aiheen otsikko");
                topi.Title = Console.ReadLine();

                Console.WriteLine("Anna aiheen kuvaus");
                topi.Description = Console.ReadLine();

                Console.WriteLine("Anna aika arvio h.m");
                topi.EstimatedTimeToMaster = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Kauanko olet opiskellut h.m");
                topi.TimeSpent = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Anna mahdollinen lähde: ");
                topi.Source = Console.ReadLine();

                Console.WriteLine("Anna aloitus aika: yyyy, mm, dd ");
                topi.StartLearningDate = Convert.ToDateTime(Console.ReadLine()); 

            Console.WriteLine("Onko opiskelu kesken? Y/N");
                var valinta = Console.ReadLine();
             

                if (valinta == "N")
                {
                topi.InProgress = false;
                    Console.WriteLine("Milloin sait valmiiksi? yyyy, mm, dd");
                    topi.CompletionDate = Convert.ToDateTime(Console.ReadLine());
              

                Console.WriteLine(topi.Id + "\n" + topi.Title + "\n" + topi.Description + "\n" + topi.EstimatedTimeToMaster + "\n"
                 + topi.TimeSpent + "\n" + topi.Source + "\n" + topi.StartLearningDate + "\n" + topi.CompletionDate + "\n" + topi.InProgress);

                }

                if(valinta == "Y")
                {
                topi.InProgress = true;
                Console.WriteLine(topi.Id + "\n" + topi.Title + "\n" + topi.Description + "\n" + topi.EstimatedTimeToMaster + "\n"
                 + topi.TimeSpent + "\n" + topi.Source + "\n" + topi.StartLearningDate + "\n" + topi.InProgress);
                
            }

            else { }

            String path = @"C:\Users\Jere\source\repos\Oppikirja\Id.txt";
            File.AppendAllText(path, Convert.ToString(topi.Id + "\n" + topi.Title + "\n" + topi.Description + "\n" + topi.EstimatedTimeToMaster + "\n"
                + topi.TimeSpent + topi.Source + "\n" + topi.StartLearningDate + "\n" + topi.InProgress + "\n" + topi.CompletionDate) + Environment.NewLine);
            StreamReader sr = new StreamReader(@"C:\Users\Jere\source\repos\Shopping\Shoppinglist.txt");


            
                
        }
        }
    }
   
    
    
