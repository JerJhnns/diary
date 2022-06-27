using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using CsvHelper.Configuration.Attributes;

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

        public string Tulostus()
        {
            return $"ID: {Id}\nAihe: {Title}\nKuvaus {Description}\nSinulla on : {EstimatedTimeToMaster - TimeSpent}h jäljellä\n" +
                $"Lähde: {Source}\nOpiskelusi on vielä kesken mutta olet opiskellut {(CompletionDate - StartLearningDate).TotalDays} päivää";
        }
        public string Jalostus()
        {
            return $"ID: {Id}\nAihe: {Title}\nKuvaus {Description}\nSinulla on : {EstimatedTimeToMaster - TimeSpent}h jäljellä\n" +
                $"Lähde: {Source}\nSait opiskelusi valmiiksi {(CompletionDate - StartLearningDate).TotalDays} päivässä";
        }
        public string Tuli()
        {
            return $"ID: {Id}\nAihe:";
        }
    }
}
    
