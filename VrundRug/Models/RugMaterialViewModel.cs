using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace VrundRug.Models
{
    public class RugMaterialViewModel
    {
        public List<Rug> Rugs { get; set; }
        public SelectList Materials { get; set; }
        public string RugMaterial { get; set; }
        public string SearchString { get; set; }
    }
}
