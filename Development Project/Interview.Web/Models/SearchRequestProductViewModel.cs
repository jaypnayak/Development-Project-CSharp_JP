using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interview.Web.Models
{
    public class SearchRequestProductViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ValidSkus { get; set; }
    }
}
