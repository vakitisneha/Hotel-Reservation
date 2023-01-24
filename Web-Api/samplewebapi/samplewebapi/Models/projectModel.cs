using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace samplewebapi.Models
{
    public class projectModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string Teamleader { get; set; }
        public string DateOfJoining { get; set; }
        public string startDate { get; set; }
       // public string TeamLeader { get; set; }
        public string projectName { get; set; }
        public int Teamsize { get; set; }
    }
}