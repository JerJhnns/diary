﻿using System;
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
        



    }
}
    
