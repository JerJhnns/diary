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
            // List<Topic> topic = new List<Topic>();
            Topic topi = new Topic();
            


            Console.WriteLine("Anna aiheen tunniste");
            topi.Id = Convert.ToInt32(Console.ReadLine());
            //topic.Add();
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
           
                Console.WriteLine("Anna aloitus aika: dd/MM/yyyy ");
                topi.StartLearningDate = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Onko opiskelu kesken? Y/N");
                var valinta = Console.ReadLine();
          

                if (valinta == "N")
                {
                    topi.InProgress = false;
                    Console.WriteLine("Milloin sait valmiiksi? dd/MM/yyyy");
                    topi.CompletionDate = Convert.ToDateTime(Console.ReadLine());


                    Console.WriteLine(topi.Id + "\n" + topi.Title + "\n" + topi.Description + "\n" + topi.EstimatedTimeToMaster + "\n"
                     + topi.TimeSpent + "\n" + topi.Source + "\n" + topi.StartLearningDate + "\n" + topi.CompletionDate + "\n" + topi.InProgress);

                }

                if (valinta == "Y")
                {
                    topi.InProgress = true;
                    Console.WriteLine(topi.Id + "\n" + topi.Title + "\n" + topi.Description + "\n" + topi.EstimatedTimeToMaster + "\n"
                     + topi.TimeSpent + "\n" + topi.Source + "\n" + topi.StartLearningDate + "\n" + topi.InProgress + "\n" + topi.CompletionDate);

                }

                else { }
            
            //Topic.Method();
            

            String path = @"C:\Users\Jere\source\repos\Oppikirja\Id.txt";
            string a =  Convert.ToString(topi.Id+"," + topi.Title + "," + topi.Description + "," + topi.EstimatedTimeToMaster + "," +
                    +topi.TimeSpent + "," + topi.Source + "," + topi.StartLearningDate + "," + topi.InProgress + "," + topi.CompletionDate);
            
            File.AppendAllText(path, a + Environment.NewLine);
            StreamReader sr = new StreamReader(@"C:\Users\Jere\source\repos\Shopping\Shoppinglist.txt");
            //to be continue



        }
    }
   
}




