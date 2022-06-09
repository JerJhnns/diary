using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Oppikirja
{
    public class Topic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double EstimatedTimeToMaster { get; set; }
        public double TimeSpent { get; set; }
        public string Source { get; set; }
        public DateTime StartLearningDate { get; set; }
        public bool InProgress { get; set; }
        public DateTime CompletionDate { get; set; }

        /*public static void Method()
        {
          
            String path = @"C:\Users\Jere\source\repos\Oppikirja\Id.txt";
            string a = Convert.ToString(Id + "," + Title + "," + Description + "," + topi.EstimatedTimeToMaster + "," +
                    +topi.TimeSpent + "," + topi.Source + "," + topi.StartLearningDate + "," + topi.InProgress + "," + topi.CompletionDate);

            File.AppendAllText(path, a + Environment.NewLine);
            StreamReader sr = new StreamReader(@"C:\Users\Jere\source\repos\Shopping\Shoppinglist.txt");*/
        }
    }

