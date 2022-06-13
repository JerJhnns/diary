using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Oppikirja
{
    public class Topic
    {
        
        public int Id;
        public string Title;
        public string Description;
        public double EstimatedTimeToMaster;
        public double TimeSpent;
        public string Source;
        public DateTime StartLearningDate;
        public bool InProgress;
        public DateTime CompletionDate;
        public Topic()
        {
            


        }
       /* public Topic(int id)
        {
            this.Id = id;
            

        }
        public Topic(int id, string title)
        {
            this.Id = id;
            
            

        }
        public Topic(int id, string title, string des)
        {
            this.Id = id;
            this.Title = title;
            this.Description = des;
            

        }
        public Topic(int id, string title, string des, double etm)
        {
            this.Id = id;
            this.Title = title;
            this.Description = des;
            this.EstimatedTimeToMaster = etm;
           

        }
        public Topic(int id, string title, string des, double etm, double ts)
        {
            this.Id = id;
            this.Title = title;
            this.Description = des;
            this.EstimatedTimeToMaster = etm;
            this.TimeSpent = ts;
           

        }
        public Topic(int id, string title, string des, double etm, double ts, string sou)
        {
            this.Id = id;
            this.Title = title;
            this.Description = des;
            this.EstimatedTimeToMaster = etm;
            this.TimeSpent = ts;
            this.Source = sou;
            

        }
        public Topic(int id, string title, string des, double etm, double ts, string sou,DateTime std)
        {
            this.Id = id;
            this.Title = title;
            this.Description = des;
            this.EstimatedTimeToMaster = etm;
            this.TimeSpent = ts;
            this.Source = sou;
            this.StartLearningDate = std;
            

        }
        public Topic(int id, string title, string des, double etm, double ts, string sou, DateTime std, bool ip)
        {
            this.Id = id;
            this.Title = title;
            this.Description = des;
            this.EstimatedTimeToMaster = etm;
            this.TimeSpent = ts;
            this.Source = sou;
            this.StartLearningDate = std;
            this.InProgress = ip;
           

        }
        public Topic(int id, string title, string des, double etm, double ts, string sou, DateTime std, bool ip, DateTime cd)
        {
            this.Id = id;
            this.Title = title;
            this.Description = des;
            this.EstimatedTimeToMaster = etm;
            this.TimeSpent = ts;
            this.Source = sou;
            this.StartLearningDate = std;
            this.InProgress = ip;
            this.CompletionDate = cd;

        }
        */
       
    }
}

