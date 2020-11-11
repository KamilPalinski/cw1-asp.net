using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw1_asp.net.Models
{
    public class ExchangeAddedViewModel
    {
        public int ID { get; set; }
        public int NumberOfCharsInName { get; set; }

        public int NumberOfCharsInDescription { get; set; }

        public bool IsHidden { get; set; }
    }
}