using System;
using System.Collections.Generic;

#nullable disable

namespace Oppikirja.Models
{
    public partial class Table1
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? TimeToMaster { get; set; }
        public int? TimeSpent { get; set; }
        public string Source { get; set; }
        public DateTime? StartLearningDate { get; set; }
        public bool? InProgress { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string Tulostus()
        {
            return $"ID: {Id}\nAihe: {Title}\nKuvaus {Description}\nSinulla on : {TimeToMaster - TimeSpent}h jäljellä\n" +
                $"Lähde: {Source}\nOpiskelusi on vielä kesken mutta olet opiskellut {(Convert.ToDateTime(CompletionDate) - Convert.ToDateTime(StartLearningDate)).TotalDays} päivää";
        }
        public string Jalostus()
        {
            return $"ID: {Id}\nAihe: {Title}\nKuvaus {Description}\nSinulla on : {TimeToMaster - TimeSpent}h jäljellä\n" +
                $"Lähde: {Source}\nSait opiskelusi valmiiksi {(Convert.ToDateTime(CompletionDate) - Convert.ToDateTime(StartLearningDate)).TotalDays} päivässä";
        }
    }

}
