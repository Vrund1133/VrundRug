using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace VrundRug.Models
{
    public class Rug
    {
        public int Id { get; set; }
        public string MfgPlace { get; set; }

        [DataType(DataType.Date)]
        public DateTime MfgDate { get; set; }
        public string Designs { get; set; }
        public string Material { get; set; }
        public decimal Price { get; set; }
    }
}
