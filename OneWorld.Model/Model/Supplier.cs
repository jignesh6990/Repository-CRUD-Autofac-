using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneWorld.Model
{
   
   public class Supplier:Entity<int>
    {
        public override int Id { get; set; }

        public string CompanyName { get; set; }

        public string ContactName { get; set; }

        public string ContactTitle { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string Phone { get; set;}

        public string Fax { get; set; }
    }
}
