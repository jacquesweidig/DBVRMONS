using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hackaton.Models
{
    public class Vote
    {
        public int id { get; set; }
        public string caseName {get; set;}
        public int note { get; set; }
        public string vocal    { get; set; }
    }
}