using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KimiaRazi.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string subtitle { get; set; }
        public string TECMin { get; set; }
        public string TECMax { get; set; }
        public string MinSinter { get; set; }
        public string MaxSinter { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
    }
}