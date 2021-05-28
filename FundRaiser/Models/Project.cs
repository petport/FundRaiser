﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundRaiser.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string Photo { get; set; }
        public string Video { get; set; }
        public string Status { get; set; }

        //public User Creator { get; set; }
        //public List<FundProject> FundProject { get; set; }

        public DateTime ExpireDate { get; set; }
        public DateTime StartDate { get; set; }
        //TotalAmount gia trending projects (calculated method kalytera kai vasei aytou ftiaxnw ta trending)
        
        //selected package
    }
}
