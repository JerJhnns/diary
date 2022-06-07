using System;
using System.Collections.Generic;

namespace Oppikirja
{
    class Program
    {
        static void Main(string[] args)
        { 
            List <Topic> topic = new List <Topic>();
            Topic topi = new Topic();

            Console.WriteLine("Anna aiheen tunniste");
            topi.Id =  Convert.ToInt32(Console.ReadLine());

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

            //Console.WriteLine("Onko opiskelu kesken?");
            //topi.InProgress = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Milloin olet valmis yyyy, mm, dd");
            topi.CompletionDate = Convert.ToDateTime(Console.ReadLine());

            topic.Add(topi);
           
            


              Console.WriteLine(topi.Id + topi.Title + topi.Description + topi.EstimatedTimeToMaster
               + topi.TimeSpent + topi.Source + topi.StartLearningDate + topi.CompletionDate);
                

            

            
        }
    }
    class Topic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double EstimatedTimeToMaster { get; set; }
        public double TimeSpent { get; set; }
        public string Source { get; set; }
        public DateTime StartLearningDate { get; set; }
        //public bool InProgress { get; set; }
        public DateTime CompletionDate { get; set; }

      
       
    }
}
