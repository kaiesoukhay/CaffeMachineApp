using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcess.Models
{
    public  class Clients
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string TypeOfDrink { get; set; }
        public int Suguar { get; set; }
        public bool Mug { get; set; }
    }
}
