using System;
using System.Collections.Generic;
using System.Web;

namespace KimiaRazi.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string subtitle { get; set; }
        public int TECMin { get; set; }
        public int TECMax { get; set; }
        public int MinSinter { get; set; }
        public int MaxSinter { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
    }
}