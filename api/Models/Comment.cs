using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Coments
    {
        public int Id { get; set;}

        public string Title { get; set;} = string.Empty;
        public string Content { get; set;} = string.Empty ;

        public DateTime Created { get; set;} = DateTime.Now;
        public int? StockModelId { get; set; }

        //Navigation property
        public StockModel? StockModel { get; set; }
    }
}