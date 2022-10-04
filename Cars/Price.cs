using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cars
{
    class Price
    {
        
        public int Id { get; set; }
        public string Name_detals { get; set; }
        public string Params { get; set; }

        public int amount{ get; set; }

        [Column(TypeName = "money")]
        public int  PriceDetal { get; set; }

    }
}
