using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace api.Models
{
    public class StockModel
    {
        public int ID    { get; set; }
        public String Symbol { get; set; } = String.Empty;
        public string CompanyName { get; set; } = String.Empty ;

        [Column(TypeName ="decimal (18,2)")]
        public decimal Purchase { get;set;}
         [Column(TypeName ="decimal (18,2)")]
        public decimal LastDiv { get;set;}

        public String Industry { get; set; } = String.Empty;

        public long Marketcap { get; set; }

        public List<Coments> Comments { get; set; } = new List<Coments>();

    }
}