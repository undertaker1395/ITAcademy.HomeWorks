using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW11.Models
{
    public class Moto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Odometer { get; set; }

    }
}
