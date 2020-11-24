using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw1_asp.net.Models
{
    public class ExchangeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsVisible { get; set; }
    }
}
